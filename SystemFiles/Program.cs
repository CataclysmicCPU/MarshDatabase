
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MarshDatabase {
    internal static class Program {
        public static SqlConnection sqlConnection = null;
        public static BootScreen bootScreen = null;
        public static readonly string fontFamily = "Cascadia Code";
        [STAThread]
        static void Main() {
            SetProcessDPIAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string connectionString = "Server=tcp:marsh.database.windows.net,1433;Initial Catalog=Marsh;Persist Security Info=False;User ID=CataclysmicCPU;Password=Teams123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=1;";
            sqlConnection = new SqlConnection(connectionString);

            bootScreen = new BootScreen();
            Application.Run(bootScreen);
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
