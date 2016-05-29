namespace mouseCounter
{
    partial class fSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSettings));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudLeftValue = new System.Windows.Forms.NumericUpDown();
            this.btResetleft = new System.Windows.Forms.Button();
            this.btResetRight = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudRightValue = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btRightPath = new System.Windows.Forms.Button();
            this.btLeftPath = new System.Windows.Forms.Button();
            this.tbRightPath = new System.Windows.Forms.TextBox();
            this.tbLeftPath = new System.Windows.Forms.TextBox();
            this.cbRightToTXT = new System.Windows.Forms.CheckBox();
            this.cbLeftToTXT = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbAutoStart = new System.Windows.Forms.CheckBox();
            this.cbUpdateNotify = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLeftValue)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRightValue)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudLeftValue);
            this.groupBox1.Controls.Add(this.btResetleft);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Counter Left";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Change Value:";
            // 
            // nudLeftValue
            // 
            this.nudLeftValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.nudLeftValue.ForeColor = System.Drawing.Color.White;
            this.nudLeftValue.Location = new System.Drawing.Point(6, 72);
            this.nudLeftValue.Maximum = new decimal(new int[] {
            268435456,
            1042612833,
            542101086,
            0});
            this.nudLeftValue.Name = "nudLeftValue";
            this.nudLeftValue.Size = new System.Drawing.Size(136, 20);
            this.nudLeftValue.TabIndex = 3;
            this.nudLeftValue.ValueChanged += new System.EventHandler(this.nudLeftValue_ValueChanged);
            // 
            // btResetleft
            // 
            this.btResetleft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btResetleft.ForeColor = System.Drawing.Color.White;
            this.btResetleft.Location = new System.Drawing.Point(6, 19);
            this.btResetleft.Name = "btResetleft";
            this.btResetleft.Size = new System.Drawing.Size(136, 23);
            this.btResetleft.TabIndex = 1;
            this.btResetleft.Text = "Reset";
            this.btResetleft.UseVisualStyleBackColor = true;
            this.btResetleft.Click += new System.EventHandler(this.btResetleft_Click);
            // 
            // btResetRight
            // 
            this.btResetRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btResetRight.ForeColor = System.Drawing.Color.White;
            this.btResetRight.Location = new System.Drawing.Point(7, 19);
            this.btResetRight.Name = "btResetRight";
            this.btResetRight.Size = new System.Drawing.Size(135, 23);
            this.btResetRight.TabIndex = 2;
            this.btResetRight.Text = "Reset";
            this.btResetRight.UseVisualStyleBackColor = true;
            this.btResetRight.Click += new System.EventHandler(this.btResetRight_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nudRightValue);
            this.groupBox2.Controls.Add(this.btResetRight);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(171, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 101);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Counter Right";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Change Value:";
            // 
            // nudRightValue
            // 
            this.nudRightValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.nudRightValue.ForeColor = System.Drawing.Color.White;
            this.nudRightValue.Location = new System.Drawing.Point(6, 72);
            this.nudRightValue.Maximum = new decimal(new int[] {
            268435456,
            1042612833,
            542101086,
            0});
            this.nudRightValue.Name = "nudRightValue";
            this.nudRightValue.Size = new System.Drawing.Size(136, 20);
            this.nudRightValue.TabIndex = 3;
            this.nudRightValue.ValueChanged += new System.EventHandler(this.nudRightValue_ValueChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(246, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btRightPath);
            this.groupBox3.Controls.Add(this.btLeftPath);
            this.groupBox3.Controls.Add(this.tbRightPath);
            this.groupBox3.Controls.Add(this.tbLeftPath);
            this.groupBox3.Controls.Add(this.cbRightToTXT);
            this.groupBox3.Controls.Add(this.cbLeftToTXT);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 80);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Write to TXT (COMMING SOON)";
            // 
            // btRightPath
            // 
            this.btRightPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRightPath.ForeColor = System.Drawing.Color.White;
            this.btRightPath.Location = new System.Drawing.Point(246, 41);
            this.btRightPath.Name = "btRightPath";
            this.btRightPath.Size = new System.Drawing.Size(55, 22);
            this.btRightPath.TabIndex = 6;
            this.btRightPath.Text = "Search";
            this.btRightPath.UseVisualStyleBackColor = true;
            // 
            // btLeftPath
            // 
            this.btLeftPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLeftPath.ForeColor = System.Drawing.Color.White;
            this.btLeftPath.Location = new System.Drawing.Point(246, 15);
            this.btLeftPath.Name = "btLeftPath";
            this.btLeftPath.Size = new System.Drawing.Size(55, 22);
            this.btLeftPath.TabIndex = 5;
            this.btLeftPath.Text = "Search";
            this.btLeftPath.UseVisualStyleBackColor = true;
            // 
            // tbRightPath
            // 
            this.tbRightPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.tbRightPath.ForeColor = System.Drawing.Color.White;
            this.tbRightPath.Location = new System.Drawing.Point(65, 43);
            this.tbRightPath.Name = "tbRightPath";
            this.tbRightPath.Size = new System.Drawing.Size(174, 20);
            this.tbRightPath.TabIndex = 4;
            // 
            // tbLeftPath
            // 
            this.tbLeftPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.tbLeftPath.ForeColor = System.Drawing.Color.White;
            this.tbLeftPath.Location = new System.Drawing.Point(65, 17);
            this.tbLeftPath.Name = "tbLeftPath";
            this.tbLeftPath.Size = new System.Drawing.Size(174, 20);
            this.tbLeftPath.TabIndex = 2;
            // 
            // cbRightToTXT
            // 
            this.cbRightToTXT.AutoSize = true;
            this.cbRightToTXT.Location = new System.Drawing.Point(6, 45);
            this.cbRightToTXT.Name = "cbRightToTXT";
            this.cbRightToTXT.Size = new System.Drawing.Size(51, 17);
            this.cbRightToTXT.TabIndex = 1;
            this.cbRightToTXT.Text = "Right";
            this.cbRightToTXT.UseVisualStyleBackColor = true;
            // 
            // cbLeftToTXT
            // 
            this.cbLeftToTXT.AutoSize = true;
            this.cbLeftToTXT.ForeColor = System.Drawing.Color.White;
            this.cbLeftToTXT.Location = new System.Drawing.Point(6, 19);
            this.cbLeftToTXT.Name = "cbLeftToTXT";
            this.cbLeftToTXT.Size = new System.Drawing.Size(44, 17);
            this.cbLeftToTXT.TabIndex = 0;
            this.cbLeftToTXT.Text = "Left";
            this.cbLeftToTXT.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbAutoStart);
            this.groupBox4.Controls.Add(this.cbUpdateNotify);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(12, 206);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(307, 68);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Miscellaneous";
            // 
            // cbAutoStart
            // 
            this.cbAutoStart.AutoSize = true;
            this.cbAutoStart.Location = new System.Drawing.Point(6, 42);
            this.cbAutoStart.Name = "cbAutoStart";
            this.cbAutoStart.Size = new System.Drawing.Size(68, 17);
            this.cbAutoStart.TabIndex = 1;
            this.cbAutoStart.Text = "Autostart";
            this.cbAutoStart.UseVisualStyleBackColor = true;
            this.cbAutoStart.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbUpdateNotify
            // 
            this.cbUpdateNotify.AutoSize = true;
            this.cbUpdateNotify.Location = new System.Drawing.Point(6, 19);
            this.cbUpdateNotify.Name = "cbUpdateNotify";
            this.cbUpdateNotify.Size = new System.Drawing.Size(152, 17);
            this.cbUpdateNotify.TabIndex = 0;
            this.cbUpdateNotify.Text = "Notify if update is available";
            this.cbUpdateNotify.UseVisualStyleBackColor = true;
            // 
            // fSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(331, 315);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.fSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLeftValue)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRightValue)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudLeftValue;
        private System.Windows.Forms.Button btResetleft;
        private System.Windows.Forms.Button btResetRight;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudRightValue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbRightToTXT;
        private System.Windows.Forms.CheckBox cbLeftToTXT;
        private System.Windows.Forms.Button btRightPath;
        private System.Windows.Forms.Button btLeftPath;
        private System.Windows.Forms.TextBox tbRightPath;
        private System.Windows.Forms.TextBox tbLeftPath;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cbUpdateNotify;
        private System.Windows.Forms.CheckBox cbAutoStart;
    }
}