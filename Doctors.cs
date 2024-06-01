using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hosp
{
    public partial class Doctors : Form
    {
        SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C\Hosp\HMSDatabase.mdf;Integrated Security=True");
        public Doctors()
        {
            InitializeComponent();

            

            
        }

        private void buttonPatients_Click(object sender, EventArgs e)
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

        void populate()
        {
            Connect.Open();
            string query = "SELECT * FROM DoctorsTable";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, Connect);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            DGVDoctor.DataSource = dataTable;

       

            Connect.Close();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxDoctorID.Text) ||
                string.IsNullOrWhiteSpace(textBoxDoctorName.Text) ||
                string.IsNullOrWhiteSpace(textBoxDoctorPassword.Text))
            {
                MessageBox.Show("Missing Information! Fill all details.");
            }

            else
            {
                try
                {
                    Connect.Open();
                    string query = "INSERT INTO DoctorsTable (DoctorID, DoctorName, DoctorPassword) VALUES (@DoctorID, @DoctorName, @DoctorPassword)";
                    using (SqlCommand command = new SqlCommand(query, Connect))
                    {
                        command.Parameters.AddWithValue("@DoctorID", textBoxDoctorID.Text);
                        command.Parameters.AddWithValue("@DoctorName", textBoxDoctorName.Text);
                        command.Parameters.AddWithValue("@DoctorPassword", textBoxDoctorPassword.Text);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Doctor Added Successfully");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    Connect.Close();
                    populate();
                }
            }
        }

        private void DGVDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGVDoctor.Rows[e.RowIndex];
                textBoxDoctorID.Text = row.Cells[0].Value.ToString();
                textBoxDoctorName.Text = row.Cells[1].Value.ToString();
                textBoxDoctorPassword.Text = row.Cells[2].Value.ToString();
            }

        }
    }
}
