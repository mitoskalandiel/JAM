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
            this.closeLabel = new System.Windows.Forms.Label();
            this.miniLabel = new System.Windows.Forms.Label();
            this.progressbar1 = new MetroProgressBar.Progressbar();
            this.SuspendLayout();
            // 
            // closeLabel
            // 
            this.closeLabel.AutoSize = true;
            this.closeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeLabel.Location = new System.Drawing.Point(410, 9);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(17, 17);
            this.closeLabel.TabIndex = 1;
            this.closeLabel.Text = "X";
            this.closeLabel.Click += new System.EventHandler(this.closeLabel_Click);
            // 
            // miniLabel
            // 
            this.miniLabel.AutoSize = true;
            this.miniLabel.Location = new System.Drawing.Point(388, 9);
            this.miniLabel.Name = "miniLabel";
            this.miniLabel.Size = new System.Drawing.Size(16, 17);
            this.miniLabel.TabIndex = 2;
            this.miniLabel.Text = "_";
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
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JokerApplicationManager.Properties.Resources.officesplash_6;
            this.ClientSize = new System.Drawing.Size(439, 248);
            this.Controls.Add(this.progressbar1);
            this.Controls.Add(this.miniLabel);
            this.Controls.Add(this.closeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(439, 248);
            this.MinimumSize = new System.Drawing.Size(439, 248);
            this.Name = "Splash";
            this.Text = "Splash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label closeLabel;
        private System.Windows.Forms.Label miniLabel;
        private MetroProgressBar.Progressbar progressbar1;
    }
}