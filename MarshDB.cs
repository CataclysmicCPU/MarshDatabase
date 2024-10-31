using DarkModeForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static MarshDatabase.Program;

namespace MarshDatabase {
    public partial class MarshDB : Form {
        public MarshDB() {
            InitializeComponent();
            DarkModeCS DM = new DarkModeCS(this);
            DM.ApplyTheme(true);



            string ShowPlayerQuery = "SELECT InGameName AS [Flatnet Name], DiscordName AS [Discord Name] FROM dbo.Member";
            string ShowClaimsQuery = "SELECT ClaimName, SECornerX, SECornerY, SECornerZ, NWCornerX, NWCornerY, NWCornerZ FROM dbo.Claim";
            string ShowFarmsQuery = "SELECT AutomatedItem, SECornerX, SECornerY, SECornerZ, NWCornerX, NWCornerY, NWCornerZ FROM dbo.Farm INNER JOIN dbo.Claim ON ShellClaimKey=ClaimKey";

            SqlCommand showNameCmd = new SqlCommand(ShowPlayerQuery, sqlConnection);
            SqlCommand showClaimsCmd = new SqlCommand(ShowClaimsQuery, sqlConnection);
            SqlCommand showFarmCmd = new SqlCommand(ShowFarmsQuery, sqlConnection);

            SqlDataAdapter getFarmAdapater = new SqlDataAdapter(showFarmCmd);
            SqlDataAdapter getNameAdapter = new SqlDataAdapter(showNameCmd);
            SqlDataAdapter getClaimAdapter = new SqlDataAdapter(showClaimsCmd);

            DataTable nameSelectOutput = new DataTable();
            DataTable claimSelectOutput = new DataTable();
            DataTable farmSelectOutput = new DataTable();

            try {
                sqlConnection.Open();
                getNameAdapter.Fill(nameSelectOutput);
                getClaimAdapter.Fill(claimSelectOutput);
                getFarmAdapater.Fill(farmSelectOutput);
            } catch (Exception e) {

            } finally { sqlConnection.Close(); }

            PlayerSelect.DataSource = nameSelectOutput;

            ClaimSelect.Columns.Add("ClaimName", "Claim Name");
            ClaimSelect.Columns.Add("ClaimLocation", "Cords");

            for (int i = 0; i < claimSelectOutput.Rows.Count; i++) {
                if (claimSelectOutput.Rows[i].Field<int?>("SECornerY") == null) {
                    ClaimSelect.Rows.Add(claimSelectOutput.Rows[i].Field<string>("ClaimName"),
                    (claimSelectOutput.Rows[i].Field<int>("SECornerX") + claimSelectOutput.Rows[i].Field<int>("NWCornerX")) / 2 + ", " +
                    (claimSelectOutput.Rows[i].Field<int>("SECornerZ") + claimSelectOutput.Rows[i].Field<int>("NWCornerZ")) / 2
                    );
                } else {
                    ClaimSelect.Rows.Add(
                    claimSelectOutput.Rows[i].Field<string>("ClaimName"),
                    (claimSelectOutput.Rows[i].Field<int>("SECornerX") + claimSelectOutput.Rows[i].Field<int>("NWCornerX")) / 2 + ", " +
                    (claimSelectOutput.Rows[i].Field<int>("SECornerY") + claimSelectOutput.Rows[i].Field<int>("NWCornerY")) / 2 + ", " +
                    (claimSelectOutput.Rows[i].Field<int>("SECornerZ") + claimSelectOutput.Rows[i].Field<int>("NWCornerZ")) / 2
                    );
                }
            }
            FarmSelect.Columns.Add("AutomatedItem", "Automated Item");
            FarmSelect.Columns.Add("Location", "Cords");

            for (int i = 0; i < farmSelectOutput.Rows.Count; i++) {
                if (farmSelectOutput.Rows[i].Field<int?>("SECornerY") == null) {
                    FarmSelect.Rows.Add(
                     farmSelectOutput.Rows[i].Field<string>("AutomatedItem"),
                    (farmSelectOutput.Rows[i].Field<int>("SECornerX") + farmSelectOutput.Rows[i].Field<int>("NWCornerX")) / 2 + ", " +
                    (farmSelectOutput.Rows[i].Field<int>("SECornerZ") + farmSelectOutput.Rows[i].Field<int>("NWCornerZ")) / 2
                    );
                } else {
                    FarmSelect.Rows.Add(
                    farmSelectOutput.Rows[i].Field<string>("AutomatedItem"),
                    (farmSelectOutput.Rows[i].Field<int>("SECornerX") + farmSelectOutput.Rows[i].Field<int>("NWCornerX")) / 2 + ", " +
                    (farmSelectOutput.Rows[i].Field<int>("SECornerY") + farmSelectOutput.Rows[i].Field<int>("NWCornerY")) / 2 + ", " +
                    (farmSelectOutput.Rows[i].Field<int>("SECornerZ") + farmSelectOutput.Rows[i].Field<int>("NWCornerZ")) / 2
                    );
                }
            }
        }

