﻿using DarkModeForms;
using System;
using System.Threading;
using System.Windows.Forms;
using static MarshDatabase.Program;

namespace MarshDatabase {
    public partial class BootScreen : Form {

        public static MarshDB marshDB;
        Thread BootThread;
        string StatusLabelText = "Booting...";

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
            Thread.Sleep(2000);
            StatusLabelText = "Connecting to Database...";
            while (true) {
                try {
                    sqlConnection.Open();
                    sqlConnection.Close();
                    break;
                } catch (Exception) {
                    StatusLabelText = "Database Offline\nBooting Database...";
                }
            }
            StatusLabelText = "Connection Established.";
        }

        private void ApplicationIdle(object sender, EventArgs e) {
            BootStatusLabel.Text = StatusLabelText;
            if (BootStatusLabel.Text == "Connection Established.") { 
                bootScreen.Close();
            }
        }
        private void BootStatusLabel_Click(object sender, EventArgs e) {
            EasterEggLabel.Text = "Congrats you found an easter egg! (ping lava and say balls, dont tell him and share the easter egg)";
        }
    }
}
