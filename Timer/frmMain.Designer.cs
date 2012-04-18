namespace Timer
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnSetting = new System.Windows.Forms.Panel();
            this.lblLink = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnExitApp = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSS = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMin = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbHr = new System.Windows.Forms.ComboBox();
            this.pnFront = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.pnSetting.SuspendLayout();
            this.pnFront.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnSetting
            // 
            this.pnSetting.BackColor = System.Drawing.Color.Transparent;
            this.pnSetting.Controls.Add(this.label4);
            this.pnSetting.Controls.Add(this.label3);
            this.pnSetting.Controls.Add(this.label2);
            this.pnSetting.Controls.Add(this.cbSS);
            this.pnSetting.Controls.Add(this.cbMin);
            this.pnSetting.Controls.Add(this.cbHr);
            this.pnSetting.Controls.Add(this.btnExit);
            this.pnSetting.Controls.Add(this.btnSet);
            this.pnSetting.Location = new System.Drawing.Point(0, 26);
            this.pnSetting.Name = "pnSetting";
            this.pnSetting.Size = new System.Drawing.Size(359, 126);
            this.pnSetting.TabIndex = 1;
            this.pnSetting.Visible = false;
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.BackColor = System.Drawing.Color.Transparent;
            this.lblLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink.ForeColor = System.Drawing.Color.Blue;
            this.lblLink.Location = new System.Drawing.Point(238, 155);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(121, 13);
            this.lblLink.TabIndex = 8;
            this.lblLink.Text = "Developed by Wizcoder";
            this.lblLink.Click += new System.EventHandler(this.lbllink_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(2, 3);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Title";
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMin.BackgroundImage")));
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Image = global::Timer.Properties.Resources.Remove;
            this.btnMin.Location = new System.Drawing.Point(326, -1);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(18, 23);
            this.btnMin.TabIndex = 11;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnExitApp
            // 
            this.btnExitApp.BackColor = System.Drawing.Color.Transparent;
            this.btnExitApp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExitApp.BackgroundImage")));
            this.btnExitApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitApp.Image = global::Timer.Properties.Resources.Exit;
            this.btnExitApp.Location = new System.Drawing.Point(344, -1);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(18, 23);
            this.btnExitApp.TabIndex = 10;
            this.btnExitApp.UseVisualStyleBackColor = false;
            this.btnExitApp.Click += new System.EventHandler(this.btnExitApp_Click);
            // 
            // btnSet
            // 
            this.btnSet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSet.BackgroundImage")));
            this.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSet.Image = global::Timer.Properties.Resources.Save;
            this.btnSet.Location = new System.Drawing.Point(148, 87);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(33, 34);
            this.btnSet.TabIndex = 6;
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::Timer.Properties.Resources.Close;
            this.btnExit.Location = new System.Drawing.Point(184, 87);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(33, 34);
            this.btnExit.TabIndex = 7;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "ss";
            // 
            // cbSS
            // 
            this.cbSS.BackColor = System.Drawing.Color.Blue;
            this.cbSS.FormattingEnabled = true;
            this.cbSS.Location = new System.Drawing.Point(226, 37);
            this.cbSS.Name = "cbSS";
            this.cbSS.Size = new System.Drawing.Size(46, 21);
            this.cbSS.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "min";
            // 
            // cbMin
            // 
            this.cbMin.BackColor = System.Drawing.Color.Blue;
            this.cbMin.FormattingEnabled = true;
            this.cbMin.Location = new System.Drawing.Point(145, 37);
            this.cbMin.Name = "cbMin";
            this.cbMin.Size = new System.Drawing.Size(46, 21);
            this.cbMin.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "hr";
            // 
            // cbHr
            // 
            this.cbHr.BackColor = System.Drawing.Color.Blue;
            this.cbHr.FormattingEnabled = true;
            this.cbHr.Location = new System.Drawing.Point(71, 37);
            this.cbHr.Name = "cbHr";
            this.cbHr.Size = new System.Drawing.Size(46, 21);
            this.cbHr.TabIndex = 0;
            // 
            // pnFront
            // 
            this.pnFront.BackColor = System.Drawing.Color.Transparent;
            this.pnFront.Controls.Add(this.btnStop);
            this.pnFront.Controls.Add(this.btnPlay);
            this.pnFront.Controls.Add(this.btnSetting);
            this.pnFront.Controls.Add(this.lblTimer);
            this.pnFront.Controls.Add(this.label5);
            this.pnFront.Controls.Add(this.label6);
            this.pnFront.Controls.Add(this.label7);
            this.pnFront.Controls.Add(this.comboBox1);
            this.pnFront.Controls.Add(this.label1);
            this.pnFront.Controls.Add(this.comboBox2);
            this.pnFront.Controls.Add(this.comboBox3);
            this.pnFront.Location = new System.Drawing.Point(0, 22);
            this.pnFront.Name = "pnFront";
            this.pnFront.Size = new System.Drawing.Size(359, 126);
            this.pnFront.TabIndex = 13;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStop.BackgroundImage")));
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Image = global::Timer.Properties.Resources.Stop;
            this.btnStop.Location = new System.Drawing.Point(166, 81);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(33, 37);
            this.btnStop.TabIndex = 14;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.BackgroundImage")));
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Image = global::Timer.Properties.Resources.Play;
            this.btnPlay.Location = new System.Drawing.Point(131, 81);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(33, 37);
            this.btnPlay.TabIndex = 13;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSetting.BackgroundImage")));
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Image = global::Timer.Properties.Resources.Wrench;
            this.btnSetting.Location = new System.Drawing.Point(201, 81);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(33, 37);
            this.btnSetting.TabIndex = 12;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetTimer_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Lime;
            this.lblTimer.Location = new System.Drawing.Point(49, 3);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(266, 73);
            this.lblTimer.TabIndex = 11;
            this.lblTimer.Text = "00:00:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "ss";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(121, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "hr";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(226, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(46, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "00:00:00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(145, 37);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(46, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(71, 37);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(46, 21);
            this.comboBox3.TabIndex = 0;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Timer.Properties.Resources.blue_black_gradient;
            this.ClientSize = new System.Drawing.Size(362, 170);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnExitApp);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.pnFront);
            this.Controls.Add(this.pnSetting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnSetting.ResumeLayout(false);
            this.pnSetting.PerformLayout();
            this.pnFront.ResumeLayout(false);
            this.pnFront.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnSetting;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExitApp;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSS;
        private System.Windows.Forms.ComboBox cbMin;
        private System.Windows.Forms.ComboBox cbHr;
        private System.Windows.Forms.Panel pnFront;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}

