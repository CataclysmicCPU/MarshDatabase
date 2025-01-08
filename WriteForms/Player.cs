using DarkModeForms;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static MarshDatabase.Program;
using static MarshDatabase.MarshDB;
using System.Data;

namespace MarshDatabase.WriteForms {
    public partial class Player : Form {
        private bool EditPlayer;
        private string inGameNameSelected;
        public Player() {
            InitializeComponent();
            DarkModeCS darkModeCS = new DarkModeCS(this);
            darkModeCS.ApplyTheme(true);

            SetFonts();
            this.textBox7.Hide();
            this.QuitDatePicker.Hide();
            this.textBox8.Hide();
            this.QuitReasonTextBox.Hide();
            this.DeletePlayerButton.Hide();

            EditPlayer = false;
            this.ShowDialog();
        }

        public Player(Button sender) {
            InitializeComponent();
            DarkModeCS darkModeCS = new DarkModeCS(this);
            darkModeCS.ApplyTheme(true);

            SetFonts();

            DataGridView NameSelect = sender.FindForm().Controls.Find("NameSelect", true)[0] as DataGridView;
            int selectedRowIndex = NameSelect.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = NameSelect.Rows[selectedRowIndex];
            inGameNameSelected = Convert.ToString(selectedRow.Cells["Flatnet Name"].Value);

            string PlayerQuery = $"SELECT InGameName, DiscordName, JoinDate, QuitDate, QuitReason, AdditionalInfo FROM dbo.Member WHERE InGameName='{inGameNameSelected}'";
            string RoleQuery = $"SELECT CouncilRole, ServerBooster, Admin, MogswampMod, MarshPeep, Java FROM dbo.Member WHERE InGameName = '{inGameNameSelected}'";

            SqlCommand getPlayerCmd = new SqlCommand(PlayerQuery, sqlConnection);
            SqlCommand getRolesCmd = new SqlCommand(RoleQuery, sqlConnection);

            SqlDataAdapter playerAdapter = new SqlDataAdapter(getPlayerCmd);
            SqlDataAdapter rolesAdapater = new SqlDataAdapter(getRolesCmd);

            DataTable playerOutputTable = new DataTable();
            DataTable rolesOutputTable = new DataTable();

            try {
                sqlConnection.Open();
                playerAdapter.Fill(playerOutputTable);
                rolesAdapater.Fill(rolesOutputTable);
            } catch (Exception ex) {
                //MessageBox.Show("Oops, the database paused itself, please wait for it to start again.");
                //MarshDB.RestartDB();
            } finally { sqlConnection.Close(); }

            this.IGNTextBox.Text = inGameNameSelected;
            this.DiscordTextBox.Text = playerOutputTable.Rows[0].Field<string>("DiscordName");
            this.JoinDatePicker.Value = playerOutputTable.Rows[0].Field<DateTime>("JoinDate");
            this.playerInfoTextBox.Text = playerOutputTable.Rows[0].Field<string>("AdditionalInfo");
            if (playerOutputTable.Rows[0].Field<DateTime?>("QuitDate") != null) {
                this.QuitDatePicker.Value = playerOutputTable.Rows[0].Field<DateTime>("QuitDate");
            } else {
                this.QuitDatePicker.Checked = false;
                QuitReasonTextBox.Hide();
                QuitReasonTextBox.Clear();
                textBox8.Hide();
            }
            if (playerOutputTable.Rows[0].Field<string>("QuitReason") != null) {
                this.QuitReasonTextBox.Text = playerOutputTable.Rows[0].Field<string>("QuitReason"); 
            } 
            if (rolesOutputTable.Rows[0].Field<string>("CouncilRole")?.ToString() != null) { 
                CouncilTextBox.Text = rolesOutputTable.Rows[0].Field<string>("CouncilRole").ToString();
            }
            if (rolesOutputTable.Rows[0].Field<bool>("ServerBooster") == true) {
                BoosterCheckBox.Checked = true;
            }
            if (rolesOutputTable.Rows[0].Field<bool>("MogswampMod") == true) {
                MogModCheckBox.Checked = true;
            }
            if (rolesOutputTable.Rows[0].Field<bool>("Admin") == true) {
                AdminCheckBox.Checked = true;
            }
            if (rolesOutputTable.Rows[0].Field<bool>("Java") == true) {
                JavaGameRadio.Checked = true;
            } else { 
                BedrockGameRadio.Checked = true;
            }
            if (rolesOutputTable.Rows[0].Field<bool>("MarshPeep") == true) {
                MemberPlayerTypeRadio.Checked = true;
            } else {
                AssocPlayerTypeRadio.Checked = true;
            }

            ConfirmButton.Text = "Edit Player Entry";

            EditPlayer = true;
            this.ShowDialog();
        }

