using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JokerApplicationManager
{
    /// <summary>
    /// This is the start of the application and relies on UserSettings class
    /// </summary>
    public partial class MainForm : Form
    {

        UserSettings userSettings;        
        
        /// <summary>
        /// Main Form Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            userSettings = new UserSettings();
            userSettings.StatusTimeout = 1;
            userSettings.SaveSettings();
            this.startTimer(userSettings.StatusTimeout);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.closeApp();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.clearStatus();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 myAbout = new AboutBox1();
            myAbout.ShowDialog(this);
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OptionsForm myOptions = new OptionsForm();
            var myResult = myOptions.ShowDialog(this);
            if (myResult == DialogResult.Cancel)
            {
                setStatus("Cancelled", userSettings.StatusTimeout);
            }
            else if (myResult == DialogResult.OK)
            {
                userSettings.SaveSettings();
                setStatus("Saved",this.userSettings.StatusTimeout);
            }
            else
            {
                setStatus("Invalid", this.userSettings.StatusTimeout);
            }
        }
    

    }
}
