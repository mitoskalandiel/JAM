using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JAMLib;
using JokerAPI;

namespace JokerApplicationManager
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Main Form Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            Connect jamConnect = new Connect(userSettings.ApiHost,userSettings.ApiUser,userSettings.ApiPass);
            if (jamConnect.isConnected == false)
            {
                var result =  MessageBox.Show("Connection Parameters invalid!\nDo you want to correct this?\n\n(Note: answering NO here will terminate this application", "Joker Application Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if ( result == DialogResult.No)
                {
                    Process.GetCurrentProcess().Kill();
                }
                else if (result == DialogResult.Yes)
                {
                    optionsToolStripMenuItem.PerformClick();
                }
                else
                {
                    throw new Exception("An unknown error occured. Please contact the developer!");
                }
            }
            
            var tempTimer = userSettings.StatusTimeout;
            userSettings.StatusTimeout = 0;
            this.startTimer();
            userSettings.StatusTimeout = tempTimer;
        }
        
        private void closeApp()
        {
            Application.Exit();
        }

        private void clearStatus()
        {
            toolStripStatusLabel2.Text = "";
            this.stopTimer();
        }

        private void setStatus(string text)
        {
            toolStripStatusLabel2.Text = text;
            startTimer();
        }

        private void startTimer()
        {
            if (userSettings.StatusTimeout == 0) { this.timer1.Interval = 1; } else if (userSettings.StatusTimeout>0) { this.timer1.Interval = userSettings.StatusTimeout*1000; }
            this.timer1.Enabled = true;
        }

        private void stopTimer()
        {
            this.timer1.Enabled = false;
        }

    }
}
