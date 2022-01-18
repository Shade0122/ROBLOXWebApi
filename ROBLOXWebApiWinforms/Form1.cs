using System;
using System.Windows.Forms;
using ROBLOXWebApi; // Include this to have full access of the functions.

namespace ROBLOXWebApiWinforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SearchUser_Click(object sender, EventArgs e)
        {
            string User = UserSearch.Text;
            //Information
            UsernameOutput.Text = WebAPI.Username(User);
            DisplayNameOutput.Text = WebAPI.DisplayName(User);
            IDOutput.Text = WebAPI.ID(User);
            DescriptionBox.Text = WebAPI.Description(User);
            //Details
            StatusOutput.Text = WebAPI.Status(User);
            LastOnlineOutput.Text = WebAPI.LastOnline(User);
            BannedOutput.Text = WebAPI.IsBanned(User);
            OnlineOutput.Text = WebAPI.IsOnline(User);
            //Avatar
            AvatarImage.ImageLocation = WebAPI.Headshot(User);
            HeadshotURLOutput.Text = WebAPI.Headshot(User);
        }
    }
}