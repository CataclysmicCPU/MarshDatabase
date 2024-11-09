using DarkModeForms;
using System;
using System.Threading;
using System.Windows.Forms;
using static MarshDatabase.Program;

namespace MarshDatabase {
    public partial class BootScreen : Form {

        public static MarshDB marshDB;
        Thread BootThread;
        string StatusTextBoxText = "Booting...";

        public BootScreen() {
            InitializeComponent();
            DarkModeCS darkModeCS = new DarkModeCS(this);
            darkModeCS.ApplyTheme(true);

            BootThread = new Thread(() => {
                EstablishDBConn();
                marshDB = new MarshDB();
                marshDB.ShowDialog();
            });

            Application.Idle += ApplicationIdle;
            BootThread.Start();
        }
        public void EstablishDBConn() {
            //Thread.Sleep(2000);
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

        private void ApplicationIdle(object sender, EventArgs e) {
            BootStatusLabel.Text = StatusTextBoxText;
            if (BootStatusLabel.Text == "Connection Established.") {
                this.Close();
            }
        }
        private void BootStatusLabel_Click(object sender, EventArgs e) {
            EasterEggLabel.Text = "Congrats you found an easter egg! (ping lava and say \"SCOOPY DOOBY DOO!!!\", dont tell him and share the easter egg)";
        }
    }
}
