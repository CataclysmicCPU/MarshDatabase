using DarkModeForms;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MarshDatabase.Program;

namespace MarshDatabase {
    public partial class BootScreen : Form {
        public static MarshDB marshDB;
        Task<int> BootThread;
        string StatusTextBoxText = "Booting...";

        public BootScreen() {
            InitializeComponent();
            DarkModeCS darkModeCS = new DarkModeCS(this);
            darkModeCS.ApplyTheme(true);

            Label2.BackColor = Label2.Parent.BackColor;
            BootStatusLabel.BackColor = BootStatusLabel.Parent.BackColor;
            EasterEggLabel.BackColor = EasterEggLabel.Parent.BackColor;

            Application.Idle += ApplicationIdle;

            BootThread = new Task<int>(() => {
                //Thread.Sleep(2000);
                EstablishDBConn();
                marshDB = new MarshDB();
                return 0;
            });
            BootThread.Start();
        }

        public void EstablishDBConn() {
            StatusTextBoxText = "Connecting to Database...";
            while (true) {
                try {
                    sqlConnection.Open();
                    sqlConnection.Close();
                    break;
                } catch (Exception) {
                    StatusTextBoxText = "Database Offline\n Booting Database...";
                }
            }
            StatusTextBoxText = "Connection Established.";
        }

        private async void ApplicationIdle(object sender, EventArgs e) {
            BootStatusLabel.Text = StatusTextBoxText;
            if (BootStatusLabel.Text == "Connection Established.") {
                Application.Idle -= ApplicationIdle;
                this.Hide();
                await BootThread;
                this.Close();
            }
        }

        private void BootStatusLabel_Click(object sender, EventArgs e) {
            EasterEggLabel.Text = "Congrats you found an easter egg! (ping lava and say cata sends his regards, dont tell him and share the easter egg)";
        }
    }
}
