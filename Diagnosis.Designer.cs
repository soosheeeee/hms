namespace Hosp
{
    partial class Diagnosis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diagnosis));
            textBoxDiagnosisID = new TextBox();
            panel1 = new Panel();
            buttonLogout = new Button();
            buttonMedicine = new Button();
            buttonPatient = new Button();
            buttonDiagnosis = new Button();
            buttonDoctor = new Button();
            panel3 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            textBoxPatientID = new TextBox();
            panel4 = new Panel();
            label5 = new Label();
            textBoxPatientName = new TextBox();
            panel5 = new Panel();
            label6 = new Label();
            textBoxDiagnosis = new TextBox();
            panel6 = new Panel();
            label7 = new Label();
            textBoxSymptoms = new TextBox();
            buttonMedicineDelete = new Button();
            buttonMedicineAdd = new Button();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textBoxDiagnosisID
            // 
            textBoxDiagnosisID.BackColor = Color.FromArgb(240, 237, 212);
            textBoxDiagnosisID.BorderStyle = BorderStyle.None;
            textBoxDiagnosisID.Font = new Font("Bahnschrift", 9.75F);
            textBoxDiagnosisID.Location = new Point(109, 11);
            textBoxDiagnosisID.Margin = new Padding(4);
            textBoxDiagnosisID.Name = "textBoxDiagnosisID";
            textBoxDiagnosisID.Size = new Size(91, 16);
            textBoxDiagnosisID.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(220, 95, 0);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(buttonLogout);
            panel1.Controls.Add(buttonMedicine);
            panel1.Controls.Add(buttonPatient);
            panel1.Controls.Add(buttonDiagnosis);
            panel1.Controls.Add(buttonDoctor);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(199, 768);
            panel1.TabIndex = 28;
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.FromArgb(220, 95, 0);
            buttonLogout.FlatAppearance.BorderColor = Color.FromArgb(220, 95, 0);
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Font = new Font("Bahnschrift", 12F);
            buttonLogout.ForeColor = Color.White;
            buttonLogout.Location = new Point(6, 713);
            buttonLogout.Margin = new Padding(4);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(190, 52);
            buttonLogout.TabIndex = 14;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = false;
            // 
            // buttonMedicine
            // 
            buttonMedicine.BackColor = Color.FromArgb(220, 95, 0);
            buttonMedicine.FlatAppearance.BorderColor = Color.FromArgb(220, 95, 0);
            buttonMedicine.FlatStyle = FlatStyle.Flat;
            buttonMedicine.Font = new Font("Bahnschrift", 12F);
            buttonMedicine.ForeColor = Color.White;
            buttonMedicine.Location = new Point(6, 294);
            buttonMedicine.Margin = new Padding(4);
            buttonMedicine.Name = "buttonMedicine";
            buttonMedicine.Size = new Size(190, 39);
            buttonMedicine.TabIndex = 13;
            buttonMedicine.Text = "Medicine";
            buttonMedicine.UseVisualStyleBackColor = false;
            buttonMedicine.Click += buttonMedicine_Click;
            // 
            // buttonPatient
            // 
            buttonPatient.BackColor = Color.FromArgb(220, 95, 0);
            buttonPatient.FlatAppearance.BorderColor = Color.FromArgb(220, 95, 0);
            buttonPatient.FlatStyle = FlatStyle.Flat;
            buttonPatient.Font = new Font("Bahnschrift", 12F);
            buttonPatient.ForeColor = Color.White;
            buttonPatient.Location = new Point(5, 191);
            buttonPatient.Margin = new Padding(4);
            buttonPatient.Name = "buttonPatient";
            buttonPatient.Size = new Size(190, 39);
            buttonPatient.TabIndex = 12;
            buttonPatient.Text = "Patients";
            buttonPatient.UseVisualStyleBackColor = false;
            buttonPatient.Click += buttonPatient_Click;
            // 
            // buttonDiagnosis
            // 
            buttonDiagnosis.BackColor = Color.FromArgb(220, 95, 0);
            buttonDiagnosis.FlatAppearance.BorderColor = Color.FromArgb(220, 95, 0);
            buttonDiagnosis.FlatStyle = FlatStyle.Flat;
            buttonDiagnosis.Font = new Font("Bahnschrift", 12F);
            buttonDiagnosis.ForeColor = Color.White;
            buttonDiagnosis.Location = new Point(9, 236);
            buttonDiagnosis.Margin = new Padding(4);
            buttonDiagnosis.Name = "buttonDiagnosis";
            buttonDiagnosis.Size = new Size(190, 50);
            buttonDiagnosis.TabIndex = 11;
            buttonDiagnosis.Text = "Diagnosis";
            buttonDiagnosis.UseVisualStyleBackColor = false;
            // 
            // buttonDoctor
            // 
            buttonDoctor.BackColor = Color.FromArgb(220, 95, 0);
            buttonDoctor.FlatAppearance.BorderColor = Color.FromArgb(220, 95, 0);
            buttonDoctor.FlatStyle = FlatStyle.Flat;
            buttonDoctor.Font = new Font("Bahnschrift", 12F);
            buttonDoctor.ForeColor = Color.White;
            buttonDoctor.Location = new Point(6, 144);
            buttonDoctor.Margin = new Padding(4);
            buttonDoctor.Name = "buttonDoctor";
            buttonDoctor.Size = new Size(190, 39);
            buttonDoctor.TabIndex = 10;
            buttonDoctor.Text = "Doctors";
            buttonDoctor.UseVisualStyleBackColor = false;
            buttonDoctor.Click += buttonDoctor_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(240, 237, 212);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(textBoxDiagnosisID);
            panel3.Location = new Point(802, 92);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(209, 49);
            panel3.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 9.75F);
            label2.ForeColor = Color.FromArgb(49, 54, 63);
            label2.Location = new Point(14, 8);
            label2.Name = "label2";
            label2.Size = new Size(80, 16);
            label2.TabIndex = 32;
            label2.Text = "Diagnosis ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(49, 54, 63);
            label1.Location = new Point(562, 38);
            label1.Name = "label1";
            label1.Size = new Size(117, 29);
            label1.TabIndex = 31;
            label1.Text = "Diagnosis";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(240, 237, 212);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBoxPatientID);
            panel2.Location = new Point(581, 92);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(203, 49);
            panel2.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 9.75F);
            label4.ForeColor = Color.FromArgb(49, 54, 63);
            label4.Location = new Point(14, 8);
            label4.Name = "label4";
            label4.Size = new Size(63, 16);
            label4.TabIndex = 32;
            label4.Text = "Patient ID";
            // 
            // textBoxPatientID
            // 
            textBoxPatientID.BackColor = Color.FromArgb(240, 237, 212);
            textBoxPatientID.BorderStyle = BorderStyle.None;
            textBoxPatientID.Font = new Font("Bahnschrift", 9.75F);
            textBoxPatientID.Location = new Point(91, 11);
            textBoxPatientID.Margin = new Padding(4);
            textBoxPatientID.Name = "textBoxPatientID";
            textBoxPatientID.Size = new Size(100, 16);
            textBoxPatientID.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(240, 237, 212);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(textBoxPatientName);
            panel4.Location = new Point(220, 92);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(341, 49);
            panel4.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 9.75F);
            label5.ForeColor = Color.FromArgb(49, 54, 63);
            label5.Location = new Point(14, 8);
            label5.Name = "label5";
            label5.Size = new Size(84, 16);
            label5.TabIndex = 32;
            label5.Text = "Patient Name";
            // 
            // textBoxPatientName
            // 
            textBoxPatientName.BackColor = Color.FromArgb(240, 237, 212);
            textBoxPatientName.BorderStyle = BorderStyle.None;
            textBoxPatientName.Font = new Font("Bahnschrift", 9.75F);
            textBoxPatientName.Location = new Point(109, 11);
            textBoxPatientName.Margin = new Padding(4);
            textBoxPatientName.Name = "textBoxPatientName";
            textBoxPatientName.Size = new Size(217, 16);
            textBoxPatientName.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(240, 237, 212);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(textBoxDiagnosis);
            panel5.Location = new Point(220, 153);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(399, 49);
            panel5.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 9.75F);
            label6.ForeColor = Color.FromArgb(49, 54, 63);
            label6.Location = new Point(13, 8);
            label6.Name = "label6";
            label6.Size = new Size(64, 16);
            label6.TabIndex = 32;
            label6.Text = "Diagnosis";
            // 
            // textBoxDiagnosis
            // 
            textBoxDiagnosis.BackColor = Color.FromArgb(240, 237, 212);
            textBoxDiagnosis.BorderStyle = BorderStyle.None;
            textBoxDiagnosis.Font = new Font("Bahnschrift", 9.75F);
            textBoxDiagnosis.Location = new Point(91, 16);
            textBoxDiagnosis.Margin = new Padding(4);
            textBoxDiagnosis.Name = "textBoxDiagnosis";
            textBoxDiagnosis.Size = new Size(298, 16);
            textBoxDiagnosis.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(240, 237, 212);
            panel6.Controls.Add(label7);
            panel6.Controls.Add(textBoxSymptoms);
            panel6.Location = new Point(636, 153);
            panel6.Margin = new Padding(4);
            panel6.Name = "panel6";
            panel6.Size = new Size(375, 49);
            panel6.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift", 9.75F);
            label7.ForeColor = Color.FromArgb(49, 54, 63);
            label7.Location = new Point(12, 8);
            label7.Name = "label7";
            label7.Size = new Size(68, 16);
            label7.TabIndex = 32;
            label7.Text = "Symptoms";
            // 
            // textBoxSymptoms
            // 
            textBoxSymptoms.BackColor = Color.FromArgb(240, 237, 212);
            textBoxSymptoms.BorderStyle = BorderStyle.None;
            textBoxSymptoms.Font = new Font("Bahnschrift", 9.75F);
            textBoxSymptoms.Location = new Point(94, 16);
            textBoxSymptoms.Margin = new Padding(4);
            textBoxSymptoms.Name = "textBoxSymptoms";
            textBoxSymptoms.Size = new Size(272, 16);
            textBoxSymptoms.TabIndex = 1;
            // 
            // buttonMedicineDelete
            // 
            buttonMedicineDelete.BackColor = Color.FromArgb(220, 95, 0);
            buttonMedicineDelete.FlatAppearance.BorderColor = Color.FromArgb(220, 95, 0);
            buttonMedicineDelete.FlatStyle = FlatStyle.Flat;
            buttonMedicineDelete.Font = new Font("Bahnschrift", 12F);
            buttonMedicineDelete.ForeColor = Color.White;
            buttonMedicineDelete.Location = new Point(642, 222);
            buttonMedicineDelete.Name = "buttonMedicineDelete";
            buttonMedicineDelete.Size = new Size(75, 29);
            buttonMedicineDelete.TabIndex = 38;
            buttonMedicineDelete.Text = "Delete";
            buttonMedicineDelete.UseVisualStyleBackColor = false;
            // 
            // buttonMedicineAdd
            // 
            buttonMedicineAdd.BackColor = Color.FromArgb(220, 95, 0);
            buttonMedicineAdd.FlatAppearance.BorderColor = Color.FromArgb(220, 95, 0);
            buttonMedicineAdd.FlatStyle = FlatStyle.Flat;
            buttonMedicineAdd.Font = new Font("Bahnschrift", 12F);
            buttonMedicineAdd.ForeColor = Color.White;
            buttonMedicineAdd.Location = new Point(523, 222);
            buttonMedicineAdd.Name = "buttonMedicineAdd";
            buttonMedicineAdd.Size = new Size(75, 29);
            buttonMedicineAdd.TabIndex = 37;
            buttonMedicineAdd.Text = "Add";
            buttonMedicineAdd.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(240, 237, 212);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(220, 275);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(791, 481);
            dataGridView1.TabIndex = 39;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(49, 54, 63);
            label3.Location = new Point(220, 249);
            label3.Name = "label3";
            label3.Size = new Size(130, 23);
            label3.TabIndex = 40;
            label3.Text = "Diagnosis List";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(988, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(73, 38);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 74);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // Diagnosis
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 228, 201);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1024, 768);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(buttonMedicineDelete);
            Controls.Add(buttonMedicineAdd);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Diagnosis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Diagnosis";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxDiagnosisPatientName;
        private TextBox textBoxPatientName;
        private TextBox textBoxDiagnosisID;
        private Panel panel1;
        private Panel panel3;
        private TextBox textBoxPatientID;
        private Panel panel4;
        private Label label5;
        private Button buttonLogout;
        private Button buttonMedicine;
        private Button buttonPatient;
        private Button buttonDiagnosis;
        private Button buttonDoctor;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Label label4;
        private Panel panel5;
        private Label label6;
        private TextBox textBoxDiagnosis;
        private Panel panel6;
        private Label label7;
        private TextBox textBoxSymptoms;
        private Button buttonMedicineDelete;
        private Button buttonMedicineAdd;
        private DataGridView dataGridView1;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}