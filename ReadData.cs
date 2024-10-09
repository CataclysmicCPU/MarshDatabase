using DarkModeForms;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            string connectionString = "Server=tcp:marsh.database.windows.net,1433;Initial Catalog=Marsh;Persist Security Info=False;User ID=CataclysmicCPU;Password=[I think not];MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            sqlConnection = new SqlConnection(connectionString);

            string ShowNameQuery = "SELECT InGameName AS [Flatnet Name], DiscordName AS [Discord Name] FROM dbo.Member";

            SqlCommand showNameCmd = new SqlCommand(ShowNameQuery, sqlConnection);

            SqlDataAdapter getNameAdapter = new SqlDataAdapter(showNameCmd);

            DataTable nameSelect = new DataTable();
            DataTable joinQuitDate = new DataTable();

            sqlConnection.Open();
            getNameAdapter.Fill(nameSelect);
            sqlConnection.Close();

            NameSelect.DataSource = nameSelect;
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
                int selectedRowIndex = NameSelect.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = NameSelect.Rows[selectedRowIndex];
                string inGameNameSelected = Convert.ToString(selectedRow.Cells["Flatnet Name"].Value);
                string discordNameSelected = Convert.ToString(selectedRow.Cells["Discord Name"].Value);

                string getDatesQuery = $"SELECT JoinDate FROM dbo.Member WHERE InGameName='{inGameNameSelected}'";
                string getFlatnetNameQuery = $"SELECT InGameName FROM dbo.Member WHERE InGameName='{inGameNameSelected}'";
                string getDiscordNameQuery = $"SELECT DiscordName FROM dbo.Member WHERE InGameName='{inGameNameSelected}'";

                SqlCommand sqlGetJoinDate = new SqlCommand(getDatesQuery, sqlConnection);
                SqlCommand sqlGetFlatnetName = new SqlCommand(getFlatnetNameQuery, sqlConnection);
                SqlCommand sqlGetDiscordName = new SqlCommand(getDiscordNameQuery, sqlConnection);

                object joinDateResult = null;
                object flatnetNameResult = null;
                object discordNameResult = null;
                try
                {
                    sqlConnection.Open();
                    joinDateResult = sqlGetJoinDate.ExecuteScalar();
                    flatnetNameResult = sqlGetFlatnetName.ExecuteScalar();
                    discordNameResult = sqlGetDiscordName.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    JoinDateLabel.Text = "An error occured: " + ex.Message;
                    FlatnetNameDisplay.Text = "An error occured.";
                    DiscordNameDisplay.Text = "An error occured";
                }
                sqlConnection.Close();
                if (joinDateResult != null) { JoinDateLabel.Text = "Join Date: " + joinDateResult; }
                if (flatnetNameResult != null) { FlatnetNameDisplay.Text = (string)flatnetNameResult; }
                if (discordNameResult != null) { DiscordNameDisplay.Text = (string)discordNameResult; }
            }
        }
    }
}
