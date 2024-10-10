using DarkModeForms;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarshDatabase
{
    public partial class ReadData : Form
    {
        SqlConnection sqlConnection = null;
        public ReadData()
        {
            InitializeComponent();
            DarkModeCS DM = new DarkModeCS(this);
            DM.ApplyTheme(true);
            string connectionString = "Server=tcp:marsh.database.windows.net,1433;Initial Catalog=Marsh;Persist Security Info=False;User ID=CataclysmicCPU;Password=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            sqlConnection = new SqlConnection(connectionString);

            string ShowNameQuery = "SELECT InGameName AS [Flatnet Name], DiscordName AS [Discord Name] FROM dbo.Member";

            SqlCommand showNameCmd = new SqlCommand(ShowNameQuery, sqlConnection);

            SqlDataAdapter getNameAdapter = new SqlDataAdapter(showNameCmd);

            DataTable nameSelect = new DataTable();
            DataTable joinQuitDate = new DataTable();

            sqlConnection.Open();
            getNameAdapter.Fill(nameSelect);
            sqlConnection.Close();

            QuitDate.Text = "";
            QuitReason.Text = "";
            NameSelect.DataSource = nameSelect;

            NameSelect.Select();
        }

        private void ShowPlayerData(object sender, EventArgs e)
        {
            string searchNameQuery = $"SELECT InGameName AS [Flatnet Name], DiscordName AS [Discord Name] FROM dbo.Member WHERE InGameName LIKE '%{PlayerSearchBox.Text}%' OR DiscordName LIKE '%{PlayerSearchBox.Text}%'";
            SqlCommand sqlSearchCommand = new SqlCommand(searchNameQuery, sqlConnection);
            SqlDataAdapter sqlSearchDataAdapter = new SqlDataAdapter(sqlSearchCommand);
            DataTable searchResults = new DataTable();
            try
            {
                sqlConnection.Open();
                sqlSearchDataAdapter.Fill(searchResults);
            }
            catch (Exception ex) { 
                PopupEventHandler error = new PopupEventHandler(ShowPlayerData);
            }
            sqlConnection.Close();

            NameSelect.DataSource = searchResults;
        }

        private void MemberSelect_SelectionChanged(object sender, EventArgs e)
        {
            if (NameSelect.SelectedCells.Count > 0) {
                QuitDate.Text = "";
                QuitReason.Text = "";
                int selectedRowIndex = NameSelect.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = NameSelect.Rows[selectedRowIndex];
                string inGameNameSelected = Convert.ToString(selectedRow.Cells["Flatnet Name"].Value);
                string discordNameSelected = Convert.ToString(selectedRow.Cells["Discord Name"].Value);

                string Query = $"SELECT InGameName, DiscordName, JoinDate, QuitDate, QuitReason, Mayor, ViceMayor, CouncilRole, ServerBooster, Founder, Admin, MogswampMod, DemotedMayor, MarshPeep, MarshAssociate, Java, Bedrock FROM dbo.Member WHERE InGameName='{inGameNameSelected}'";

                SqlCommand sqlCmd = new SqlCommand(Query, sqlConnection);

                SqlDataAdapter returnAdapter = new SqlDataAdapter(sqlCmd);
                DataTable outputTable = new DataTable();

                try
                {
                    sqlConnection.Open();
                    returnAdapter.Fill(outputTable);
                }
                catch (Exception ex)
                {
                    JoinDateLabel.Text = "An error occured: " + ex.Message;
                    FlatnetNameDisplay.Text = "An error occured.";
                    DiscordNameDisplay.Text = "An error occured";
                } finally { sqlConnection.Close(); }
                if (outputTable != null) { 
                    FlatnetNameDisplay.Text = outputTable.Rows[0].Field<string>("InGameName"); 
                    DiscordNameDisplay.Text = outputTable.Rows[0].Field<string>("DiscordName");
                    JoinDateLabel.Text = "Join Date: " + outputTable.Rows[0].Field<DateTime>("JoinDate").ToString("M/d/yyyy");
                    if (!(outputTable.Rows[0].Field<DateTime?>("QuitDate") == null)) { 
                        QuitDate.Text = "Quit Date: \n" + outputTable.Rows[0].Field<DateTime>("QuitDate").ToString("M/d/yyyy");
                        QuitReason.Text = "Quit Reason: \n" + outputTable.Rows[0].Field<string>("QuitReason");
                    }
                }
                for (int i=0;i < ) { 

                }
                RolesTable.Rows.Add();
            }
        }
    }
}