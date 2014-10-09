using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;

namespace JokerApplicationManager
{
    /// <summary>
    /// Contains the whole SplashForm and it's functions.
    /// </summary>
    public partial class Splash : Form
    {
        private bool boolStartMe;
        /// <summary>
        /// Splash Screen Constructor
        /// </summary>
        public Splash()
        {
            InitializeComponent();
            tasks.Text = "Initializing ...";
            splashtime.Interval = 2000;
            splashtime.Start();
            tasks.Text = "Checking Connection to JAF API ...";
            splashtime.Interval = 2000;
            splashtime.Start();
            boolStartMe = true;
        }

        /// <summary>
        /// Boolean that holds whether Splash is minimized or not.
        /// </summary>
        public bool IsMinimized = false;

        /// <summary>
        /// Click Event for the Closing "X"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Tick Event for the SplashTimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void splashtime_Tick(object sender, EventArgs e)
        {
            Thread.Sleep(splashtime.Interval);
            splashtime.Stop();
            if (boolStartMe == true) { startApp(); } else { }            
        }

        /// <summary>
        /// This starts the MainForm Form
        /// </summary>
        private void startApp()
        {
            var newThread = new System.Threading.Thread(frmNewFormThread);
            newThread.SetApartmentState(System.Threading.ApartmentState.STA);
            newThread.Start();
            this.Close();
        }

        /// <summary>
        /// Click Event for the Minimize Label "_"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miniLabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            IsMinimized = true;
        }

        /// <summary>
        /// Change colour for the Closing "X" on mouse over
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeLabel_MouseHover(object sender, EventArgs e)
        {
            closeLabel.ForeColor = Color.White;
        }

        /// <summary>
        /// Change colour back for the Closing "X" on mouse leave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeLabel_MouseLeave(object sender, EventArgs e)
        {
            closeLabel.ForeColor = Color.Silver;
        }

        /// <summary>
        /// Change colour for the Minimize "_" on mouse over
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miniLabel_MouseHover(object sender, EventArgs e)
        {
            miniLabel.ForeColor = Color.White;
        }

        /// <summary>
        /// Change colour back for the Minimize "_" on mouse leave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miniLabel_MouseLeave(object sender, EventArgs e)
        {
            miniLabel.ForeColor = Color.Silver;
        }

        /// <summary>
        /// Open the Main Window after determining whether it needs opening minimized or normal
        /// </summary>
        public void frmNewFormThread()
        {
            var frmNewForm = new MainForm();
            if (IsMinimized == true)
            {
                frmNewForm.WindowState = FormWindowState.Minimized;
            } else {
                frmNewForm.WindowState = FormWindowState.Normal;
            }
            Application.Run(frmNewForm);
        }

    }
}
