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
            QuitDate.Text = "";
            QuitReason.Text = "";

            string connectionString = "Server=tcp:marsh.database.windows.net,1433;Initial Catalog=Marsh;Persist Security Info=False;User ID=CataclysmicCPU;Password=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            sqlConnection = new SqlConnection(connectionString);

            string ShowNameQuery = "SELECT InGameName AS [Flatnet Name], DiscordName AS [Discord Name] FROM dbo.Member";

            SqlCommand showNameCmd = new SqlCommand(ShowNameQuery, sqlConnection);

            SqlDataAdapter getNameAdapter = new SqlDataAdapter(showNameCmd);

            DataTable nameSelect = new DataTable();
            DataTable joinQuitDate = new DataTable();
            try
            {
                sqlConnection.Open();
                getNameAdapter.Fill(nameSelect);
                NameSelect.DataSource = nameSelect;
            }
            catch (Exception e)
            {
                QuitReason.Text = "An error occured, please contact CataclysmicCPU and give him this error message: " + e.Message;
            } finally { sqlConnection.Close(); }
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
                RolesTable.Rows.Clear();
                QuitDate.Text = "";
                QuitReason.Text = "";

                int selectedRowIndex = NameSelect.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = NameSelect.Rows[selectedRowIndex];
                string inGameNameSelected = Convert.ToString(selectedRow.Cells["Flatnet Name"].Value);
                string discordNameSelected = Convert.ToString(selectedRow.Cells["Discord Name"].Value);

                string Query = $"SELECT InGameName, DiscordName, JoinDate, QuitDate, QuitReason, AdditionalInfo FROM dbo.Member WHERE InGameName='{inGameNameSelected}'";
                string RoleQuery = $"SELECT Mayor, ViceMayor AS [Vice Mayor], CouncilRole, ServerBooster AS [Server Booster], Admin, MogswampMod AS [Mogswamp Mod], MarshPeep AS [Marsh Peep], MarshAssociate AS [Marsh Associate], Java, Bedrock FROM dbo.Member WHERE InGameName = '{inGameNameSelected}'";

                SqlCommand sqlCmd = new SqlCommand(Query, sqlConnection);
                SqlCommand getRolesCmd = new SqlCommand(RoleQuery, sqlConnection);

                SqlDataAdapter returnAdapter = new SqlDataAdapter(sqlCmd);
                SqlDataAdapter rolesAdapater = new SqlDataAdapter(getRolesCmd);

                DataTable outputTable = new DataTable();
                DataTable rolesOutputTable = new DataTable();

                try
                {
                    sqlConnection.Open();
                    returnAdapter.Fill(outputTable);
                    rolesAdapater.Fill(rolesOutputTable);
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

                foreach (DataColumn dc in rolesOutputTable.Columns) {
                    if (rolesOutputTable.Rows[0].Field<bool>(dc.ColumnName)) { 
                        RolesTable.Rows.Add(dc.ColumnName);
                    }
                    else(!(rolesOutputTable.Rows[0].Field<bool>("CouncilRole") == null) {
                        RolesTable.Rows.Add(rolesOutputTable.Rows[0].Field<bool>("CouncilRole"));
                    }
                }
            }
        }
    }
}