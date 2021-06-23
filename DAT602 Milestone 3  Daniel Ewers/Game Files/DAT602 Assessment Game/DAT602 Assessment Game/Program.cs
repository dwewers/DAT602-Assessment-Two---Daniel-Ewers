using System;
using System.Windows.Forms;

namespace DAT602_Assessment_Game
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
            //Application.Run(MainMenuForm.Instance);
            Application.Run(MainMenuForm.Instance);
        }
    }
}