        private void ConfirmButton_Click(object sender, EventArgs e) {
            Console.WriteLine(QuitDatePicker.Checked);
            if (IGNTextBox.Text == "") {
                ErrorLabel.Text = "Please input the player's IGN!";
                return;
            }
            if (DiscordTextBox.Text == "") {
                ErrorLabel.Text = "Please input the player's discord name!";
                return;
            }
            if (MemberPlayerTypeRadio.Checked == false && AssocPlayerTypeRadio.Checked == false) {
                ErrorLabel.Text = "Please input the player's member type!";
                return;
            }
            if (JavaGameRadio.Checked == false && BedrockGameRadio.Checked == false) {
                ErrorLabel.Text = "Please input the player's game type!";
                return;
            }
            if (!EditPlayer) {
                string CmdString = "EXECUTE [dbo].[sp_CreateMember] @InGameName, @DiscordName, @JoinDate, @CouncilRole, @ServerBooster, @Admin, @MogswampMod, @PlayerType, @GameType, @AdditionalInfo";
                using (SqlCommand createPlayerCmd = new SqlCommand(CmdString, sqlConnection)) {
                    createPlayerCmd.Parameters.AddWithValue("@InGameName", IGNTextBox.Text.Trim());
                    createPlayerCmd.Parameters.AddWithValue("@DiscordName", DiscordTextBox.Text.Trim());
                    createPlayerCmd.Parameters.AddWithValue("@JoinDate", JoinDatePicker.Value);
                    createPlayerCmd.Parameters.AddWithValue("@CouncilRole", CouncilTextBox.Text.Trim() == "" ? (object)DBNull.Value : CouncilTextBox.Text.Trim());
                    createPlayerCmd.Parameters.AddWithValue("@ServerBooster", BoosterCheckBox.Checked == true ? 1 : 0);
                    createPlayerCmd.Parameters.AddWithValue("@Admin", AdminCheckBox.Checked == true ? 1 : 0);
                    createPlayerCmd.Parameters.AddWithValue("@MogswampMod", MogModCheckBox.Checked == true ? 1 : 0);
                    createPlayerCmd.Parameters.AddWithValue("@PlayerType", MemberPlayerTypeRadio.Checked == true ? 1 : 0);
                    createPlayerCmd.Parameters.AddWithValue("@GameType", JavaGameRadio.Checked == true ? 0 : 1);
                    createPlayerCmd.Parameters.AddWithValue("@AdditionalInfo", playerInfoTextBox.Text.Trim() == null ? (object)DBNull.Value : playerInfoTextBox.Text.Trim());

                    try {
                        sqlConnection.Open();
                        createPlayerCmd.ExecuteReader();
                        MessageBox.Show("Sucessfully created entry for " + IGNTextBox.Text.Trim() + "!");
                        ResetForm();
                        GlobalEvents = "RefreshSelectionTables";
                    } catch (Exception ex) {
                        MessageBox.Show("There was an error creating the player. Please fully restart the application and if the issue perists then contact CataclysmicCPU");
                    }
                }
            } else {
                string CmdString = $"UPDATE [dbo].[Member] SET InGameName = @InGameName, DiscordName = @DiscordName, JoinDate = @JoinDate, QuitDate = @QuitDate, QuitReason = @QuitReason, CouncilRole = @CouncilRole, ServerBooster = @ServerBooster, Admin = @Admin, MogswampMod = @MogswampMod, MarshPeep = @MarshPeep, MarshAssociate = @MarshAssociate, Java = @Java, Bedrock = @Bedrock, AdditionalInfo = @AdditionalInfo WHERE InGameName = '{inGameNameSelected}'";
                using (SqlCommand editPlayerCmd = new SqlCommand(CmdString, sqlConnection)) {
                    editPlayerCmd.Parameters.AddWithValue("@InGameName", IGNTextBox.Text.Trim());
                    editPlayerCmd.Parameters.AddWithValue("@DiscordName", DiscordTextBox.Text.Trim());
                    editPlayerCmd.Parameters.AddWithValue("@JoinDate", JoinDatePicker.Value);
                    editPlayerCmd.Parameters.AddWithValue("@QuitDate", QuitDatePicker.Checked ? QuitDatePicker.Value : (object)DBNull.Value);
                    editPlayerCmd.Parameters.AddWithValue("@QuitReason", QuitReasonTextBox.Text.Trim() == "" ? (object)DBNull.Value : QuitReasonTextBox.Text.Trim());
                    editPlayerCmd.Parameters.AddWithValue("@CouncilRole", CouncilTextBox.Text.Trim() == "" ? (object)DBNull.Value : CouncilTextBox.Text.Trim());
                    editPlayerCmd.Parameters.AddWithValue("@ServerBooster", BoosterCheckBox.Checked == true ? 1 : 0);
                    editPlayerCmd.Parameters.AddWithValue("@Admin", AdminCheckBox.Checked == true ? 1 : 0);
                    editPlayerCmd.Parameters.AddWithValue("@MogswampMod", MogModCheckBox.Checked == true ? 1 : 0);
                    editPlayerCmd.Parameters.AddWithValue("@MarshPeep", MemberPlayerTypeRadio.Checked == true ? 1 : 0);
                    editPlayerCmd.Parameters.AddWithValue("@MarshAssociate", AssocPlayerTypeRadio.Checked == true ? 1 : 0);
                    editPlayerCmd.Parameters.AddWithValue("@Java", JavaGameRadio.Checked == true ? 1 : 0);
                    editPlayerCmd.Parameters.AddWithValue("@Bedrock", BedrockGameRadio.Checked == true ? 1 : 0);
                    editPlayerCmd.Parameters.AddWithValue("@AdditionalInfo", playerInfoTextBox.Text.Trim() == "" ? (object)DBNull.Value : playerInfoTextBox.Text.Trim());

                    try {
                        sqlConnection.Open();
                        editPlayerCmd.ExecuteReader();
                        MessageBox.Show("Sucessfully edited entry for " + IGNTextBox.Text.Trim() + "!");
                        GlobalEvents = "RefreshSelectionTables";
                    } catch (Exception ex) {
                        MessageBox.Show("There was an error editing the player. Please fully restart the application and if the issue perists then contact CataclysmicCPU");
                    } finally { 
                        sqlConnection.Close();
                    }
                }
            }
        }
        private void DeletePlayer_Click(object sender, EventArgs e) {
            string cmdString = $"DELETE FROM [dbo].[Member] WHERE InGameName  = '{inGameNameSelected}'";
            SqlCommand deletePlayerCmd = new SqlCommand(cmdString, sqlConnection);
            try {
                sqlConnection.Open();
                deletePlayerCmd.ExecuteReader();
                MessageBox.Show("Sucessfully removed entry for " + IGNTextBox.Text.Trim() + "!");
            } catch {
                MessageBox.Show("There was an error editing the player. Please fully restart the application and if the issue perists then contact CataclysmicCPU");
            } finally {
                sqlConnection.Close();
            }
            GlobalEvents = "RefreshSelectionTables";
            this.Close();
        }