        private void ShowPlayerData(object sender, EventArgs e) {

            string NameSearchQuery = $"SELECT InGameName AS [Flatnet Name], DiscordName AS [Discord Name] FROM dbo.Member WHERE InGameName LIKE '%{PlayerSearch.Text}%' OR DiscordName LIKE '%{PlayerSearch.Text}%'";

            SqlCommand sqlSearchCommand = new SqlCommand(NameSearchQuery, sqlConnection);

            SqlDataAdapter sqlSearchDataAdapter = new SqlDataAdapter(sqlSearchCommand);

            DataTable searchResults = new DataTable();

            try {
                sqlConnection.Open();
                sqlSearchDataAdapter.Fill(searchResults);
            } catch (Exception ex) {

            } finally { sqlConnection.Close(); }

            PlayerSelect.DataSource = searchResults;
        }
        private void ClaimSearchChanged(object sender, EventArgs e) {
            ClaimSelect.Rows.Clear();
            string ClaimSearchQuery = $"SELECT ClaimName, SECornerX, SECornerY, SECornerZ, NWCornerX, NWCornerY, NWCornerZ FROM dbo.Claim WHERE ClaimName LIKE '%{ClaimsSearchBox.Text}%'";

            SqlCommand sqlSearchCommand = new SqlCommand(ClaimSearchQuery, sqlConnection);

            SqlDataAdapter sqlSearchDataAdapter = new SqlDataAdapter(sqlSearchCommand);

            DataTable searchResults = new DataTable();

            try {
                sqlConnection.Open();
                sqlSearchDataAdapter.Fill(searchResults);
            } catch (Exception ex) {

            } finally { sqlConnection.Close(); }

            for (int i = 0; i < searchResults.Rows.Count; i++) {
                if (searchResults.Rows[i].Field<int?>("SECornerY") == null) {
                    ClaimSelect.Rows.Add(searchResults.Rows[i].Field<string>("ClaimName"),
                    (searchResults.Rows[i].Field<int>("SECornerX") + searchResults.Rows[i].Field<int>("NWCornerX")) / 2 + ", " +
                    (searchResults.Rows[i].Field<int>("SECornerZ") + searchResults.Rows[i].Field<int>("NWCornerZ")) / 2
                    );
                } else {
                    ClaimSelect.Rows.Add(
                    searchResults.Rows[i].Field<string>("ClaimName"),
                    (searchResults.Rows[i].Field<int>("SECornerX") + searchResults.Rows[i].Field<int>("NWCornerX")) / 2 + ", " +
                    (searchResults.Rows[i].Field<int>("SECornerY") + searchResults.Rows[i].Field<int>("NWCornerY")) / 2 + ", " +
                    (searchResults.Rows[i].Field<int>("SECornerZ") + searchResults.Rows[i].Field<int>("NWCornerZ")) / 2
                    );
                }
            }
        }
        public void ClearSelction(object sender, EventArgs e) { 
            PlayerSelect.ClearSelection();
            ClaimSelect.ClearSelection();
            FarmSelect.ClearSelection();
        }
        protected override CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                cp.ExStyle &= ~0x02000000;  
                return cp;
            }
        }
    }
}