namespace JokerApplicationManager
{
    /// <summary>
    /// This form contains the options dialog and interacts with UserSettings Class
    /// </summary>
    partial class OptionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveOnExitCheckBox = new System.Windows.Forms.CheckBox();
            this.splashCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.optionsPasswordText = new System.Windows.Forms.TextBox();
            this.optionsUserText = new System.Windows.Forms.TextBox();
            this.optionsHostText = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 7);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(821, 352);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(813, 312);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.saveOnExitCheckBox);
            this.panel1.Controls.Add(this.splashCheckBox);
            this.panel1.Location = new System.Drawing.Point(42, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 228);
            this.panel1.TabIndex = 2;
            // 
            // saveOnExitCheckBox
            // 
            this.saveOnExitCheckBox.AutoSize = true;
            this.saveOnExitCheckBox.Checked = true;
            this.saveOnExitCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveOnExitCheckBox.Location = new System.Drawing.Point(4, 32);
            this.saveOnExitCheckBox.Name = "saveOnExitCheckBox";
            this.saveOnExitCheckBox.Size = new System.Drawing.Size(163, 21);
            this.saveOnExitCheckBox.TabIndex = 1;
            this.saveOnExitCheckBox.Text = "Save Settings on Exit";
            this.toolTip1.SetToolTip(this.saveOnExitCheckBox, "Save settings (again) when closing the application.");
            this.saveOnExitCheckBox.UseVisualStyleBackColor = true;
            this.saveOnExitCheckBox.CheckedChanged += new System.EventHandler(this.saveOnExitCheckBox_CheckedChanged);
            // 
            // splashCheckBox
            // 
            this.splashCheckBox.AutoSize = true;
            this.splashCheckBox.Checked = true;
            this.splashCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.splashCheckBox.Location = new System.Drawing.Point(4, 4);
            this.splashCheckBox.Name = "splashCheckBox";
            this.splashCheckBox.Size = new System.Drawing.Size(170, 21);
            this.splashCheckBox.TabIndex = 0;
            this.splashCheckBox.Text = "Enable Splash Screen";
            this.toolTip1.SetToolTip(this.splashCheckBox, "Show Splash Screen during start up?");
            this.splashCheckBox.UseVisualStyleBackColor = true;
            this.splashCheckBox.CheckedChanged += new System.EventHandler(this.splashCheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Status Bar Timeout";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(193, 40);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.numericUpDown1, "How long (in seconds) until The Statusbar resets in the main window.");
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.optionsPasswordText);
            this.tabPage2.Controls.Add(this.optionsUserText);
            this.tabPage2.Controls.Add(this.optionsHostText);
            this.tabPage2.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(813, 312);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Connection";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username";
            this.label3.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Host";
            this.label1.UseWaitCursor = true;
            // 
            // optionsPasswordText
            // 
            this.optionsPasswordText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.optionsPasswordText.Location = new System.Drawing.Point(89, 91);
            this.optionsPasswordText.Name = "optionsPasswordText";
            this.optionsPasswordText.Size = new System.Drawing.Size(100, 22);
            this.optionsPasswordText.TabIndex = 2;
            this.toolTip1.SetToolTip(this.optionsPasswordText, "The password for the API Connection");
            this.optionsPasswordText.Leave += new System.EventHandler(this.optionsPasswordText_Leave);
            // 
            // optionsUserText
            // 
            this.optionsUserText.Location = new System.Drawing.Point(89, 67);
            this.optionsUserText.Name = "optionsUserText";
            this.optionsUserText.Size = new System.Drawing.Size(100, 22);
            this.optionsUserText.TabIndex = 1;
            this.toolTip1.SetToolTip(this.optionsUserText, "The username for the API connection");
            this.optionsUserText.UseWaitCursor = true;
            this.optionsUserText.Leave += new System.EventHandler(this.optionsUserText_Leave);
            // 
            // optionsHostText
            // 
            this.optionsHostText.Location = new System.Drawing.Point(89, 44);
            this.optionsHostText.Name = "optionsHostText";
            this.optionsHostText.Size = new System.Drawing.Size(100, 22);
            this.optionsHostText.TabIndex = 0;
            this.toolTip1.SetToolTip(this.optionsHostText, "The host/server to connect to (IP or Hostname)");
            this.optionsHostText.UseWaitCursor = true;
            this.optionsHostText.Leave += new System.EventHandler(this.optionsHostText_Leave);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 36);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(813, 312);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Advanced";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(800, 302);
            this.textBox1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(758, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Tag = "";
            this.button2.Text = "Close";
            this.toolTip1.SetToolTip(this.button2, "Settings are automatically saved upon change");
            this.button2.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 20;
            this.toolTip1.ToolTipTitle = "Hint";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.Filter = "*settings.xml";
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 405);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Name = "OptionsForm";
            this.Text = "Options ...";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox saveOnExitCheckBox;
        private System.Windows.Forms.CheckBox splashCheckBox;
        private System.Windows.Forms.TextBox optionsPasswordText;
        private System.Windows.Forms.TextBox optionsUserText;
        private System.Windows.Forms.TextBox optionsHostText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}