namespace JokerApplicationManager
{
    partial class Splash
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
            this.closeLabel = new System.Windows.Forms.Label();
            this.miniLabel = new System.Windows.Forms.Label();
            this.progressbar1 = new MetroProgressBar.Progressbar();
            this.tasks = new System.Windows.Forms.Label();
            this.splashtime = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeLabel
            // 
            this.closeLabel.AutoSize = true;
            this.closeLabel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.closeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeLabel.Location = new System.Drawing.Point(410, 9);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(17, 17);
            this.closeLabel.TabIndex = 1;
            this.closeLabel.Text = "X";
            this.closeLabel.Click += new System.EventHandler(this.closeLabel_Click);
            this.closeLabel.MouseLeave += new System.EventHandler(this.closeLabel_MouseLeave);
            this.closeLabel.MouseHover += new System.EventHandler(this.closeLabel_MouseHover);
            // 
            // miniLabel
            // 
            this.miniLabel.AutoSize = true;
            this.miniLabel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.miniLabel.Location = new System.Drawing.Point(388, 9);
            this.miniLabel.Name = "miniLabel";
            this.miniLabel.Size = new System.Drawing.Size(16, 17);
            this.miniLabel.TabIndex = 2;
            this.miniLabel.Text = "_";
            this.miniLabel.Click += new System.EventHandler(this.miniLabel_Click);
            this.miniLabel.MouseLeave += new System.EventHandler(this.miniLabel_MouseLeave);
            this.miniLabel.MouseHover += new System.EventHandler(this.miniLabel_MouseHover);
            // 
            // progressbar1
            // 
            this.progressbar1.BackColor = System.Drawing.Color.Transparent;
            this.progressbar1.Location = new System.Drawing.Point(13, 166);
            this.progressbar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressbar1.Name = "progressbar1";
            this.progressbar1.Size = new System.Drawing.Size(411, 17);
            this.progressbar1.TabIndex = 3;
            // 
            // tasks
            // 
            this.tasks.AutoSize = true;
            this.tasks.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tasks.Location = new System.Drawing.Point(13, 219);
            this.tasks.Name = "tasks";
            this.tasks.Size = new System.Drawing.Size(46, 17);
            this.tasks.TabIndex = 4;
            this.tasks.Text = "label1";
            // 
            // splashtime
            // 
            this.splashtime.Interval = 5000;
            this.splashtime.Tick += new System.EventHandler(this.splashtime_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Joker Application Framework";
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(439, 248);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tasks);
            this.Controls.Add(this.progressbar1);
            this.Controls.Add(this.miniLabel);
            this.Controls.Add(this.closeLabel);
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(439, 248);
            this.MinimumSize = new System.Drawing.Size(439, 248);
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label closeLabel;
        private System.Windows.Forms.Label miniLabel;
        private MetroProgressBar.Progressbar progressbar1;
        private System.Windows.Forms.Label tasks;
        private System.Windows.Forms.Timer splashtime;
        private System.Windows.Forms.Label label1;
    }
}