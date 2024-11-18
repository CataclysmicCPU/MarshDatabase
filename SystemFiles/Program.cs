
using System;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MarshDatabase {
    internal static class Program {
        public static SqlConnection sqlConnection = null;
        public static BootScreen BootScreen = null;
        public static PrivateFontCollection font = new PrivateFontCollection();
        [STAThread]
        static void Main() {
            SetProcessDPIAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            byte[] mainFont = Properties.Resources.Rubik_VariableFont_wght;

            byte[] testFont = Properties.Resources.RubikBubbles_Regular;

            //stack overflows code
            var resourceArr = new[] { mainFont, testFont };

            foreach (var item in resourceArr) {
                Stream fontStream = new MemoryStream(item);

                IntPtr data = Marshal.AllocCoTaskMem((int)fontStream.Length);

                byte[] fontdata = new byte[fontStream.Length];

                fontStream.Read(fontdata, 0, (int)fontStream.Length);

                Marshal.Copy(fontdata, 0, data, (int)fontStream.Length);

                uint cFonts = 0;
                AddFontMemResourceEx(data, (uint)fontdata.Length, IntPtr.Zero, ref cFonts);

                font.AddMemoryFont(data, (int)fontStream.Length);

                fontStream.Close();

                Marshal.FreeCoTaskMem(data);
            }
            //my code again
            string connectionString = "Server=tcp:marsh.database.windows.net,1433;Initial Catalog=Marsh;Persist Security Info=False;User ID=CataclysmicCPU;Password=Teams123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=1;";
            sqlConnection = new SqlConnection(connectionString);

            bool retry = true;
            int retryCount = 0;

            while(retry) {
                try {
                    retry = false;
                    BootScreen = new BootScreen();
                    Application.Run(BootScreen);
                } catch {
                    if (retryCount == 10) { break; }
                    retryCount++;
                    retry = true;
                }
            }
            if (retryCount == 10) {
                MessageBox.Show("There was an error starting the application, please check it is not already running and that it is not stuck and try again. If this persists then contact CataclysmicCPU.");
            }
        }
        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);
    }
}
