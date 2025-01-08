using DarkModeForms;
using MarshDatabase.WriteForms;
using System;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;
using static MarshDatabase.Program;

namespace MarshDatabase {
    public partial class CouncilLogin : Form {
        private Button senderButton;
        private Thread WriteThread;
        private Player WritePlayer;

        public CouncilLogin(Button senderButton) {
            this.senderButton = senderButton;
            InitializeComponent();
            DarkModeCS darkModeCS = new DarkModeCS(this);
            darkModeCS.ApplyTheme(true);

            label2.BackColor = label2.Parent.BackColor;
            ErrorLabel.BackColor = ErrorLabel.Parent.BackColor;

            this.Shown += CouncilLogin_Shown;

            this.ShowDialog();
        }

        private void CouncilLogin_Shown(object sender, EventArgs e) {
            this.ActiveControl = LoginTextBox;
        }

        public void ConfirmLogin(object sender, EventArgs e) {
            string query = "SELECT EditPassword FROM [dbo].[UniqueKeys]";
            string result = null;
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            try {
                sqlConnection.Open();
                result = Convert.ToString(cmd.ExecuteScalar());
            } catch (Exception ex) {

            } finally { sqlConnection.Close(); }

            if (result == LoginTextBox.Text) {
                switch (senderButton.Text) {
                    case "Create Player":
                        WriteThread = new Thread(() => {
                            WritePlayer = new Player();
                        });
                        WriteThread.Start();
                        this.Close();
                        break;
                    case "Edit Selected Player":
                        WriteThread = new Thread(() => {
                            WritePlayer = new Player(senderButton);
                        });
                        WriteThread.Start();
                        this.Close();
                        break;
                    case "Create Claim":
                        break;
                    case "Edit Selected Claim":
                        this.Close();
                        break;
                    case "Create Farm":
                        this.Close();
                        break;
                    case "Edit Selected Farm":
                        this.Close();
                        break;
                    default:
                        ErrorLabel.Text = "Whoops an error :P, contact CataclysmicCPU.";
                    break;
                }
                return;
            } else {
                ErrorLabel.Text = "Incorrect! If you are in council please ask CataclysmicCPU for the password.";
            }
        }
    }
}
