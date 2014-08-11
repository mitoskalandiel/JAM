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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            tasks.Text = "Starting ...";
            Thread.Sleep(1000);
            tasks.Text = "Initializing System ...";
            Thread.Sleep(2000);
            tasks.Text = "Checking Connection to JAF API ...";
            Thread.Sleep(5000);
            splashtime.Start();
            
        }

        public bool IsMinimized = false;

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void splashtime_Tick(object sender, EventArgs e)
        {
            splashtime.Stop();
            var newThread = new System.Threading.Thread(frmNewFormThread);
            newThread.SetApartmentState(System.Threading.ApartmentState.STA);
            newThread.Start();
            this.Close();
        }

        private void miniLabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            IsMinimized = true;
        }

        private void closeLabel_MouseHover(object sender, EventArgs e)
        {
            closeLabel.ForeColor = Color.Silver;
        }

        private void closeLabel_MouseLeave(object sender, EventArgs e)
        {
            closeLabel.ForeColor = Color.Black;
        }

        private void miniLabel_MouseHover(object sender, EventArgs e)
        {
            miniLabel.ForeColor = Color.Silver;
        }

        private void miniLabel_MouseLeave(object sender, EventArgs e)
        {
            miniLabel.ForeColor = Color.Black;
        }

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
