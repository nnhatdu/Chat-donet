namespace client
{
    partial class client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(client));
            this.lsbConversation = new System.Windows.Forms.ListBox();
            this.lblConversation = new System.Windows.Forms.Label();
            this.lsbChatBox = new System.Windows.Forms.ListBox();
            this.lblChatBox = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lsbActiveUser = new System.Windows.Forms.ListBox();
            this.lblActiveUser = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.sendnoti = new System.Windows.Forms.NotifyIcon(this.components);
            this.closeBut = new System.Windows.Forms.Button();
            this.hideBut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nametag = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnChangeName = new System.Windows.Forms.Button();
            this.btnChangeDate = new System.Windows.Forms.Button();
            this.btnSendData = new System.Windows.Forms.Button();
            this.btnReceive = new System.Windows.Forms.Button();
            this.changeMenu = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.file = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.changeMenu.SuspendLayout();
            this.file.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsbConversation
            // 
            this.lsbConversation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(209)))));
            this.lsbConversation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsbConversation.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbConversation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(97)))), ((int)(((byte)(48)))));
            this.lsbConversation.FormattingEnabled = true;
            this.lsbConversation.ItemHeight = 27;
            this.lsbConversation.Location = new System.Drawing.Point(13, 149);
            this.lsbConversation.Margin = new System.Windows.Forms.Padding(4);
            this.lsbConversation.Name = "lsbConversation";
            this.lsbConversation.ScrollAlwaysVisible = true;
            this.lsbConversation.Size = new System.Drawing.Size(185, 434);
            this.lsbConversation.TabIndex = 0;
            this.lsbConversation.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lsbConversation_MouseClick);
            // 
            // lblConversation
            // 
            this.lblConversation.AutoSize = true;
            this.lblConversation.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConversation.Location = new System.Drawing.Point(15, 110);
            this.lblConversation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConversation.Name = "lblConversation";
            this.lblConversation.Size = new System.Drawing.Size(174, 25);
            this.lblConversation.TabIndex = 1;
            this.lblConversation.Text = "CONVERSATIONS";
            // 
            // lsbChatBox
            // 
            this.lsbChatBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(209)))));
            this.lsbChatBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsbChatBox.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbChatBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(97)))), ((int)(((byte)(48)))));
            this.lsbChatBox.FormattingEnabled = true;
            this.lsbChatBox.ItemHeight = 27;
            this.lsbChatBox.Location = new System.Drawing.Point(215, 149);
            this.lsbChatBox.Margin = new System.Windows.Forms.Padding(4);
            this.lsbChatBox.Name = "lsbChatBox";
            this.lsbChatBox.ScrollAlwaysVisible = true;
            this.lsbChatBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lsbChatBox.Size = new System.Drawing.Size(741, 353);
            this.lsbChatBox.TabIndex = 2;
            // 
            // lblChatBox
            // 
            this.lblChatBox.AutoSize = true;
            this.lblChatBox.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChatBox.Location = new System.Drawing.Point(220, 110);
            this.lblChatBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChatBox.Name = "lblChatBox";
            this.lblChatBox.Size = new System.Drawing.Size(63, 25);
            this.lblChatBox.TabIndex = 3;
            this.lblChatBox.Text = "CHAT";
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(209)))));
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInput.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(97)))), ((int)(((byte)(48)))));
            this.txtInput.Location = new System.Drawing.Point(215, 524);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(594, 59);
            this.txtInput.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(97)))), ((int)(((byte)(48)))));
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSend.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(189)))));
            this.btnSend.FlatAppearance.BorderSize = 2;
            this.btnSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(145)))), ((int)(((byte)(55)))));
            this.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(97)))), ((int)(((byte)(48)))));
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Montserrat Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(189)))));
            this.btnSend.Location = new System.Drawing.Point(829, 524);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(127, 59);
            this.btnSend.TabIndex = 12;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lsbActiveUser
            // 
            this.lsbActiveUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(209)))));
            this.lsbActiveUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsbActiveUser.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbActiveUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(97)))), ((int)(((byte)(48)))));
            this.lsbActiveUser.FormattingEnabled = true;
            this.lsbActiveUser.ItemHeight = 27;
            this.lsbActiveUser.Location = new System.Drawing.Point(969, 149);
            this.lsbActiveUser.Margin = new System.Windows.Forms.Padding(4);
            this.lsbActiveUser.Name = "lsbActiveUser";
            this.lsbActiveUser.ScrollAlwaysVisible = true;
            this.lsbActiveUser.Size = new System.Drawing.Size(198, 434);
            this.lsbActiveUser.TabIndex = 6;
            this.lsbActiveUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lsbActiveUser_MouseClick);
            // 
            // lblActiveUser
            // 
            this.lblActiveUser.AutoSize = true;
            this.lblActiveUser.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveUser.Location = new System.Drawing.Point(1003, 110);
            this.lblActiveUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActiveUser.Name = "lblActiveUser";
            this.lblActiveUser.Size = new System.Drawing.Size(136, 25);
            this.lblActiveUser.TabIndex = 7;
            this.lblActiveUser.Text = "ACTIVE NOW";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Montserrat Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(78, 47);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(205, 50);
            this.lblUserName.TabIndex = 10;
            this.lblUserName.Text = "WELCOME !";
            // 
            // btnInfo
            // 
            this.btnInfo.AutoSize = true;
            this.btnInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(97)))), ((int)(((byte)(48)))));
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(145)))), ((int)(((byte)(55)))));
            this.btnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(163)))));
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Montserrat Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Location = new System.Drawing.Point(291, 95);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(109, 54);
            this.btnInfo.TabIndex = 11;
            this.btnInfo.Text = "label1";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.TextChanged += new System.EventHandler(this.btnInfo_TextChanged);
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // sendnoti
            // 
            this.sendnoti.BalloonTipText = "You Received a Message";
            this.sendnoti.BalloonTipTitle = "NOTIFICATION FROM CHAT DOTNET";
            this.sendnoti.Icon = ((System.Drawing.Icon)(resources.GetObject("sendnoti.Icon")));
            this.sendnoti.Visible = true;
            // 
            // closeBut
            // 
            this.closeBut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(97)))), ((int)(((byte)(48)))));
            this.closeBut.FlatAppearance.BorderSize = 3;
            this.closeBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(145)))), ((int)(((byte)(55)))));
            this.closeBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(163)))));
            this.closeBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBut.Font = new System.Drawing.Font("Felix Titling", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(97)))), ((int)(((byte)(48)))));
            this.closeBut.Location = new System.Drawing.Point(1137, 12);
            this.closeBut.Name = "closeBut";
            this.closeBut.Size = new System.Drawing.Size(30, 30);
            this.closeBut.TabIndex = 13;
            this.closeBut.Text = "X";
            this.closeBut.UseVisualStyleBackColor = false;
            this.closeBut.Click += new System.EventHandler(this.closeBut_Click_1);
            // 
            // hideBut
            // 
            this.hideBut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(97)))), ((int)(((byte)(48)))));
            this.hideBut.FlatAppearance.BorderSize = 3;
            this.hideBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(145)))), ((int)(((byte)(55)))));
            this.hideBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(163)))));
            this.hideBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hideBut.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideBut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(97)))), ((int)(((byte)(48)))));
            this.hideBut.Location = new System.Drawing.Point(1101, 12);
            this.hideBut.Name = "hideBut";
            this.hideBut.Size = new System.Drawing.Size(30, 30);
            this.hideBut.TabIndex = 14;
            this.hideBut.Text = "-";
            this.hideBut.UseVisualStyleBackColor = false;
            this.hideBut.Click += new System.EventHandler(this.hideBut_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.nametag);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1179, 61);
            this.panel1.TabIndex = 15;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown_1);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove_1);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // nametag
            // 
            this.nametag.AutoSize = true;
            this.nametag.Font = new System.Drawing.Font("Montserrat Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametag.Location = new System.Drawing.Point(64, 17);
            this.nametag.Name = "nametag";
            this.nametag.Size = new System.Drawing.Size(134, 37);
            this.nametag.TabIndex = 10;
            this.nametag.Text = "CHAT BOX";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Location = new System.Drawing.Point(0, 82);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(133, 41);
            this.btnChangePassword.TabIndex = 16;
            this.btnChangePassword.Text = "PASSWORD";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnChangeName
            // 
            this.btnChangeName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeName.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeName.Location = new System.Drawing.Point(0, 41);
            this.btnChangeName.Name = "btnChangeName";
            this.btnChangeName.Size = new System.Drawing.Size(133, 41);
            this.btnChangeName.TabIndex = 17;
            this.btnChangeName.Text = "NAME";
            this.btnChangeName.UseVisualStyleBackColor = true;
            this.btnChangeName.Click += new System.EventHandler(this.btnChangeName_Click);
            // 
            // btnChangeDate
            // 
            this.btnChangeDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeDate.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeDate.Location = new System.Drawing.Point(0, 123);
            this.btnChangeDate.Name = "btnChangeDate";
            this.btnChangeDate.Size = new System.Drawing.Size(133, 41);
            this.btnChangeDate.TabIndex = 18;
            this.btnChangeDate.Text = "DOB";
            this.btnChangeDate.UseVisualStyleBackColor = true;
            this.btnChangeDate.Click += new System.EventHandler(this.btnChangeDate_Click);
            // 
            // btnSendData
            // 
            this.btnSendData.FlatAppearance.BorderSize = 3;
            this.btnSendData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendData.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendData.Location = new System.Drawing.Point(0, 37);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(133, 41);
            this.btnSendData.TabIndex = 19;
            this.btnSendData.Text = "SEND";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // btnReceive
            // 
            this.btnReceive.FlatAppearance.BorderSize = 3;
            this.btnReceive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceive.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceive.Location = new System.Drawing.Point(0, 75);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(133, 41);
            this.btnReceive.TabIndex = 20;
            this.btnReceive.Text = "RECEIVE";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // changeMenu
            // 
            this.changeMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(97)))), ((int)(((byte)(48)))));
            this.changeMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.changeMenu.Controls.Add(this.button2);
            this.changeMenu.Controls.Add(this.btnChangeDate);
            this.changeMenu.Controls.Add(this.btnChangeName);
            this.changeMenu.Controls.Add(this.btnChangePassword);
            this.changeMenu.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(189)))));
            this.changeMenu.Location = new System.Drawing.Point(654, 92);
            this.changeMenu.Name = "changeMenu";
            this.changeMenu.Size = new System.Drawing.Size(133, 41);
            this.changeMenu.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(189)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(97)))), ((int)(((byte)(48)))));
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(145)))), ((int)(((byte)(55)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(163)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(97)))), ((int)(((byte)(48)))));
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 41);
            this.button2.TabIndex = 19;
            this.button2.Text = "CHANGE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // file
            // 
            this.file.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(97)))), ((int)(((byte)(48)))));
            this.file.Controls.Add(this.button3);
            this.file.Controls.Add(this.btnSendData);
            this.file.Controls.Add(this.btnReceive);
            this.file.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(189)))));
            this.file.Location = new System.Drawing.Point(793, 92);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(133, 41);
            this.file.TabIndex = 22;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(189)))));
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(145)))), ((int)(((byte)(55)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(97)))), ((int)(((byte)(48)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 41);
            this.button3.TabIndex = 0;
            this.button3.Text = "FILE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // client
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(1179, 599);
            this.Controls.Add(this.file);
            this.Controls.Add(this.changeMenu);
            this.Controls.Add(this.hideBut);
            this.Controls.Add(this.closeBut);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblActiveUser);
            this.Controls.Add(this.lsbActiveUser);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblChatBox);
            this.Controls.Add(this.lsbChatBox);
            this.Controls.Add(this.lblConversation);
            this.Controls.Add(this.lsbConversation);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(97)))), ((int)(((byte)(48)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.client_FormClosed);
            this.Load += new System.EventHandler(this.client_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.changeMenu.ResumeLayout(false);
            this.file.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbConversation;
        private System.Windows.Forms.Label lblConversation;
        private System.Windows.Forms.ListBox lsbChatBox;
        private System.Windows.Forms.Label lblChatBox;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox lsbActiveUser;
        private System.Windows.Forms.Label lblActiveUser;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.NotifyIcon sendnoti;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button closeBut;
        private System.Windows.Forms.Button hideBut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label nametag;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnChangeName;
        private System.Windows.Forms.Button btnChangeDate;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.Panel changeMenu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel file;
        private System.Windows.Forms.Button button3;
    }
}