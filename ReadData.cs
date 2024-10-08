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
            string connectionString = "Server=tcp:marsh.database.windows.net,1433;Initial Catalog=Marsh;Persist Security Info=False;User ID=CataclysmicCPU;Password={haha this is why you can't build from source};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            sqlConnection = new SqlConnection(connectionString);

            string ShowDataQuery = "SELECT InGameName AS [Flatnet Name], DiscordName AS [Discord Name] FROM dbo.Member";

            SqlCommand sqlCommand = new SqlCommand(ShowDataQuery, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable nameSelect = new DataTable();

            sqlConnection.Open();
            sqlDataAdapter.Fill(nameSelect);
            sqlConnection.Close();

            NameSelect.DataSource = nameSelect;
        }

        private void PlayersSearchBox_TextChanged(object sender, EventArgs e)
        {
            string searchNameQuery = $"SELECT InGameName AS [Flatnet Name], DiscordName AS [Discord Name] FROM dbo.Member WHERE InGameName LIKE '%{PlayersSearchBox.Text}%' OR DiscordName LIKE '%{PlayersSearchBox.Text}%'";
            SqlCommand sqlSearchCommand = new SqlCommand(searchNameQuery, sqlConnection);
            SqlDataAdapter sqlSearchDataAdapter = new SqlDataAdapter(sqlSearchCommand);
            DataTable searchResults = new DataTable();

            sqlConnection.Open();
            sqlSearchDataAdapter.Fill(searchResults);
            sqlConnection.Close();

            NameSelect.DataSource = searchResults;
        }
        private void NameSelect_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ShowPlayerData() {

        }
    }
}
