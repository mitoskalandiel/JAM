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
    public partial class OptionsForm : Form
    {

        UserSettings userSettings;

        /// <summary>
        /// Options Form Constructor
        /// </summary>
        public OptionsForm()
        {
            InitializeComponent();
            userSettings = new UserSettings();
            this.numericUpDown1.Value = userSettings.StatusTimeout/1000;
        }
    }
}
