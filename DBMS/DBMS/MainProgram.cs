using System;
using System.Windows.Forms;

namespace DBMS
{
    static class MainProgram
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginPage page = new LoginPage();
            page.Show();
            Application.Run(page);
        }
    }
}
