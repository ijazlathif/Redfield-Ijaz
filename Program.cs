using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

            //After login Success it will go to the mainmenu

            Forms.LoginForm LoginFM = new Forms.LoginForm();
            if(LoginFM.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Forms.MainMenuForm());
            }
            else
            {
                Application.Exit();
            }
            
            //Application.Run(new UserManual());
        }
    }
}
