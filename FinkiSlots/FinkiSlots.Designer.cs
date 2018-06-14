namespace FinkiSlots
{
    partial class FinkiSlots
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnRules = new System.Windows.Forms.Button();
            this.btnJackpot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Image = global::FinkiSlots.Properties.Resources.btnExit;
            this.pictureBox1.Location = new System.Drawing.Point(875, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = global::FinkiSlots.Properties.Resources.btnPlay;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.Location = new System.Drawing.Point(68, 347);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(214, 72);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnRules
            // 
            this.btnRules.BackgroundImage = global::FinkiSlots.Properties.Resources.btnRules;
            this.btnRules.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRules.Location = new System.Drawing.Point(348, 347);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(214, 72);
            this.btnRules.TabIndex = 5;
            this.btnRules.UseVisualStyleBackColor = true;
            this.btnRules.Click += new System.EventHandler(this.btnRules_Click);
            // 
            // btnJackpot
            // 
            this.btnJackpot.BackgroundImage = global::FinkiSlots.Properties.Resources.btnJackpot;
            this.btnJackpot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJackpot.Location = new System.Drawing.Point(633, 347);
            this.btnJackpot.Name = "btnJackpot";
            this.btnJackpot.Size = new System.Drawing.Size(214, 72);
            this.btnJackpot.TabIndex = 6;
            this.btnJackpot.UseVisualStyleBackColor = true;
            this.btnJackpot.Click += new System.EventHandler(this.btnJackpot_Click);
            // 
            // FinkiSlots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinkiSlots.Properties.Resources.background_main1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 506);
            this.Controls.Add(this.btnJackpot);
            this.Controls.Add(this.btnRules);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(900, 506);
            this.MinimumSize = new System.Drawing.Size(900, 506);
            this.Name = "FinkiSlots";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "FinkiSlots";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnRules;
        private System.Windows.Forms.Button btnJackpot;
    }
}

