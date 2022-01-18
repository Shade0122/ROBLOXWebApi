
namespace ROBLOXWebApiWinforms
{
    partial class Form1
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
            this.UserSearch = new System.Windows.Forms.TextBox();
            this.SearchUser = new System.Windows.Forms.Button();
            this.InfoBox = new System.Windows.Forms.GroupBox();
            this.IDOutput = new System.Windows.Forms.TextBox();
            this.DisplayNameOutput = new System.Windows.Forms.TextBox();
            this.UsernameOutput = new System.Windows.Forms.TextBox();
            this.DescriptionBox = new System.Windows.Forms.RichTextBox();
            this.Description = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.DisplayName = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.AvatarBox = new System.Windows.Forms.GroupBox();
            this.AvatarImage = new System.Windows.Forms.PictureBox();
            this.DetailsBox = new System.Windows.Forms.GroupBox();
            this.OnlineOutput = new System.Windows.Forms.TextBox();
            this.BannedOutput = new System.Windows.Forms.TextBox();
            this.Online = new System.Windows.Forms.Label();
            this.Banned = new System.Windows.Forms.Label();
            this.LastOnlineOutput = new System.Windows.Forms.TextBox();
            this.StatusOutput = new System.Windows.Forms.TextBox();
            this.LastOnline = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.Credit = new System.Windows.Forms.Label();
            this.HeadshotURLOutput = new System.Windows.Forms.TextBox();
            this.HeadshotURL = new System.Windows.Forms.Label();
            this.InfoBox.SuspendLayout();
            this.AvatarBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarImage)).BeginInit();
            this.DetailsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserSearch
            // 
            this.UserSearch.Location = new System.Drawing.Point(13, 13);
            this.UserSearch.Name = "UserSearch";
            this.UserSearch.Size = new System.Drawing.Size(185, 20);
            this.UserSearch.TabIndex = 0;
            // 
            // SearchUser
            // 
            this.SearchUser.Location = new System.Drawing.Point(204, 13);
            this.SearchUser.Name = "SearchUser";
            this.SearchUser.Size = new System.Drawing.Size(75, 23);
            this.SearchUser.TabIndex = 1;
            this.SearchUser.Text = "Search User";
            this.SearchUser.UseVisualStyleBackColor = true;
            this.SearchUser.Click += new System.EventHandler(this.SearchUser_Click);
            // 
            // InfoBox
            // 
            this.InfoBox.Controls.Add(this.IDOutput);
            this.InfoBox.Controls.Add(this.DisplayNameOutput);
            this.InfoBox.Controls.Add(this.UsernameOutput);
            this.InfoBox.Controls.Add(this.DescriptionBox);
            this.InfoBox.Controls.Add(this.Description);
            this.InfoBox.Controls.Add(this.ID);
            this.InfoBox.Controls.Add(this.DisplayName);
            this.InfoBox.Controls.Add(this.Username);
            this.InfoBox.Location = new System.Drawing.Point(13, 39);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(266, 243);
            this.InfoBox.TabIndex = 2;
            this.InfoBox.TabStop = false;
            this.InfoBox.Text = "Information";
            // 
            // IDOutput
            // 
            this.IDOutput.Location = new System.Drawing.Point(23, 57);
            this.IDOutput.Name = "IDOutput";
            this.IDOutput.ReadOnly = true;
            this.IDOutput.Size = new System.Drawing.Size(237, 20);
            this.IDOutput.TabIndex = 7;
            // 
            // DisplayNameOutput
            // 
            this.DisplayNameOutput.Location = new System.Drawing.Point(76, 35);
            this.DisplayNameOutput.Name = "DisplayNameOutput";
            this.DisplayNameOutput.ReadOnly = true;
            this.DisplayNameOutput.Size = new System.Drawing.Size(184, 20);
            this.DisplayNameOutput.TabIndex = 6;
            // 
            // UsernameOutput
            // 
            this.UsernameOutput.Location = new System.Drawing.Point(59, 13);
            this.UsernameOutput.Name = "UsernameOutput";
            this.UsernameOutput.ReadOnly = true;
            this.UsernameOutput.Size = new System.Drawing.Size(201, 20);
            this.UsernameOutput.TabIndex = 5;
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(6, 98);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.ReadOnly = true;
            this.DescriptionBox.Size = new System.Drawing.Size(254, 139);
            this.DescriptionBox.TabIndex = 4;
            this.DescriptionBox.Text = "";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(3, 82);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(66, 13);
            this.Description.TabIndex = 3;
            this.Description.Text = "Description: ";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(3, 60);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(24, 13);
            this.ID.TabIndex = 2;
            this.ID.Text = "ID: ";
            // 
            // DisplayName
            // 
            this.DisplayName.AutoSize = true;
            this.DisplayName.BackColor = System.Drawing.Color.Transparent;
            this.DisplayName.Location = new System.Drawing.Point(3, 38);
            this.DisplayName.Name = "DisplayName";
            this.DisplayName.Size = new System.Drawing.Size(78, 13);
            this.DisplayName.TabIndex = 1;
            this.DisplayName.Text = "Display Name: ";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.Color.Transparent;
            this.Username.Location = new System.Drawing.Point(3, 16);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(61, 13);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username: ";
            // 
            // AvatarBox
            // 
            this.AvatarBox.Controls.Add(this.HeadshotURLOutput);
            this.AvatarBox.Controls.Add(this.HeadshotURL);
            this.AvatarBox.Controls.Add(this.AvatarImage);
            this.AvatarBox.Location = new System.Drawing.Point(285, 12);
            this.AvatarBox.Name = "AvatarBox";
            this.AvatarBox.Size = new System.Drawing.Size(262, 318);
            this.AvatarBox.TabIndex = 4;
            this.AvatarBox.TabStop = false;
            this.AvatarBox.Text = "Avatar";
            // 
            // AvatarImage
            // 
            this.AvatarImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AvatarImage.Location = new System.Drawing.Point(6, 19);
            this.AvatarImage.Name = "AvatarImage";
            this.AvatarImage.Size = new System.Drawing.Size(250, 250);
            this.AvatarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AvatarImage.TabIndex = 0;
            this.AvatarImage.TabStop = false;
            // 
            // DetailsBox
            // 
            this.DetailsBox.Controls.Add(this.OnlineOutput);
            this.DetailsBox.Controls.Add(this.BannedOutput);
            this.DetailsBox.Controls.Add(this.Online);
            this.DetailsBox.Controls.Add(this.Banned);
            this.DetailsBox.Controls.Add(this.LastOnlineOutput);
            this.DetailsBox.Controls.Add(this.StatusOutput);
            this.DetailsBox.Controls.Add(this.LastOnline);
            this.DetailsBox.Controls.Add(this.Status);
            this.DetailsBox.Location = new System.Drawing.Point(13, 288);
            this.DetailsBox.Name = "DetailsBox";
            this.DetailsBox.Size = new System.Drawing.Size(266, 110);
            this.DetailsBox.TabIndex = 7;
            this.DetailsBox.TabStop = false;
            this.DetailsBox.Text = "Details";
            // 
            // OnlineOutput
            // 
            this.OnlineOutput.Location = new System.Drawing.Point(46, 81);
            this.OnlineOutput.Name = "OnlineOutput";
            this.OnlineOutput.ReadOnly = true;
            this.OnlineOutput.Size = new System.Drawing.Size(214, 20);
            this.OnlineOutput.TabIndex = 13;
            // 
            // BannedOutput
            // 
            this.BannedOutput.Location = new System.Drawing.Point(51, 59);
            this.BannedOutput.Name = "BannedOutput";
            this.BannedOutput.ReadOnly = true;
            this.BannedOutput.Size = new System.Drawing.Size(209, 20);
            this.BannedOutput.TabIndex = 12;
            // 
            // Online
            // 
            this.Online.AutoSize = true;
            this.Online.Location = new System.Drawing.Point(6, 84);
            this.Online.Name = "Online";
            this.Online.Size = new System.Drawing.Size(40, 13);
            this.Online.TabIndex = 11;
            this.Online.Text = "Online:";
            // 
            // Banned
            // 
            this.Banned.AutoSize = true;
            this.Banned.Location = new System.Drawing.Point(6, 62);
            this.Banned.Name = "Banned";
            this.Banned.Size = new System.Drawing.Size(47, 13);
            this.Banned.TabIndex = 10;
            this.Banned.Text = "Banned:";
            // 
            // LastOnlineOutput
            // 
            this.LastOnlineOutput.Location = new System.Drawing.Point(70, 35);
            this.LastOnlineOutput.Name = "LastOnlineOutput";
            this.LastOnlineOutput.ReadOnly = true;
            this.LastOnlineOutput.Size = new System.Drawing.Size(190, 20);
            this.LastOnlineOutput.TabIndex = 9;
            // 
            // StatusOutput
            // 
            this.StatusOutput.Location = new System.Drawing.Point(46, 13);
            this.StatusOutput.Name = "StatusOutput";
            this.StatusOutput.ReadOnly = true;
            this.StatusOutput.Size = new System.Drawing.Size(214, 20);
            this.StatusOutput.TabIndex = 8;
            // 
            // LastOnline
            // 
            this.LastOnline.AutoSize = true;
            this.LastOnline.Location = new System.Drawing.Point(6, 38);
            this.LastOnline.Name = "LastOnline";
            this.LastOnline.Size = new System.Drawing.Size(63, 13);
            this.LastOnline.TabIndex = 5;
            this.LastOnline.Text = "Last Online:";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(6, 16);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(43, 13);
            this.Status.TabIndex = 4;
            this.Status.Text = "Status: ";
            // 
            // Credit
            // 
            this.Credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.Credit.Location = new System.Drawing.Point(285, 340);
            this.Credit.Name = "Credit";
            this.Credit.Size = new System.Drawing.Size(266, 52);
            this.Credit.TabIndex = 8;
            this.Credit.Text = "By Shade#9951";
            // 
            // HeadshotURLOutput
            // 
            this.HeadshotURLOutput.Location = new System.Drawing.Point(6, 292);
            this.HeadshotURLOutput.Name = "HeadshotURLOutput";
            this.HeadshotURLOutput.ReadOnly = true;
            this.HeadshotURLOutput.Size = new System.Drawing.Size(250, 20);
            this.HeadshotURLOutput.TabIndex = 15;
            // 
            // HeadshotURL
            // 
            this.HeadshotURL.AutoSize = true;
            this.HeadshotURL.Location = new System.Drawing.Point(6, 278);
            this.HeadshotURL.Name = "HeadshotURL";
            this.HeadshotURL.Size = new System.Drawing.Size(81, 13);
            this.HeadshotURL.TabIndex = 14;
            this.HeadshotURL.Text = "Headshot URL:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 401);
            this.Controls.Add(this.Credit);
            this.Controls.Add(this.DetailsBox);
            this.Controls.Add(this.AvatarBox);
            this.Controls.Add(this.InfoBox);
            this.Controls.Add(this.SearchUser);
            this.Controls.Add(this.UserSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ROBLOXWebApi";
            this.InfoBox.ResumeLayout(false);
            this.InfoBox.PerformLayout();
            this.AvatarBox.ResumeLayout(false);
            this.AvatarBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarImage)).EndInit();
            this.DetailsBox.ResumeLayout(false);
            this.DetailsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserSearch;
        private System.Windows.Forms.Button SearchUser;
        private System.Windows.Forms.GroupBox InfoBox;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label DisplayName;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.GroupBox AvatarBox;
        private System.Windows.Forms.PictureBox AvatarImage;
        private System.Windows.Forms.GroupBox DetailsBox;
        private System.Windows.Forms.Label LastOnline;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.RichTextBox DescriptionBox;
        private System.Windows.Forms.TextBox IDOutput;
        private System.Windows.Forms.TextBox DisplayNameOutput;
        private System.Windows.Forms.TextBox UsernameOutput;
        private System.Windows.Forms.TextBox LastOnlineOutput;
        private System.Windows.Forms.TextBox StatusOutput;
        private System.Windows.Forms.Label Credit;
        private System.Windows.Forms.TextBox OnlineOutput;
        private System.Windows.Forms.TextBox BannedOutput;
        private System.Windows.Forms.Label Online;
        private System.Windows.Forms.Label Banned;
        private System.Windows.Forms.TextBox HeadshotURLOutput;
        private System.Windows.Forms.Label HeadshotURL;
    }
}

