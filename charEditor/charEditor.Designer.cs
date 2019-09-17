namespace WindowsFormsApp1
{
    partial class charEditor
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
            this.usernameField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.usernameTxt = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.Label();
            this.authorTxt = new System.Windows.Forms.Label();
            this.infoTxt = new System.Windows.Forms.Label();
            this.charNameField = new System.Windows.Forms.TextBox();
            this.charInfo = new System.Windows.Forms.Panel();
            this.accountOwnerTxt = new System.Windows.Forms.Label();
            this.statusTxt = new System.Windows.Forms.Label();
            this.locationField = new System.Windows.Forms.TextBox();
            this.mapField = new System.Windows.Forms.TextBox();
            this.nameField = new System.Windows.Forms.TextBox();
            this.locationTxt = new System.Windows.Forms.Label();
            this.mapTxt = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.charNameTxt = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.serviceManagerBtn = new System.Windows.Forms.Button();
            this.adminLvField = new System.Windows.Forms.TextBox();
            this.adminLvTxt = new System.Windows.Forms.Label();
            this.editingTxt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.charInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameField
            // 
            this.usernameField.Location = new System.Drawing.Point(12, 23);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(100, 20);
            this.usernameField.TabIndex = 0;
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(12, 63);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(100, 20);
            this.passwordField.TabIndex = 1;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(12, 89);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // usernameTxt
            // 
            this.usernameTxt.AutoSize = true;
            this.usernameTxt.Location = new System.Drawing.Point(11, 7);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(61, 13);
            this.usernameTxt.TabIndex = 3;
            this.usernameTxt.Text = "Username: ";
            // 
            // passwordTxt
            // 
            this.passwordTxt.AutoSize = true;
            this.passwordTxt.Location = new System.Drawing.Point(11, 47);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(56, 13);
            this.passwordTxt.TabIndex = 4;
            this.passwordTxt.Text = "Password:";
            // 
            // authorTxt
            // 
            this.authorTxt.AutoSize = true;
            this.authorTxt.Location = new System.Drawing.Point(1, 300);
            this.authorTxt.Name = "authorTxt";
            this.authorTxt.Size = new System.Drawing.Size(178, 13);
            this.authorTxt.TabIndex = 5;
            this.authorTxt.Text = "Author: Harry / Discord: Harry#8354";
            // 
            // infoTxt
            // 
            this.infoTxt.AutoSize = true;
            this.infoTxt.Location = new System.Drawing.Point(13, 119);
            this.infoTxt.Name = "infoTxt";
            this.infoTxt.Size = new System.Drawing.Size(0, 13);
            this.infoTxt.TabIndex = 6;
            // 
            // charNameField
            // 
            this.charNameField.Location = new System.Drawing.Point(12, 175);
            this.charNameField.Name = "charNameField";
            this.charNameField.Size = new System.Drawing.Size(100, 20);
            this.charNameField.TabIndex = 7;
            this.charNameField.Visible = false;
            // 
            // charInfo
            // 
            this.charInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.charInfo.Controls.Add(this.button3);
            this.charInfo.Controls.Add(this.button2);
            this.charInfo.Controls.Add(this.button1);
            this.charInfo.Controls.Add(this.editingTxt);
            this.charInfo.Controls.Add(this.adminLvField);
            this.charInfo.Controls.Add(this.adminLvTxt);
            this.charInfo.Controls.Add(this.accountOwnerTxt);
            this.charInfo.Controls.Add(this.statusTxt);
            this.charInfo.Controls.Add(this.locationField);
            this.charInfo.Controls.Add(this.mapField);
            this.charInfo.Controls.Add(this.nameField);
            this.charInfo.Controls.Add(this.locationTxt);
            this.charInfo.Controls.Add(this.mapTxt);
            this.charInfo.Controls.Add(this.nameTxt);
            this.charInfo.Controls.Add(this.updateBtn);
            this.charInfo.Location = new System.Drawing.Point(118, 12);
            this.charInfo.Name = "charInfo";
            this.charInfo.Size = new System.Drawing.Size(452, 274);
            this.charInfo.TabIndex = 8;
            this.charInfo.Visible = false;
            // 
            // accountOwnerTxt
            // 
            this.accountOwnerTxt.AutoSize = true;
            this.accountOwnerTxt.Location = new System.Drawing.Point(9, 10);
            this.accountOwnerTxt.Name = "accountOwnerTxt";
            this.accountOwnerTxt.Size = new System.Drawing.Size(0, 13);
            this.accountOwnerTxt.TabIndex = 16;
            // 
            // statusTxt
            // 
            this.statusTxt.AutoSize = true;
            this.statusTxt.Location = new System.Drawing.Point(9, 253);
            this.statusTxt.Name = "statusTxt";
            this.statusTxt.Size = new System.Drawing.Size(10, 13);
            this.statusTxt.TabIndex = 13;
            this.statusTxt.Text = ".";
            // 
            // locationField
            // 
            this.locationField.Location = new System.Drawing.Point(66, 63);
            this.locationField.Name = "locationField";
            this.locationField.Size = new System.Drawing.Size(100, 20);
            this.locationField.TabIndex = 10;
            // 
            // mapField
            // 
            this.mapField.Location = new System.Drawing.Point(66, 37);
            this.mapField.Name = "mapField";
            this.mapField.Size = new System.Drawing.Size(100, 20);
            this.mapField.TabIndex = 9;
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(66, 11);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(100, 20);
            this.nameField.TabIndex = 7;
            // 
            // locationTxt
            // 
            this.locationTxt.AutoSize = true;
            this.locationTxt.Location = new System.Drawing.Point(9, 70);
            this.locationTxt.Name = "locationTxt";
            this.locationTxt.Size = new System.Drawing.Size(51, 13);
            this.locationTxt.TabIndex = 6;
            this.locationTxt.Text = "Location:";
            // 
            // mapTxt
            // 
            this.mapTxt.AutoSize = true;
            this.mapTxt.Location = new System.Drawing.Point(29, 44);
            this.mapTxt.Name = "mapTxt";
            this.mapTxt.Size = new System.Drawing.Size(31, 13);
            this.mapTxt.TabIndex = 5;
            this.mapTxt.Text = "Map:";
            // 
            // nameTxt
            // 
            this.nameTxt.AutoSize = true;
            this.nameTxt.Location = new System.Drawing.Point(22, 13);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(38, 13);
            this.nameTxt.TabIndex = 1;
            this.nameTxt.Text = "Name:";
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(172, 10);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 0;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // charNameTxt
            // 
            this.charNameTxt.AutoSize = true;
            this.charNameTxt.Location = new System.Drawing.Point(9, 159);
            this.charNameTxt.Name = "charNameTxt";
            this.charNameTxt.Size = new System.Drawing.Size(84, 13);
            this.charNameTxt.TabIndex = 9;
            this.charNameTxt.Text = "Character Name";
            this.charNameTxt.Visible = false;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(12, 201);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 10;
            this.searchBtn.Text = "Load";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Visible = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // serviceManagerBtn
            // 
            this.serviceManagerBtn.Location = new System.Drawing.Point(14, 255);
            this.serviceManagerBtn.Name = "serviceManagerBtn";
            this.serviceManagerBtn.Size = new System.Drawing.Size(81, 35);
            this.serviceManagerBtn.TabIndex = 11;
            this.serviceManagerBtn.Text = "Service Manager";
            this.serviceManagerBtn.UseVisualStyleBackColor = true;
            this.serviceManagerBtn.Click += new System.EventHandler(this.serviceManagerBtn_Click);
            // 
            // adminLvField
            // 
            this.adminLvField.Location = new System.Drawing.Point(66, 92);
            this.adminLvField.Name = "adminLvField";
            this.adminLvField.Size = new System.Drawing.Size(100, 20);
            this.adminLvField.TabIndex = 13;
            // 
            // adminLvTxt
            // 
            this.adminLvTxt.AutoSize = true;
            this.adminLvTxt.Location = new System.Drawing.Point(21, 95);
            this.adminLvTxt.Name = "adminLvTxt";
            this.adminLvTxt.Size = new System.Drawing.Size(39, 13);
            this.adminLvTxt.TabIndex = 12;
            this.adminLvTxt.Text = "Admin:";
            // 
            // editingTxt
            // 
            this.editingTxt.AutoSize = true;
            this.editingTxt.Location = new System.Drawing.Point(301, 146);
            this.editingTxt.Name = "editingTxt";
            this.editingTxt.Size = new System.Drawing.Size(10, 13);
            this.editingTxt.TabIndex = 18;
            this.editingTxt.Text = ".";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(172, 89);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // charEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 314);
            this.Controls.Add(this.serviceManagerBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.charNameTxt);
            this.Controls.Add(this.charNameField);
            this.Controls.Add(this.charInfo);
            this.Controls.Add(this.infoTxt);
            this.Controls.Add(this.authorTxt);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.usernameField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "charEditor";
            this.Text = "Character Editor";
            this.charInfo.ResumeLayout(false);
            this.charInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label usernameTxt;
        private System.Windows.Forms.Label passwordTxt;
        private System.Windows.Forms.Label authorTxt;
        private System.Windows.Forms.Label infoTxt;
        private System.Windows.Forms.TextBox charNameField;
        private System.Windows.Forms.Panel charInfo;
        private System.Windows.Forms.Label charNameTxt;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button serviceManagerBtn;
        private System.Windows.Forms.Label nameTxt;
        private System.Windows.Forms.Label mapTxt;
        private System.Windows.Forms.Label locationTxt;
        private System.Windows.Forms.TextBox locationField;
        private System.Windows.Forms.TextBox mapField;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label statusTxt;
        private System.Windows.Forms.Label accountOwnerTxt;
        private System.Windows.Forms.TextBox adminLvField;
        private System.Windows.Forms.Label adminLvTxt;
        private System.Windows.Forms.Label editingTxt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

