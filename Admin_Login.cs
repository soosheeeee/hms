using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hosp
{
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /* private void linkLabelUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
         {
             User_Login Page = new User_Login();
             Page.Show();
             this.Hide();
         }

         private void buttonUserLogin_Click(object sender, EventArgs e)
         {
             if (textBoxUsername.Text == "" || textBoxPassword.Text == "")
             {
                 MessageBox.Show("Enter Username and Password");

             }
             else if (textBoxUsername.Text == "Admin" && textBoxPassword.Text == "Password")
             {
                 Doctors Obj = new Doctors();
                 Obj.Show();
                 this.Hide();
             }
             else if (textBoxUsername.Text != "Admin" && textBoxPassword.Text != "Password")
             {
                 MessageBox.Show("Enter a valid Username and Password");

             }
         }*/

        private void linkLabelUser_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            User_Login Page = new User_Login();
            Page.Show();
            this.Hide();
        }

        private void buttonUserLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Enter Username and Password");

            }
            else if (textBoxUsername.Text == "Admin" && textBoxPassword.Text == "Password")
            {
                Doctors Obj = new Doctors();
                Obj.Show();
                this.Hide();
            }
            else if (textBoxUsername.Text != "Admin" && textBoxPassword.Text != "Password")
            {
                MessageBox.Show("Enter a valid Username and Password");

            }
        }
    }
}
