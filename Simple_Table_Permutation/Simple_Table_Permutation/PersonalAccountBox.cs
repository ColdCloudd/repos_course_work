using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Table_Permutation
{
    public partial class PersonalAccountBox : Form
    {
        private User user;
        public PersonalAccountBox(User user)
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
            ChangePasswordBox changePasswordBox = new ChangePasswordBox(user);
            changePasswordBox.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            changePasswordBox.ShowDialog();
        }

        
    }
}
