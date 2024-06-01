﻿using System;
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
    public partial class Patients : Form
    {
        public Patients()
        {
            InitializeComponent();
        }

        private void buttonDoctor_Click(object sender, EventArgs e)
        {
            Doctors Obj = new Doctors();
            Obj.Show();
            this.Hide();
        }

        private void buttonPatient_Click(object sender, EventArgs e)
        {
            Patients Obj = new Patients();
            Obj.Show();
            this.Hide();
        }

        private void buttonDiagnosis_Click(object sender, EventArgs e)
        {
            Diagnosis Obj = new Diagnosis();
            Obj.Show();
            this.Hide();
        }

        private void buttonMedicine_Click(object sender, EventArgs e)
        {
            Medicine Obj = new Medicine();
            Obj.Show();
            this.Hide();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Admin_Login Obj = new Admin_Login();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonDoctor_Click_1(object sender, EventArgs e)
        {
            Doctors Obj = new Doctors();
            Obj.Show();
            this.Hide();
        }

        private void buttonDiagnosis_Click_1(object sender, EventArgs e)
        {
            Diagnosis Obj = new Diagnosis();
            Obj.Show();
            this.Hide();
        }

        private void buttonMedicine_Click_1(object sender, EventArgs e)
        {
            Medicine Obj = new Medicine();
            Obj.Show();
            this.Hide();
        }

        private void buttonLogout_Click_1(object sender, EventArgs e)
        {
            Admin_Login Obj = new Admin_Login();
            Obj.Show();
            this.Hide();
        }
    }
}
