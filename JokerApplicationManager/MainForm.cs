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

        public UserSettings userSettings;        
        
        /// <summary>
        /// Main Form Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            userSettings = new UserSettings();
            this.startTimer();
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
///            Action saveUserSettings = new Action(() =>
///            {
///                userSettings.StatusTimeout = myOptions.
///            }
///            );
            if (myResult == DialogResult.Cancel)
            {
                setStatus("Cancelled");
            }
            else if (myResult == DialogResult.OK)
            {
///                saveUserSettings();
                userSettings.SaveSettings();
                setStatus("Saved");
            }
            else
            {
                setStatus("Invalid");
            }
        }
    

    }
}
