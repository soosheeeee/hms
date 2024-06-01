using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hosp
{
    public partial class User_Login : Form
    {
        public User_Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabelAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin_Login Page = new Admin_Login();
            Page.Show();
            this.Hide();
        }
    }
}
