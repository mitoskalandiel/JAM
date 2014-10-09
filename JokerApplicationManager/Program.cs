using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using JAMLib;

namespace JokerApplicationManager
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            UserSettings userSettings = UserSettings.Instance;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (userSettings.ShowSplash == true) 
            {
              Application.Run(new Splash());
            }
            else
            {
                Application.Run(new MainForm());
            }
            
        }
    }
}
