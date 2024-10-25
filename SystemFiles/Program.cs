
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MarshDatabase {
    internal static class Program {
        public static SqlConnection sqlConnection = null;
        public static BootScreen bootScreen = null;
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string connectionString = "Server=tcp:marsh.database.windows.net,1433;Initial Catalog=Marsh;Persist Security Info=False;User ID=CataclysmicCPU;Password=Teams123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=1;";
            sqlConnection = new SqlConnection(connectionString);

            bootScreen = new BootScreen();
            Application.Run(bootScreen);
        }
    }
}
