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
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.btnRules = new System.Windows.Forms.PictureBox();
            this.btnJackpot = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnJackpot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Image = global::FinkiSlots.Properties.Resources.btnPlay;
            this.btnPlay.Location = new System.Drawing.Point(76, 347);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(214, 72);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPlay.TabIndex = 0;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnRules
            // 
            this.btnRules.Image = global::FinkiSlots.Properties.Resources.btnRules;
            this.btnRules.Location = new System.Drawing.Point(347, 347);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(214, 72);
            this.btnRules.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRules.TabIndex = 1;
            this.btnRules.TabStop = false;
            this.btnRules.Click += new System.EventHandler(this.btnRules_Click);
            // 
            // btnJackpot
            // 
            this.btnJackpot.Image = global::FinkiSlots.Properties.Resources.btnJackpot;
            this.btnJackpot.Location = new System.Drawing.Point(630, 347);
            this.btnJackpot.Name = "btnJackpot";
            this.btnJackpot.Size = new System.Drawing.Size(214, 72);
            this.btnJackpot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnJackpot.TabIndex = 2;
            this.btnJackpot.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Image = global::FinkiSlots.Properties.Resources.btnExit;
            this.pictureBox1.Location = new System.Drawing.Point(864, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FinkiSlots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinkiSlots.Properties.Resources.background_main1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 506);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnJackpot);
            this.Controls.Add(this.btnRules);
            this.Controls.Add(this.btnPlay);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(900, 506);
            this.MinimumSize = new System.Drawing.Size(900, 506);
            this.Name = "FinkiSlots";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "FinkiSlots";
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnJackpot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnPlay;
        private System.Windows.Forms.PictureBox btnRules;
        private System.Windows.Forms.PictureBox btnJackpot;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