        private void ResetForm() { 
            this.IGNTextBox.Clear();
            this.DiscordTextBox.Clear();
            this.JoinDatePicker.Value = DateTime.Today;
            this.CouncilTextBox.Clear();
            this.BoosterCheckBox.Checked = false;
            this.AdminCheckBox.Checked = false;
            this.MogModCheckBox.Checked = false;
            this.MemberPlayerTypeRadio.Checked = false;
            this.AssocPlayerTypeRadio.Checked = false;
            this.JavaGameRadio.Checked = false;
            this.BedrockGameRadio.Checked = false;
            this.playerInfoTextBox.Clear();
        }
        private void SetFonts() {
            Font font9px = new Font(font.Families[0], 9.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Font font11px = new Font(font.Families[0], 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Font DTFont = new Font(font.Families[0], 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);

            this.textBox1.Font = font9px;
            this.textBox2.Font = font9px;
            this.textBox3.Font = font9px;
            this.textBox4.Font = font9px;
            this.textBox5.Font = font9px;
            this.textBox6.Font = font9px;
            this.textBox7.Font = font9px;
            this.textBox8.Font = font9px;
            this.ErrorLabel.Font = font11px;
            this.DiscordTextBox.Font = font11px;
            this.IGNTextBox.Font = font11px;
            this.CouncilTextBox.Font = font11px;
            this.JoinDatePicker.Font = DTFont;
            this.QuitDatePicker.Font = DTFont;
            this.QuitDatePicker.ShowCheckBox = true;
            this.QuitDatePicker.CustomFormat = " MM / dd / yyyy ";
            this.JoinDatePicker.CustomFormat = " MM / DD / yyyy ";
            this.playerInfoTextBox.Font = font11px;
            this.ConfirmButton.Font = font11px;
            this.QuitReasonTextBox.Font = font11px;
            this.DeletePlayerButton.Font = font11px;
        }

        private void QuitDatePicker_MouseDown(object sender, MouseEventArgs e) {
            if (((DateTimePicker)sender).Checked) {
                QuitReasonTextBox.Show();
                textBox8.Show();
            } else {
                QuitReasonTextBox.Hide();
                QuitReasonTextBox.Clear();
                textBox8.Hide();
            }
        }
    }
}
