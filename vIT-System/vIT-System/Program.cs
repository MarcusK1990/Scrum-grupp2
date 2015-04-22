using System;
using System.Windows.Forms;

namespace vIT_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Förskott.frmMyPreShooting());
            //Application.Run(new Login.Login());
        }
    }
}
