namespace serverManagerClient
{
    partial class clientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clientForm));
            this.usernameField = new System.Windows.Forms.TextBox();
            this.usernameTxt = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.Label();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logBox = new System.Windows.Forms.TextBox();
            this.zone3StatusTxt = new System.Windows.Forms.Label();
            this.zone1StatusTxt = new System.Windows.Forms.Label();
            this.zone0StatusTxt = new System.Windows.Forms.Label();
            this.zone3Txt = new System.Windows.Forms.Label();
            this.zone2Txt = new System.Windows.Forms.Label();
            this.zoneTxt = new System.Windows.Forms.Label();
            this.worldManagerStatusTxt = new System.Windows.Forms.Label();
            this.worldManagerTxt = new System.Windows.Forms.Label();
            this.loginStatusTxt = new System.Windows.Forms.Label();
            this.loginTxt = new System.Windows.Forms.Label();
            this.gamelogStatusTxt = new System.Windows.Forms.Label();
            this.gamelogTxt = new System.Windows.Forms.Label();
            this.characterStatusTxt = new System.Windows.Forms.Label();
            this.characterTxt = new System.Windows.Forms.Label();
            this.accountLogStatusTxt = new System.Windows.Forms.Label();
            this.accountLogTxt = new System.Windows.Forms.Label();
            this.accountStatusTxt = new System.Windows.Forms.Label();
            this.accountTxt = new System.Windows.Forms.Label();
            this.zone2StatusTxt = new System.Windows.Forms.Label();
            this.zone1Txt = new System.Windows.Forms.Label();
            this.infoTxt = new System.Windows.Forms.Label();
            this.stopBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.serviceList = new System.Windows.Forms.ComboBox();
            this.stopAllBtn = new System.Windows.Forms.Button();
            this.restartAllBtn = new System.Windows.Forms.Button();
            this.startAllBtn = new System.Windows.Forms.Button();
            this.creditsTxt = new System.Windows.Forms.Label();
            this.zone4StatusTxt = new System.Windows.Forms.Label();
            this.zone4Txt = new System.Windows.Forms.Label();
            this.licenseTxt = new System.Windows.Forms.Label();
            this.tempRefreshBtn = new System.Windows.Forms.Button();
            this.refreshStatus = new System.Windows.Forms.Button();
            this.charEditBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameField
            // 
            this.usernameField.Location = new System.Drawing.Point(3, 116);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(100, 20);
            this.usernameField.TabIndex = 0;
            // 
            // usernameTxt
            // 
            this.usernameTxt.AutoSize = true;
            this.usernameTxt.Location = new System.Drawing.Point(3, 100);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(58, 13);
            this.usernameTxt.TabIndex = 1;
            this.usernameTxt.Text = "Username:";
            // 
            // passwordTxt
            // 
            this.passwordTxt.AutoSize = true;
            this.passwordTxt.Location = new System.Drawing.Point(106, 100);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(56, 13);
            this.passwordTxt.TabIndex = 3;
            this.passwordTxt.Text = "Password:";
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(109, 116);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(100, 20);
            this.passwordField.TabIndex = 2;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(3, 135);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.logBox);
            this.panel1.Controls.Add(this.loginBtn);
            this.panel1.Controls.Add(this.usernameTxt);
            this.panel1.Controls.Add(this.passwordTxt);
            this.panel1.Controls.Add(this.usernameField);
            this.panel1.Controls.Add(this.passwordField);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 161);
            this.panel1.TabIndex = 5;
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(6, 4);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logBox.Size = new System.Drawing.Size(333, 93);
            this.logBox.TabIndex = 5;
            // 
            // zone3StatusTxt
            // 
            this.zone3StatusTxt.AutoSize = true;
            this.zone3StatusTxt.BackColor = System.Drawing.Color.Transparent;
            this.zone3StatusTxt.Location = new System.Drawing.Point(296, 298);
            this.zone3StatusTxt.Name = "zone3StatusTxt";
            this.zone3StatusTxt.Size = new System.Drawing.Size(46, 13);
            this.zone3StatusTxt.TabIndex = 41;
            this.zone3StatusTxt.Text = "ERROR";
            // 
            // zone1StatusTxt
            // 
            this.zone1StatusTxt.AutoSize = true;
            this.zone1StatusTxt.BackColor = System.Drawing.Color.Transparent;
            this.zone1StatusTxt.Location = new System.Drawing.Point(296, 272);
            this.zone1StatusTxt.Name = "zone1StatusTxt";
            this.zone1StatusTxt.Size = new System.Drawing.Size(46, 13);
            this.zone1StatusTxt.TabIndex = 40;
            this.zone1StatusTxt.Text = "ERROR";
            // 
            // zone0StatusTxt
            // 
            this.zone0StatusTxt.AutoSize = true;
            this.zone0StatusTxt.BackColor = System.Drawing.Color.Transparent;
            this.zone0StatusTxt.Location = new System.Drawing.Point(296, 259);
            this.zone0StatusTxt.Name = "zone0StatusTxt";
            this.zone0StatusTxt.Size = new System.Drawing.Size(46, 13);
            this.zone0StatusTxt.TabIndex = 39;
            this.zone0StatusTxt.Text = "ERROR";
            // 
            // zone3Txt
            // 
            this.zone3Txt.AutoSize = true;
            this.zone3Txt.BackColor = System.Drawing.Color.Transparent;
            this.zone3Txt.Location = new System.Drawing.Point(255, 298);
            this.zone3Txt.Name = "zone3Txt";
            this.zone3Txt.Size = new System.Drawing.Size(44, 13);
            this.zone3Txt.TabIndex = 38;
            this.zone3Txt.Text = "Zone 3:";
            // 
            // zone2Txt
            // 
            this.zone2Txt.AutoSize = true;
            this.zone2Txt.BackColor = System.Drawing.Color.Transparent;
            this.zone2Txt.Location = new System.Drawing.Point(255, 285);
            this.zone2Txt.Name = "zone2Txt";
            this.zone2Txt.Size = new System.Drawing.Size(44, 13);
            this.zone2Txt.TabIndex = 37;
            this.zone2Txt.Text = "Zone 2:";
            // 
            // zoneTxt
            // 
            this.zoneTxt.AutoSize = true;
            this.zoneTxt.BackColor = System.Drawing.Color.Transparent;
            this.zoneTxt.Location = new System.Drawing.Point(255, 259);
            this.zoneTxt.Name = "zoneTxt";
            this.zoneTxt.Size = new System.Drawing.Size(44, 13);
            this.zoneTxt.TabIndex = 36;
            this.zoneTxt.Text = "Zone 0:";
            // 
            // worldManagerStatusTxt
            // 
            this.worldManagerStatusTxt.AutoSize = true;
            this.worldManagerStatusTxt.BackColor = System.Drawing.Color.Transparent;
            this.worldManagerStatusTxt.Location = new System.Drawing.Point(296, 246);
            this.worldManagerStatusTxt.Name = "worldManagerStatusTxt";
            this.worldManagerStatusTxt.Size = new System.Drawing.Size(46, 13);
            this.worldManagerStatusTxt.TabIndex = 35;
            this.worldManagerStatusTxt.Text = "ERROR";
            // 
            // worldManagerTxt
            // 
            this.worldManagerTxt.AutoSize = true;
            this.worldManagerTxt.BackColor = System.Drawing.Color.Transparent;
            this.worldManagerTxt.Location = new System.Drawing.Point(216, 246);
            this.worldManagerTxt.Name = "worldManagerTxt";
            this.worldManagerTxt.Size = new System.Drawing.Size(83, 13);
            this.worldManagerTxt.TabIndex = 34;
            this.worldManagerTxt.Text = "World Manager:";
            // 
            // loginStatusTxt
            // 
            this.loginStatusTxt.AutoSize = true;
            this.loginStatusTxt.BackColor = System.Drawing.Color.Transparent;
            this.loginStatusTxt.Location = new System.Drawing.Point(296, 233);
            this.loginStatusTxt.Name = "loginStatusTxt";
            this.loginStatusTxt.Size = new System.Drawing.Size(46, 13);
            this.loginStatusTxt.TabIndex = 33;
            this.loginStatusTxt.Text = "ERROR";
            // 
            // loginTxt
            // 
            this.loginTxt.AutoSize = true;
            this.loginTxt.BackColor = System.Drawing.Color.Transparent;
            this.loginTxt.Location = new System.Drawing.Point(263, 233);
            this.loginTxt.Name = "loginTxt";
            this.loginTxt.Size = new System.Drawing.Size(36, 13);
            this.loginTxt.TabIndex = 32;
            this.loginTxt.Text = "Login:";
            // 
            // gamelogStatusTxt
            // 
            this.gamelogStatusTxt.AutoSize = true;
            this.gamelogStatusTxt.BackColor = System.Drawing.Color.Transparent;
            this.gamelogStatusTxt.Location = new System.Drawing.Point(296, 220);
            this.gamelogStatusTxt.Name = "gamelogStatusTxt";
            this.gamelogStatusTxt.Size = new System.Drawing.Size(46, 13);
            this.gamelogStatusTxt.TabIndex = 31;
            this.gamelogStatusTxt.Text = "ERROR";
            // 
            // gamelogTxt
            // 
            this.gamelogTxt.AutoSize = true;
            this.gamelogTxt.BackColor = System.Drawing.Color.Transparent;
            this.gamelogTxt.Location = new System.Drawing.Point(243, 220);
            this.gamelogTxt.Name = "gamelogTxt";
            this.gamelogTxt.Size = new System.Drawing.Size(56, 13);
            this.gamelogTxt.TabIndex = 30;
            this.gamelogTxt.Text = "GameLog:";
            // 
            // characterStatusTxt
            // 
            this.characterStatusTxt.AutoSize = true;
            this.characterStatusTxt.BackColor = System.Drawing.Color.Transparent;
            this.characterStatusTxt.Location = new System.Drawing.Point(296, 207);
            this.characterStatusTxt.Name = "characterStatusTxt";
            this.characterStatusTxt.Size = new System.Drawing.Size(46, 13);
            this.characterStatusTxt.TabIndex = 29;
            this.characterStatusTxt.Text = "ERROR";
            // 
            // characterTxt
            // 
            this.characterTxt.AutoSize = true;
            this.characterTxt.BackColor = System.Drawing.Color.Transparent;
            this.characterTxt.Location = new System.Drawing.Point(243, 207);
            this.characterTxt.Name = "characterTxt";
            this.characterTxt.Size = new System.Drawing.Size(56, 13);
            this.characterTxt.TabIndex = 28;
            this.characterTxt.Text = "Character:";
            // 
            // accountLogStatusTxt
            // 
            this.accountLogStatusTxt.AutoSize = true;
            this.accountLogStatusTxt.BackColor = System.Drawing.Color.Transparent;
            this.accountLogStatusTxt.Location = new System.Drawing.Point(296, 194);
            this.accountLogStatusTxt.Name = "accountLogStatusTxt";
            this.accountLogStatusTxt.Size = new System.Drawing.Size(46, 13);
            this.accountLogStatusTxt.TabIndex = 27;
            this.accountLogStatusTxt.Text = "ERROR";
            // 
            // accountLogTxt
            // 
            this.accountLogTxt.AutoSize = true;
            this.accountLogTxt.BackColor = System.Drawing.Color.Transparent;
            this.accountLogTxt.Location = new System.Drawing.Point(228, 194);
            this.accountLogTxt.Name = "accountLogTxt";
            this.accountLogTxt.Size = new System.Drawing.Size(71, 13);
            this.accountLogTxt.TabIndex = 26;
            this.accountLogTxt.Text = "Account Log:";
            // 
            // accountStatusTxt
            // 
            this.accountStatusTxt.AutoSize = true;
            this.accountStatusTxt.BackColor = System.Drawing.Color.Transparent;
            this.accountStatusTxt.Location = new System.Drawing.Point(296, 181);
            this.accountStatusTxt.Name = "accountStatusTxt";
            this.accountStatusTxt.Size = new System.Drawing.Size(46, 13);
            this.accountStatusTxt.TabIndex = 25;
            this.accountStatusTxt.Text = "ERROR";
            // 
            // accountTxt
            // 
            this.accountTxt.AutoSize = true;
            this.accountTxt.BackColor = System.Drawing.Color.Transparent;
            this.accountTxt.Location = new System.Drawing.Point(249, 181);
            this.accountTxt.Name = "accountTxt";
            this.accountTxt.Size = new System.Drawing.Size(50, 13);
            this.accountTxt.TabIndex = 24;
            this.accountTxt.Text = "Account:";
            // 
            // zone2StatusTxt
            // 
            this.zone2StatusTxt.AutoSize = true;
            this.zone2StatusTxt.BackColor = System.Drawing.Color.Transparent;
            this.zone2StatusTxt.Location = new System.Drawing.Point(296, 285);
            this.zone2StatusTxt.Name = "zone2StatusTxt";
            this.zone2StatusTxt.Size = new System.Drawing.Size(46, 13);
            this.zone2StatusTxt.TabIndex = 43;
            this.zone2StatusTxt.Text = "ERROR";
            // 
            // zone1Txt
            // 
            this.zone1Txt.AutoSize = true;
            this.zone1Txt.BackColor = System.Drawing.Color.Transparent;
            this.zone1Txt.Location = new System.Drawing.Point(255, 272);
            this.zone1Txt.Name = "zone1Txt";
            this.zone1Txt.Size = new System.Drawing.Size(44, 13);
            this.zone1Txt.TabIndex = 42;
            this.zone1Txt.Text = "Zone 1:";
            // 
            // infoTxt
            // 
            this.infoTxt.AutoSize = true;
            this.infoTxt.ForeColor = System.Drawing.Color.DarkRed;
            this.infoTxt.Location = new System.Drawing.Point(15, 339);
            this.infoTxt.Name = "infoTxt";
            this.infoTxt.Size = new System.Drawing.Size(10, 13);
            this.infoTxt.TabIndex = 44;
            this.infoTxt.Text = ".";
            // 
            // stopBtn
            // 
            this.stopBtn.Enabled = false;
            this.stopBtn.Location = new System.Drawing.Point(12, 301);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 23);
            this.stopBtn.TabIndex = 50;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Enabled = false;
            this.startBtn.Location = new System.Drawing.Point(12, 278);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 49;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // serviceList
            // 
            this.serviceList.FormattingEnabled = true;
            this.serviceList.Items.AddRange(new object[] {
            "Account",
            "AccountLog",
            "Character",
            "GameLog",
            "Login",
            "WorldManager",
            "Zone0",
            "Zone1",
            "Zone2",
            "Zone3"});
            this.serviceList.Location = new System.Drawing.Point(12, 255);
            this.serviceList.Name = "serviceList";
            this.serviceList.Size = new System.Drawing.Size(96, 21);
            this.serviceList.TabIndex = 48;
            // 
            // stopAllBtn
            // 
            this.stopAllBtn.Enabled = false;
            this.stopAllBtn.Location = new System.Drawing.Point(12, 205);
            this.stopAllBtn.Name = "stopAllBtn";
            this.stopAllBtn.Size = new System.Drawing.Size(75, 23);
            this.stopAllBtn.TabIndex = 46;
            this.stopAllBtn.Text = "Stop All";
            this.stopAllBtn.UseVisualStyleBackColor = true;
            this.stopAllBtn.Click += new System.EventHandler(this.stopAllBtn_Click);
            // 
            // restartAllBtn
            // 
            this.restartAllBtn.Enabled = false;
            this.restartAllBtn.Location = new System.Drawing.Point(12, 226);
            this.restartAllBtn.Name = "restartAllBtn";
            this.restartAllBtn.Size = new System.Drawing.Size(75, 23);
            this.restartAllBtn.TabIndex = 47;
            this.restartAllBtn.Text = "Restart All";
            this.restartAllBtn.UseVisualStyleBackColor = true;
            this.restartAllBtn.Click += new System.EventHandler(this.restartAllBtn_Click);
            // 
            // startAllBtn
            // 
            this.startAllBtn.Enabled = false;
            this.startAllBtn.Location = new System.Drawing.Point(12, 184);
            this.startAllBtn.Name = "startAllBtn";
            this.startAllBtn.Size = new System.Drawing.Size(75, 23);
            this.startAllBtn.TabIndex = 45;
            this.startAllBtn.Text = "Start All";
            this.startAllBtn.UseVisualStyleBackColor = true;
            this.startAllBtn.Click += new System.EventHandler(this.startAllBtn_Click);
            // 
            // creditsTxt
            // 
            this.creditsTxt.AutoSize = true;
            this.creditsTxt.Location = new System.Drawing.Point(9, 381);
            this.creditsTxt.Name = "creditsTxt";
            this.creditsTxt.Size = new System.Drawing.Size(178, 13);
            this.creditsTxt.TabIndex = 51;
            this.creditsTxt.Text = "Author: Harry / Discord: Harry#8354";
            // 
            // zone4StatusTxt
            // 
            this.zone4StatusTxt.AutoSize = true;
            this.zone4StatusTxt.BackColor = System.Drawing.Color.Transparent;
            this.zone4StatusTxt.Location = new System.Drawing.Point(296, 311);
            this.zone4StatusTxt.Name = "zone4StatusTxt";
            this.zone4StatusTxt.Size = new System.Drawing.Size(46, 13);
            this.zone4StatusTxt.TabIndex = 53;
            this.zone4StatusTxt.Text = "ERROR";
            // 
            // zone4Txt
            // 
            this.zone4Txt.AutoSize = true;
            this.zone4Txt.BackColor = System.Drawing.Color.Transparent;
            this.zone4Txt.Location = new System.Drawing.Point(255, 311);
            this.zone4Txt.Name = "zone4Txt";
            this.zone4Txt.Size = new System.Drawing.Size(44, 13);
            this.zone4Txt.TabIndex = 52;
            this.zone4Txt.Text = "Zone 4:";
            // 
            // licenseTxt
            // 
            this.licenseTxt.AutoSize = true;
            this.licenseTxt.Location = new System.Drawing.Point(289, 381);
            this.licenseTxt.Name = "licenseTxt";
            this.licenseTxt.Size = new System.Drawing.Size(10, 13);
            this.licenseTxt.TabIndex = 54;
            this.licenseTxt.Text = ".";
            // 
            // tempRefreshBtn
            // 
            this.tempRefreshBtn.Enabled = false;
            this.tempRefreshBtn.Location = new System.Drawing.Point(121, 329);
            this.tempRefreshBtn.Name = "tempRefreshBtn";
            this.tempRefreshBtn.Size = new System.Drawing.Size(75, 23);
            this.tempRefreshBtn.TabIndex = 55;
            this.tempRefreshBtn.Text = "Refresh All";
            this.tempRefreshBtn.UseVisualStyleBackColor = true;
            this.tempRefreshBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // refreshStatus
            // 
            this.refreshStatus.Enabled = false;
            this.refreshStatus.Location = new System.Drawing.Point(121, 355);
            this.refreshStatus.Name = "refreshStatus";
            this.refreshStatus.Size = new System.Drawing.Size(75, 23);
            this.refreshStatus.TabIndex = 56;
            this.refreshStatus.Text = "Refresh";
            this.refreshStatus.UseVisualStyleBackColor = true;
            this.refreshStatus.Click += new System.EventHandler(this.refreshStatus_Click);
            // 
            // charEditBtn
            // 
            this.charEditBtn.Enabled = false;
            this.charEditBtn.Location = new System.Drawing.Point(263, 341);
            this.charEditBtn.Name = "charEditBtn";
            this.charEditBtn.Size = new System.Drawing.Size(79, 36);
            this.charEditBtn.TabIndex = 57;
            this.charEditBtn.Text = "Character Editor";
            this.charEditBtn.UseVisualStyleBackColor = true;
            this.charEditBtn.Click += new System.EventHandler(this.charEditBtn_Click);
            // 
            // clientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 394);
            this.Controls.Add(this.charEditBtn);
            this.Controls.Add(this.refreshStatus);
            this.Controls.Add(this.tempRefreshBtn);
            this.Controls.Add(this.licenseTxt);
            this.Controls.Add(this.zone4StatusTxt);
            this.Controls.Add(this.zone4Txt);
            this.Controls.Add(this.creditsTxt);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.serviceList);
            this.Controls.Add(this.stopAllBtn);
            this.Controls.Add(this.restartAllBtn);
            this.Controls.Add(this.startAllBtn);
            this.Controls.Add(this.infoTxt);
            this.Controls.Add(this.zone2StatusTxt);
            this.Controls.Add(this.zone1Txt);
            this.Controls.Add(this.zone3StatusTxt);
            this.Controls.Add(this.zone1StatusTxt);
            this.Controls.Add(this.zone0StatusTxt);
            this.Controls.Add(this.zone3Txt);
            this.Controls.Add(this.zone2Txt);
            this.Controls.Add(this.zoneTxt);
            this.Controls.Add(this.worldManagerStatusTxt);
            this.Controls.Add(this.worldManagerTxt);
            this.Controls.Add(this.loginStatusTxt);
            this.Controls.Add(this.loginTxt);
            this.Controls.Add(this.gamelogStatusTxt);
            this.Controls.Add(this.gamelogTxt);
            this.Controls.Add(this.characterStatusTxt);
            this.Controls.Add(this.characterTxt);
            this.Controls.Add(this.accountLogStatusTxt);
            this.Controls.Add(this.accountLogTxt);
            this.Controls.Add(this.accountStatusTxt);
            this.Controls.Add(this.accountTxt);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "clientForm";
            this.Text = "Service Manager (Client)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.Label usernameTxt;
        private System.Windows.Forms.Label passwordTxt;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label zone3StatusTxt;
        private System.Windows.Forms.Label zone1StatusTxt;
        private System.Windows.Forms.Label zone0StatusTxt;
        private System.Windows.Forms.Label zone3Txt;
        private System.Windows.Forms.Label zone2Txt;
        private System.Windows.Forms.Label zoneTxt;
        private System.Windows.Forms.Label worldManagerStatusTxt;
        private System.Windows.Forms.Label worldManagerTxt;
        private System.Windows.Forms.Label loginStatusTxt;
        private System.Windows.Forms.Label loginTxt;
        private System.Windows.Forms.Label gamelogStatusTxt;
        private System.Windows.Forms.Label gamelogTxt;
        private System.Windows.Forms.Label characterStatusTxt;
        private System.Windows.Forms.Label characterTxt;
        private System.Windows.Forms.Label accountLogStatusTxt;
        private System.Windows.Forms.Label accountLogTxt;
        private System.Windows.Forms.Label accountStatusTxt;
        private System.Windows.Forms.Label accountTxt;
        private System.Windows.Forms.Label zone2StatusTxt;
        private System.Windows.Forms.Label zone1Txt;
        private System.Windows.Forms.Label infoTxt;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.ComboBox serviceList;
        private System.Windows.Forms.Button stopAllBtn;
        private System.Windows.Forms.Button restartAllBtn;
        private System.Windows.Forms.Button startAllBtn;
        private System.Windows.Forms.Label creditsTxt;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.Label zone4StatusTxt;
        private System.Windows.Forms.Label zone4Txt;
        private System.Windows.Forms.Label licenseTxt;
        private System.Windows.Forms.Button tempRefreshBtn;
        private System.Windows.Forms.Button refreshStatus;
        private System.Windows.Forms.Button charEditBtn;
    }
}

