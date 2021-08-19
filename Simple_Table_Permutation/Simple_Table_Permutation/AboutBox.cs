﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Simple_Table_Permutation
{
    public partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
        }

        private void AboutBox_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("Images/TUSUR_logo.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            label4.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void linkLabelRepository_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ColdCloudd/repos_course_work");
        }

        private void linkLabelEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:danya02051@gmail.com");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://tusur.ru");
        }

    }
}
