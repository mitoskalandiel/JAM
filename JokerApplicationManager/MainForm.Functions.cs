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
            userSettings.SaveSettings();
            Application.Exit();
        }

        private void clearStatus()
        {
            toolStripStatusLabel2.Text = "";
            this.stopTimer();
        }

        private void setStatus(string text, int time = 3000)
        {
            toolStripStatusLabel2.Text = text;
            startTimer(time);
        }

        private void startTimer(int time)
        {
            this.timer1.Interval = time;
            this.timer1.Enabled = true;
        }

        private void stopTimer()
        {
            this.timer1.Enabled = false;
        }

    }
}
