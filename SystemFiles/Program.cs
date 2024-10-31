
using System;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MarshDatabase {
    internal static class Program {
        public static SqlConnection sqlConnection = null;
        public static BootScreen bootScreen = null;
        public static readonly string fontFamily = "Cascadia Code";
        public static PrivateFontCollection font = new PrivateFontCollection();
        [STAThread]
        static void Main() {
            SetProcessDPIAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            int fontLength = Properties.Resources.RubikBubbles_Regular.Length;

            byte[] buffer = Properties.Resources.RubikBubbles_Regular;

            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            Marshal.Copy(buffer, 0, data, fontLength);

            font.AddMemoryFont(data, fontLength);

            string connectionString = "Server=tcp:marsh.database.windows.net,1433;Initial Catalog=Marsh;Persist Security Info=False;User ID=CataclysmicCPU;Password=Teams123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=1;";
            sqlConnection = new SqlConnection(connectionString);

            bootScreen = new BootScreen();
            Application.Run(bootScreen);
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
