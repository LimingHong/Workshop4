using DesktopAppTravelExperts.Forms;
using System;
using System.Windows.Forms;

namespace DesktopAppTravelExperts
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

            Application.Run(new Dashboard()); // for testing 
            //Application.Run(new LoginPage());
        }
    }
}
