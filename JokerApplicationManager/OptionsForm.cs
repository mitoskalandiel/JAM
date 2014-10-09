using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JokerApplicationManager.Properties;
using JokerAPI;
using JAMLib;

namespace JokerApplicationManager
{
    public partial class OptionsForm : Form
    {

        /// <summary>
        /// Contains an instance of the UserSettings
        /// </summary>
        UserSettings userSettings = UserSettings.Instance;
        
        /// <summary>
        /// Options Form Constructor
        /// </summary>
        public OptionsForm()
        {
            InitializeComponent();
            SetDialogOptions();
        }

        private void SetDialogOptions()
        {
            this.numericUpDown1.Value = userSettings.StatusTimeout;
            this.saveOnExitCheckBox.Checked = userSettings.SaveOnExit;
            this.splashCheckBox.Checked = userSettings.ShowSplash;
            this.optionsHostText.Text = userSettings.ApiHost;
            this.optionsUserText.Text = userSettings.ApiUser;
            if (userSettings.ApiPass != "")
            {
                this.optionsPasswordText.Text = ApiBase.Decrypt(userSettings.ApiPass,userSettings.PassPhrase);
            }
        }
        
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            userSettings.StatusTimeout = Convert.ToInt32(this.numericUpDown1.Value);
        }

        private void splashCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            userSettings.ShowSplash = this.splashCheckBox.Checked;
        }

        private void saveOnExitCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            userSettings.SaveOnExit = this.saveOnExitCheckBox.Checked;
        }

        private void optionsHostText_Leave(object sender, EventArgs e)
        {
            userSettings.ApiHost = this.optionsHostText.Text;
        }

        private void optionsUserText_Leave(object sender, EventArgs e)
        {
            userSettings.ApiUser = this.optionsUserText.Text;
        }

        private void optionsPasswordText_Leave(object sender, EventArgs e)
        {
            userSettings.ApiPass = ApiBase.Encrypt(this.optionsPasswordText.Text,userSettings.PassPhrase);
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            this.textBox1.Enabled = false;
        }

    }
}
