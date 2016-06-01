namespace mouseCounter
{
    partial class fInfo
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fInfo));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.llbWebsite = new System.Windows.Forms.LinkLabel();
            this.llbGithub = new System.Windows.Forms.LinkLabel();
            this.llbYouTube = new System.Windows.Forms.LinkLabel();
            this.llbTwitter = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mouse Click Counter";
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersion.Location = new System.Drawing.Point(144, 41);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(0, 19);
            this.lbVersion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "© 2016 zekro";
            // 
            // llbWebsite
            // 
            this.llbWebsite.AutoSize = true;
            this.llbWebsite.LinkColor = System.Drawing.Color.Aqua;
            this.llbWebsite.Location = new System.Drawing.Point(145, 87);
            this.llbWebsite.Name = "llbWebsite";
            this.llbWebsite.Size = new System.Drawing.Size(78, 13);
            this.llbWebsite.TabIndex = 5;
            this.llbWebsite.TabStop = true;
            this.llbWebsite.Text = "Website (GER)";
            this.llbWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbWebsite_LinkClicked);
            // 
            // llbGithub
            // 
            this.llbGithub.AutoSize = true;
            this.llbGithub.LinkColor = System.Drawing.Color.Aqua;
            this.llbGithub.Location = new System.Drawing.Point(145, 108);
            this.llbGithub.Name = "llbGithub";
            this.llbGithub.Size = new System.Drawing.Size(90, 13);
            this.llbGithub.TabIndex = 6;
            this.llbGithub.TabStop = true;
            this.llbGithub.Text = "Github (GER/EN)";
            this.llbGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbGithub_LinkClicked);
            // 
            // llbYouTube
            // 
            this.llbYouTube.AutoSize = true;
            this.llbYouTube.LinkColor = System.Drawing.Color.Aqua;
            this.llbYouTube.Location = new System.Drawing.Point(248, 108);
            this.llbYouTube.Name = "llbYouTube";
            this.llbYouTube.Size = new System.Drawing.Size(83, 13);
            this.llbYouTube.TabIndex = 7;
            this.llbYouTube.TabStop = true;
            this.llbYouTube.Text = "YouTube (GER)";
            this.llbYouTube.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbYouTube_LinkClicked);
            // 
            // llbTwitter
            // 
            this.llbTwitter.AutoSize = true;
            this.llbTwitter.LinkColor = System.Drawing.Color.Aqua;
            this.llbTwitter.Location = new System.Drawing.Point(248, 87);
            this.llbTwitter.Name = "llbTwitter";
            this.llbTwitter.Size = new System.Drawing.Size(91, 13);
            this.llbTwitter.TabIndex = 8;
            this.llbTwitter.TabStop = true;
            this.llbTwitter.Text = "Twitter (GER/EN)";
            this.llbTwitter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbTwitter_LinkClicked);
            // 
            // fInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(399, 140);
            this.Controls.Add(this.llbTwitter);
            this.Controls.Add(this.llbYouTube);
            this.Controls.Add(this.llbGithub);
            this.Controls.Add(this.llbWebsite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fInfo";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Information";
            this.Load += new System.EventHandler(this.fInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel llbWebsite;
        private System.Windows.Forms.LinkLabel llbGithub;
        private System.Windows.Forms.LinkLabel llbYouTube;
        private System.Windows.Forms.LinkLabel llbTwitter;
    }
}
