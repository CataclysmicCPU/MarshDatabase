
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarshDatabase
{
    internal static class Program
    { 
        public static MarshDB marshDB;
        public static SqlConnection sqlConnection = null;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string connectionString = "Server=tcp:marsh.database.windows.net,1433;Initial Catalog=Marsh;Persist Security Info=False;User ID=CataclysmicCPU;Password=Teams123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            sqlConnection = new SqlConnection(connectionString);

            marshDB = new MarshDB();


            Application.Run(marshDB);
        }
    }
}
