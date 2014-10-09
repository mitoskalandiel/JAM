using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JAMLib;
using JokerAPI;

namespace JokerApplicationManager
{
    /// <summary>
    /// This is the start of the application and relies on UserSettings class
    /// This specific Class only handles all form events
    /// MainForm.Functions deals with all the computing behind it
    /// UserSettings contains a handle into the user changeable settings
    /// </summary>
    public partial class MainForm : Form
    {

        
        /// <summary>
        /// Contains an instance of the UserSettings
        /// </summary>
        UserSettings userSettings = UserSettings.Instance;

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
            if (myResult == DialogResult.OK)
            {
                setStatus("Settings Saved!");
            }
            else
            {
                setStatus("Invalid");
            }
        }

    }
}
