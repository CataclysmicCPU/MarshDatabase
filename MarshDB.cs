using DarkModeForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static MarshDatabase.Program;

namespace MarshDatabase {
    public partial class MarshDB : Form {

        public MarshDB() {
            InitializeComponent();
            DarkModeCS DM = new DarkModeCS(this);
            DM.ApplyTheme(true);
            
            DataGridView[] dataGridView = new DataGridView[] { NameSelect };
            string ShowNameQuery = "SELECT InGameName AS [Flatnet Name], DiscordName AS [Discord Name] FROM dbo.Member";

            SqlCommand showNameCmd = new SqlCommand(ShowNameQuery, sqlConnection);

            SqlDataAdapter getNameAdapter = new SqlDataAdapter(showNameCmd);

            DataTable nameSelect = new DataTable();
            try {
                sqlConnection.Open();
                getNameAdapter.Fill(nameSelect);
            } catch (Exception e) {
                //PlayerInfoLabel.Text = "An error occured, please contact CataclysmicCPU and give him this error message: " + e.Message;
            } finally { sqlConnection.Close(); }
            dataGridView[0].DataSource = nameSelect;

            dataGridView[0].Select();
        
          }

        private void ShowPlayerData(object sender, EventArgs e) {

            string searchNameQuery = $"SELECT InGameName AS [Flatnet Name], DiscordName AS [Discord Name] FROM dbo.Member WHERE InGameName LIKE '%{PlayerSearch.Text}%' OR DiscordName LIKE '%{PlayerSearch.Text}%'";

            SqlCommand sqlSearchCommand = new SqlCommand(searchNameQuery, sqlConnection);

            SqlDataAdapter sqlSearchDataAdapter = new SqlDataAdapter(sqlSearchCommand);

            DataTable searchResults = new DataTable();

            try {
                sqlConnection.Open();
                sqlSearchDataAdapter.Fill(searchResults);
            } catch (Exception ex) {

            } finally { sqlConnection.Close(); }
            NameSelect.DataSource = searchResults;
        }
        private void SwapToClaimView(object sender, DataGridViewCellEventArgs e) {
            
        }
    }
}