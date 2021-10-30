using System;
using System.Windows.Forms;

namespace Simple_Table_Permutation
{
    public partial class PersonalAccountBox : Form
    {
        private User user;
        public PersonalAccountBox(ref User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void PersonalAccountBox_Load(object sender, EventArgs e)
        {
            labelUsername.Text = user.username;
            labelLogin.Text = user.login;
            labelRole.Text = user.role;
            labelId.Text = user.id;
        }

        private void linkLabelChangePass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePasswordBox changePasswordBox = new ChangePasswordBox(ref user);
            changePasswordBox.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            changePasswordBox.ShowDialog();
        }
    }
}
