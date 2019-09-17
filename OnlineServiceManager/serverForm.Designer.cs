namespace OnlineServiceManager
{
    partial class serverForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(serverForm));
            this.logBox = new System.Windows.Forms.TextBox();
            this.statusTxt = new System.Windows.Forms.Label();
            this.restartToggleBtn = new System.Windows.Forms.Button();
            this.usersEditBtn = new System.Windows.Forms.Button();
            this.accountTxt = new System.Windows.Forms.Label();
            this.accountStatusTxt = new System.Windows.Forms.Label();
            this.accountLogStatusTxt = new System.Windows.Forms.Label();
            this.accountLogTxt = new System.Windows.Forms.Label();
            this.characterTxt = new System.Windows.Forms.Label();
            this.characterStatusTxt = new System.Windows.Forms.Label();
            this.gamelogTxt = new System.Windows.Forms.Label();
            this.gamelogStatusTxt = new System.Windows.Forms.Label();
            this.loginTxt = new System.Windows.Forms.Label();
            this.loginStatusTxt = new System.Windows.Forms.Label();
            this.worldManagerTxt = new System.Windows.Forms.Label();
            this.worldManagerStatusTxt = new System.Windows.Forms.Label();
            this.zoneTxt = new System.Windows.Forms.Label();
            this.zone1Txt = new System.Windows.Forms.Label();
            this.zone2Txt = new System.Windows.Forms.Label();
            this.zone3Txt = new System.Windows.Forms.Label();
            this.zone0StatusTxt = new System.Windows.Forms.Label();
            this.zone1StatusTxt = new System.Windows.Forms.Label();
            this.zone2StatusTxt = new System.Windows.Forms.Label();
            this.zone3StatusTxt = new System.Windows.Forms.Label();
            this.startAllBtn = new System.Windows.Forms.Button();
            this.stopAllBtn = new System.Windows.Forms.Button();
            this.restartAllBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.zone4StatusTxt = new System.Windows.Forms.Label();
            this.zone4Txt = new System.Windows.Forms.Label();
            this.stopBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.serviceList = new System.Windows.Forms.ComboBox();
            this.userEditPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userHeaderTxt = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.deleteUserBtn = new System.Windows.Forms.Button();
            this.addUserBtn = new System.Windows.Forms.Button();
            this.closeUserPanelBtn = new System.Windows.Forms.Button();
            this.infoTxt = new System.Windows.Forms.Label();
            this.creditsTxt = new System.Windows.Forms.Label();
            this.serviceStatusCheck = new System.Windows.Forms.Timer(this.components);
            this.licenseTxt = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.userEditPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(12, 12);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logBox.Size = new System.Drawing.Size(425, 259);
            this.logBox.TabIndex = 0;
            // 
            // statusTxt
            // 
            this.statusTxt.AutoSize = true;
            this.statusTxt.Location = new System.Drawing.Point(456, 15);
            this.statusTxt.Name = "statusTxt";
            this.statusTxt.Size = new System.Drawing.Size(121, 13);
            this.statusTxt.TabIndex = 1;
            this.statusTxt.Text = "Accepting Restarts: Yes";
            // 
            // restartToggleBtn
            // 
            this.restartToggleBtn.Location = new System.Drawing.Point(459, 31);
            this.restartToggleBtn.Name = "restartToggleBtn";
            this.restartToggleBtn.Size = new System.Drawing.Size(118, 23);
            this.restartToggleBtn.TabIndex = 2;
            this.restartToggleBtn.Text = "Toggle";
            this.restartToggleBtn.UseVisualStyleBackColor = true;
            this.restartToggleBtn.Click += new System.EventHandler(this.restartToggleBtn_Click);
            // 
            // usersEditBtn
            // 
            this.usersEditBtn.Location = new System.Drawing.Point(587, 31);
            this.usersEditBtn.Name = "usersEditBtn";
            this.usersEditBtn.Size = new System.Drawing.Size(118, 23);
            this.usersEditBtn.TabIndex = 3;
            this.usersEditBtn.Text = "Edit Users List";
            this.usersEditBtn.UseVisualStyleBackColor = true;
            this.usersEditBtn.Click += new System.EventHandler(this.usersEditBtn_Click);
            // 
            // accountTxt
            // 
            this.accountTxt.AutoSize = true;
            this.accountTxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.accountTxt.Location = new System.Drawing.Point(484, 125);
            this.accountTxt.Name = "accountTxt";
            this.accountTxt.Size = new System.Drawing.Size(50, 13);
            this.accountTxt.TabIndex = 4;
            this.accountTxt.Text = "Account:";
            // 
            // accountStatusTxt
            // 
            this.accountStatusTxt.AutoSize = true;
            this.accountStatusTxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.accountStatusTxt.Location = new System.Drawing.Point(531, 125);
            this.accountStatusTxt.Name = "accountStatusTxt";
            this.accountStatusTxt.Size = new System.Drawing.Size(46, 13);
            this.accountStatusTxt.TabIndex = 5;
            this.accountStatusTxt.Text = "ERROR";
            // 
            // accountLogStatusTxt
            // 
            this.accountLogStatusTxt.AutoSize = true;
            this.accountLogStatusTxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.accountLogStatusTxt.Location = new System.Drawing.Point(531, 138);
            this.accountLogStatusTxt.Name = "accountLogStatusTxt";
            this.accountLogStatusTxt.Size = new System.Drawing.Size(46, 13);
            this.accountLogStatusTxt.TabIndex = 7;
            this.accountLogStatusTxt.Text = "ERROR";
            // 
            // accountLogTxt
            // 
            this.accountLogTxt.AutoSize = true;
            this.accountLogTxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.accountLogTxt.Location = new System.Drawing.Point(463, 138);
            this.accountLogTxt.Name = "accountLogTxt";
            this.accountLogTxt.Size = new System.Drawing.Size(71, 13);
            this.accountLogTxt.TabIndex = 6;
            this.accountLogTxt.Text = "Account Log:";
            // 
            // characterTxt
            // 
            this.characterTxt.AutoSize = true;
            this.characterTxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.characterTxt.Location = new System.Drawing.Point(478, 151);
            this.characterTxt.Name = "characterTxt";
            this.characterTxt.Size = new System.Drawing.Size(56, 13);
            this.characterTxt.TabIndex = 8;
            this.characterTxt.Text = "Character:";
            // 
            // characterStatusTxt
            // 
            this.characterStatusTxt.AutoSize = true;
            this.characterStatusTxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.characterStatusTxt.Location = new System.Drawing.Point(531, 151);
            this.characterStatusTxt.Name = "characterStatusTxt";
            this.characterStatusTxt.Size = new System.Drawing.Size(46, 13);
            this.characterStatusTxt.TabIndex = 9;
            this.characterStatusTxt.Text = "ERROR";
            // 
            // gamelogTxt
            // 
            this.gamelogTxt.AutoSize = true;
            this.gamelogTxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gamelogTxt.Location = new System.Drawing.Point(478, 164);
            this.gamelogTxt.Name = "gamelogTxt";
            this.gamelogTxt.Size = new System.Drawing.Size(56, 13);
            this.gamelogTxt.TabIndex = 10;
            this.gamelogTxt.Text = "GameLog:";
            // 
            // gamelogStatusTxt
            // 
            this.gamelogStatusTxt.AutoSize = true;
            this.gamelogStatusTxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gamelogStatusTxt.Location = new System.Drawing.Point(531, 164);
            this.gamelogStatusTxt.Name = "gamelogStatusTxt";
            this.gamelogStatusTxt.Size = new System.Drawing.Size(46, 13);
            this.gamelogStatusTxt.TabIndex = 11;
            this.gamelogStatusTxt.Text = "ERROR";
            // 
            // loginTxt
            // 
            this.loginTxt.AutoSize = true;
            this.loginTxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.loginTxt.Location = new System.Drawing.Point(498, 177);
            this.loginTxt.Name = "loginTxt";
            this.loginTxt.Size = new System.Drawing.Size(36, 13);
            this.loginTxt.TabIndex = 12;
            this.loginTxt.Text = "Login:";
            // 
            // loginStatusTxt
            // 
            this.loginStatusTxt.AutoSize = true;
            this.loginStatusTxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.loginStatusTxt.Location = new System.Drawing.Point(531, 177);
            this.loginStatusTxt.Name = "loginStatusTxt";
            this.loginStatusTxt.Size = new System.Drawing.Size(46, 13);
            this.loginStatusTxt.TabIndex = 13;
            this.loginStatusTxt.Text = "ERROR";
            // 
            // worldManagerTxt
            // 
            this.worldManagerTxt.AutoSize = true;
            this.worldManagerTxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.worldManagerTxt.Location = new System.Drawing.Point(451, 190);
            this.worldManagerTxt.Name = "worldManagerTxt";
            this.worldManagerTxt.Size = new System.Drawing.Size(83, 13);
            this.worldManagerTxt.TabIndex = 14;
            this.worldManagerTxt.Text = "World Manager:";
            // 
            // worldManagerStatusTxt
            // 
            this.worldManagerStatusTxt.AutoSize = true;
            this.worldManagerStatusTxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.worldManagerStatusTxt.Location = new System.Drawing.Point(531, 190);
            this.worldManagerStatusTxt.Name = "worldManagerStatusTxt";
            this.worldManagerStatusTxt.Size = new System.Drawing.Size(46, 13);
            this.worldManagerStatusTxt.TabIndex = 15;
            this.worldManagerStatusTxt.Text = "ERROR";
            // 
            // zoneTxt
            // 
            this.zoneTxt.AutoSize = true;
            this.zoneTxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.zoneTxt.Location = new System.Drawing.Point(490, 203);
            this.zoneTxt.Name = "zoneTxt";
            this.zoneTxt.Size = new System.Drawing.Size(44, 13);
            this.zoneTxt.TabIndex = 16;
            this.zoneTxt.Text = "Zone 0:";
            // 
            // zone1Txt
            // 
            this.zone1Txt.AutoSize = true;
            this.zone1Txt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.zone1Txt.Location = new System.Drawing.Point(490, 216);
            this.zone1Txt.Name = "zone1Txt";
            this.zone1Txt.Size = new System.Drawing.Size(44, 13);
            this.zone1Txt.TabIndex = 17;
            this.zone1Txt.Text = "Zone 1:";
            // 
            // zone2Txt
            // 
            this.zone2Txt.AutoSize = true;
            this.zone2Txt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.zone2Txt.Location = new System.Drawing.Point(490, 229);
            this.zone2Txt.Name = "zone2Txt";
            this.zone2Txt.Size = new System.Drawing.Size(44, 13);
            this.zone2Txt.TabIndex = 18;
            this.zone2Txt.Text = "Zone 2:";
            // 
            // zone3Txt
            // 
            this.zone3Txt.AutoSize = true;
            this.zone3Txt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.zone3Txt.Location = new System.Drawing.Point(490, 242);
            this.zone3Txt.Name = "zone3Txt";
            this.zone3Txt.Size = new System.Drawing.Size(44, 13);
            this.zone3Txt.TabIndex = 19;
            this.zone3Txt.Text = "Zone 3:";
            // 
            // zone0StatusTxt
            // 
            this.zone0StatusTxt.AutoSize = true;
            this.zone0StatusTxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.zone0StatusTxt.Location = new System.Drawing.Point(531, 203);
            this.zone0StatusTxt.Name = "zone0StatusTxt";
            this.zone0StatusTxt.Size = new System.Drawing.Size(46, 13);
            this.zone0StatusTxt.TabIndex = 20;
            this.zone0StatusTxt.Text = "ERROR";
            // 
            // zone1StatusTxt
            // 
            this.zone1StatusTxt.AutoSize = true;
            this.zone1StatusTxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.zone1StatusTxt.Location = new System.Drawing.Point(531, 216);
            this.zone1StatusTxt.Name = "zone1StatusTxt";
            this.zone1StatusTxt.Size = new System.Drawing.Size(46, 13);
            this.zone1StatusTxt.TabIndex = 21;
            this.zone1StatusTxt.Text = "ERROR";
            // 
            // zone2StatusTxt
            // 
            this.zone2StatusTxt.AutoSize = true;
            this.zone2StatusTxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.zone2StatusTxt.Location = new System.Drawing.Point(531, 229);
            this.zone2StatusTxt.Name = "zone2StatusTxt";
            this.zone2StatusTxt.Size = new System.Drawing.Size(46, 13);
            this.zone2StatusTxt.TabIndex = 22;
            this.zone2StatusTxt.Text = "ERROR";
            // 
            // zone3StatusTxt
            // 
            this.zone3StatusTxt.AutoSize = true;
            this.zone3StatusTxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.zone3StatusTxt.Location = new System.Drawing.Point(531, 242);
            this.zone3StatusTxt.Name = "zone3StatusTxt";
            this.zone3StatusTxt.Size = new System.Drawing.Size(46, 13);
            this.zone3StatusTxt.TabIndex = 23;
            this.zone3StatusTxt.Text = "ERROR";
            // 
            // startAllBtn
            // 
            this.startAllBtn.Location = new System.Drawing.Point(155, 13);
            this.startAllBtn.Name = "startAllBtn";
            this.startAllBtn.Size = new System.Drawing.Size(75, 23);
            this.startAllBtn.TabIndex = 24;
            this.startAllBtn.Text = "Start All";
            this.startAllBtn.UseVisualStyleBackColor = true;
            this.startAllBtn.Click += new System.EventHandler(this.startAllBtn_Click);
            // 
            // stopAllBtn
            // 
            this.stopAllBtn.Location = new System.Drawing.Point(155, 34);
            this.stopAllBtn.Name = "stopAllBtn";
            this.stopAllBtn.Size = new System.Drawing.Size(75, 23);
            this.stopAllBtn.TabIndex = 25;
            this.stopAllBtn.Text = "Stop All";
            this.stopAllBtn.UseVisualStyleBackColor = true;
            this.stopAllBtn.Click += new System.EventHandler(this.stopAllBtn_Click);
            // 
            // restartAllBtn
            // 
            this.restartAllBtn.Location = new System.Drawing.Point(155, 55);
            this.restartAllBtn.Name = "restartAllBtn";
            this.restartAllBtn.Size = new System.Drawing.Size(75, 23);
            this.restartAllBtn.TabIndex = 26;
            this.restartAllBtn.Text = "Restart All";
            this.restartAllBtn.UseVisualStyleBackColor = true;
            this.restartAllBtn.Click += new System.EventHandler(this.restartAllBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.zone4StatusTxt);
            this.panel1.Controls.Add(this.zone4Txt);
            this.panel1.Controls.Add(this.stopBtn);
            this.panel1.Controls.Add(this.startBtn);
            this.panel1.Controls.Add(this.serviceList);
            this.panel1.Controls.Add(this.stopAllBtn);
            this.panel1.Controls.Add(this.restartAllBtn);
            this.panel1.Controls.Add(this.startAllBtn);
            this.panel1.Location = new System.Drawing.Point(446, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 160);
            this.panel1.TabIndex = 27;
            // 
            // zone4StatusTxt
            // 
            this.zone4StatusTxt.AutoSize = true;
            this.zone4StatusTxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.zone4StatusTxt.Location = new System.Drawing.Point(84, 143);
            this.zone4StatusTxt.Name = "zone4StatusTxt";
            this.zone4StatusTxt.Size = new System.Drawing.Size(46, 13);
            this.zone4StatusTxt.TabIndex = 32;
            this.zone4StatusTxt.Text = "ERROR";
            // 
            // zone4Txt
            // 
            this.zone4Txt.AutoSize = true;
            this.zone4Txt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.zone4Txt.Location = new System.Drawing.Point(43, 143);
            this.zone4Txt.Name = "zone4Txt";
            this.zone4Txt.Size = new System.Drawing.Size(44, 13);
            this.zone4Txt.TabIndex = 31;
            this.zone4Txt.Text = "Zone 4:";
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(155, 130);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 23);
            this.stopBtn.TabIndex = 29;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(155, 107);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 28;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // serviceList
            // 
            this.serviceList.FormattingEnabled = true;
            this.serviceList.Items.AddRange(new object[] {
            "ERROR LOADING SERVICES"});
            this.serviceList.Location = new System.Drawing.Point(155, 84);
            this.serviceList.Name = "serviceList";
            this.serviceList.Size = new System.Drawing.Size(96, 21);
            this.serviceList.TabIndex = 27;
            // 
            // userEditPanel
            // 
            this.userEditPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userEditPanel.Controls.Add(this.label4);
            this.userEditPanel.Controls.Add(this.textBox3);
            this.userEditPanel.Controls.Add(this.label3);
            this.userEditPanel.Controls.Add(this.textBox2);
            this.userEditPanel.Controls.Add(this.label2);
            this.userEditPanel.Controls.Add(this.label1);
            this.userEditPanel.Controls.Add(this.userHeaderTxt);
            this.userEditPanel.Controls.Add(this.textBox1);
            this.userEditPanel.Controls.Add(this.deleteUserBtn);
            this.userEditPanel.Controls.Add(this.addUserBtn);
            this.userEditPanel.Controls.Add(this.closeUserPanelBtn);
            this.userEditPanel.Location = new System.Drawing.Point(76, 7);
            this.userEditPanel.Name = "userEditPanel";
            this.userEditPanel.Size = new System.Drawing.Size(274, 264);
            this.userEditPanel.TabIndex = 28;
            this.userEditPanel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Name of user to delete";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(10, 197);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "DELETE USER:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(10, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pass:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login:";
            // 
            // userHeaderTxt
            // 
            this.userHeaderTxt.AutoSize = true;
            this.userHeaderTxt.Location = new System.Drawing.Point(7, 9);
            this.userHeaderTxt.Name = "userHeaderTxt";
            this.userHeaderTxt.Size = new System.Drawing.Size(66, 13);
            this.userHeaderTxt.TabIndex = 4;
            this.userHeaderTxt.Text = "NEW USER";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // deleteUserBtn
            // 
            this.deleteUserBtn.Location = new System.Drawing.Point(35, 229);
            this.deleteUserBtn.Name = "deleteUserBtn";
            this.deleteUserBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteUserBtn.TabIndex = 2;
            this.deleteUserBtn.Text = "Delete";
            this.deleteUserBtn.UseVisualStyleBackColor = true;
            // 
            // addUserBtn
            // 
            this.addUserBtn.Location = new System.Drawing.Point(35, 122);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(75, 23);
            this.addUserBtn.TabIndex = 1;
            this.addUserBtn.Text = "Add";
            this.addUserBtn.UseVisualStyleBackColor = true;
            // 
            // closeUserPanelBtn
            // 
            this.closeUserPanelBtn.Location = new System.Drawing.Point(185, 16);
            this.closeUserPanelBtn.Name = "closeUserPanelBtn";
            this.closeUserPanelBtn.Size = new System.Drawing.Size(75, 23);
            this.closeUserPanelBtn.TabIndex = 0;
            this.closeUserPanelBtn.Text = "Close";
            this.closeUserPanelBtn.UseVisualStyleBackColor = true;
            this.closeUserPanelBtn.Click += new System.EventHandler(this.closeUserPanelBtn_Click);
            // 
            // infoTxt
            // 
            this.infoTxt.AutoSize = true;
            this.infoTxt.Location = new System.Drawing.Point(456, 81);
            this.infoTxt.Name = "infoTxt";
            this.infoTxt.Size = new System.Drawing.Size(0, 13);
            this.infoTxt.TabIndex = 29;
            // 
            // creditsTxt
            // 
            this.creditsTxt.AutoSize = true;
            this.creditsTxt.Location = new System.Drawing.Point(529, 276);
            this.creditsTxt.Name = "creditsTxt";
            this.creditsTxt.Size = new System.Drawing.Size(178, 13);
            this.creditsTxt.TabIndex = 30;
            this.creditsTxt.Text = "Author: Harry / Discord: Harry#8354";
            // 
            // serviceStatusCheck
            // 
            this.serviceStatusCheck.Tick += new System.EventHandler(this.serviceStatusCheck_Tick);
            // 
            // licenseTxt
            // 
            this.licenseTxt.AutoSize = true;
            this.licenseTxt.ForeColor = System.Drawing.Color.Red;
            this.licenseTxt.Location = new System.Drawing.Point(12, 276);
            this.licenseTxt.Name = "licenseTxt";
            this.licenseTxt.Size = new System.Drawing.Size(210, 13);
            this.licenseTxt.TabIndex = 31;
            this.licenseTxt.Text = "Error with licensing. Restart the application.";
            // 
            // serverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 296);
            this.Controls.Add(this.licenseTxt);
            this.Controls.Add(this.creditsTxt);
            this.Controls.Add(this.infoTxt);
            this.Controls.Add(this.userEditPanel);
            this.Controls.Add(this.zone3StatusTxt);
            this.Controls.Add(this.zone2StatusTxt);
            this.Controls.Add(this.zone1StatusTxt);
            this.Controls.Add(this.zone0StatusTxt);
            this.Controls.Add(this.zone3Txt);
            this.Controls.Add(this.zone2Txt);
            this.Controls.Add(this.zone1Txt);
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
            this.Controls.Add(this.usersEditBtn);
            this.Controls.Add(this.restartToggleBtn);
            this.Controls.Add(this.statusTxt);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "serverForm";
            this.Text = "Service Manager (Server)";
            this.Load += new System.EventHandler(this.serverForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.userEditPanel.ResumeLayout(false);
            this.userEditPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.Label statusTxt;
        private System.Windows.Forms.Button restartToggleBtn;
        private System.Windows.Forms.Button usersEditBtn;
        private System.Windows.Forms.Label accountTxt;
        private System.Windows.Forms.Label accountStatusTxt;
        private System.Windows.Forms.Label accountLogStatusTxt;
        private System.Windows.Forms.Label accountLogTxt;
        private System.Windows.Forms.Label characterTxt;
        private System.Windows.Forms.Label characterStatusTxt;
        private System.Windows.Forms.Label gamelogTxt;
        private System.Windows.Forms.Label gamelogStatusTxt;
        private System.Windows.Forms.Label loginTxt;
        private System.Windows.Forms.Label loginStatusTxt;
        private System.Windows.Forms.Label worldManagerTxt;
        private System.Windows.Forms.Label worldManagerStatusTxt;
        private System.Windows.Forms.Label zoneTxt;
        private System.Windows.Forms.Label zone1Txt;
        private System.Windows.Forms.Label zone2Txt;
        private System.Windows.Forms.Label zone3Txt;
        private System.Windows.Forms.Label zone0StatusTxt;
        private System.Windows.Forms.Label zone1StatusTxt;
        private System.Windows.Forms.Label zone2StatusTxt;
        private System.Windows.Forms.Label zone3StatusTxt;
        private System.Windows.Forms.Button startAllBtn;
        private System.Windows.Forms.Button stopAllBtn;
        private System.Windows.Forms.Button restartAllBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox serviceList;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Panel userEditPanel;
        private System.Windows.Forms.Button closeUserPanelBtn;
        private System.Windows.Forms.Button deleteUserBtn;
        private System.Windows.Forms.Button addUserBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userHeaderTxt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label infoTxt;
        private System.Windows.Forms.Label creditsTxt;
        private System.Windows.Forms.Timer serviceStatusCheck;
        private System.Windows.Forms.Label zone4StatusTxt;
        private System.Windows.Forms.Label zone4Txt;
        private System.Windows.Forms.Label licenseTxt;
    }
}

