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
    public partial class MainForm : Form
    {

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
            this.timer1.Interval = Decimal.ToInt32(userSettings.StatusTimeout)*1000;
            this.timer1.Enabled = true;
        }

        private void stopTimer()
        {
            this.timer1.Enabled = false;
        }

        private void saveUserSettings()
        {
            
        }

    }
}
