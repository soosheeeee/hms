namespace Hosp
{
    partial class Medicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medicine));
            panel1 = new Panel();
            buttonLogout = new Button();
            buttonMedicine = new Button();
            buttonPatient = new Button();
            buttonDiagnosis = new Button();
            buttonDoctor = new Button();
            label1 = new Label();
            panel2 = new Panel();
            textBoxPatientName = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            textBoxDosage = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            textBoxMedicineName = new TextBox();
            label4 = new Label();
            panel5 = new Panel();
            comboBoxType = new ComboBox();
            label5 = new Label();
            DGVMedicine = new DataGridView();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            panel6 = new Panel();
            textBoxPatientID = new TextBox();
            label7 = new Label();
            panel7 = new Panel();
            textBox1 = new TextBox();
            label8 = new Label();
            buttonDelete = new Button();
            buttonAdd = new Button();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVMedicine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
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
            panel1.Font = new Font("Arial Rounded MT Bold", 12F);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 768);
            panel1.TabIndex = 0;
            // 
            // buttonLogout
            // 
            buttonLogout.FlatAppearance.BorderColor = Color.FromArgb(220, 95, 0);
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Font = new Font("Bahnschrift", 12F);
            buttonLogout.ForeColor = Color.White;
            buttonLogout.Location = new Point(6, 713);
            buttonLogout.Margin = new Padding(4);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(190, 52);
            buttonLogout.TabIndex = 9;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // buttonMedicine
            // 
            buttonMedicine.FlatAppearance.BorderColor = Color.FromArgb(220, 95, 0);
            buttonMedicine.FlatStyle = FlatStyle.Flat;
            buttonMedicine.Font = new Font("Bahnschrift", 12F);
            buttonMedicine.ForeColor = Color.White;
            buttonMedicine.Location = new Point(6, 294);
            buttonMedicine.Margin = new Padding(4);
            buttonMedicine.Name = "buttonMedicine";
            buttonMedicine.Size = new Size(190, 39);
            buttonMedicine.TabIndex = 8;
            buttonMedicine.Text = "Medicine";
            buttonMedicine.UseVisualStyleBackColor = true;
            // 
            // buttonPatient
            // 
            buttonPatient.FlatAppearance.BorderColor = Color.FromArgb(220, 95, 0);
            buttonPatient.FlatStyle = FlatStyle.Flat;
            buttonPatient.Font = new Font("Bahnschrift", 12F);
            buttonPatient.ForeColor = Color.White;
            buttonPatient.Location = new Point(5, 191);
            buttonPatient.Margin = new Padding(4);
            buttonPatient.Name = "buttonPatient";
            buttonPatient.Size = new Size(190, 39);
            buttonPatient.TabIndex = 7;
            buttonPatient.Text = "Patients";
            buttonPatient.UseVisualStyleBackColor = true;
            buttonPatient.Click += buttonPatient_Click;
            // 
            // buttonDiagnosis
            // 
            buttonDiagnosis.FlatAppearance.BorderColor = Color.FromArgb(220, 95, 0);
            buttonDiagnosis.FlatStyle = FlatStyle.Flat;
            buttonDiagnosis.Font = new Font("Bahnschrift", 12F);
            buttonDiagnosis.ForeColor = Color.White;
            buttonDiagnosis.Location = new Point(9, 236);
            buttonDiagnosis.Margin = new Padding(4);
            buttonDiagnosis.Name = "buttonDiagnosis";
            buttonDiagnosis.Size = new Size(190, 50);
            buttonDiagnosis.TabIndex = 6;
            buttonDiagnosis.Text = "Diagnosis";
            buttonDiagnosis.UseVisualStyleBackColor = true;
            buttonDiagnosis.Click += buttonDiagnosis_Click;
            // 
            // buttonDoctor
            // 
            buttonDoctor.FlatAppearance.BorderColor = Color.FromArgb(220, 95, 0);
            buttonDoctor.FlatStyle = FlatStyle.Flat;
            buttonDoctor.Font = new Font("Bahnschrift", 12F);
            buttonDoctor.ForeColor = Color.White;
            buttonDoctor.Location = new Point(6, 144);
            buttonDoctor.Margin = new Padding(4);
            buttonDoctor.Name = "buttonDoctor";
            buttonDoctor.Size = new Size(190, 39);
            buttonDoctor.TabIndex = 5;
            buttonDoctor.Text = "Doctors";
            buttonDoctor.UseVisualStyleBackColor = true;
            buttonDoctor.Click += buttonDoctor_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(49, 54, 63);
            label1.Location = new Point(562, 38);
            label1.Name = "label1";
            label1.Size = new Size(108, 29);
            label1.TabIndex = 1;
            label1.Text = "Medicine";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(240, 237, 212);
            panel2.Controls.Add(textBoxPatientName);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(220, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(376, 51);
            panel2.TabIndex = 2;
            // 
            // textBoxPatientName
            // 
            textBoxPatientName.BackColor = Color.FromArgb(240, 237, 212);
            textBoxPatientName.BorderStyle = BorderStyle.None;
            textBoxPatientName.Font = new Font("Bahnschrift", 12F);
            textBoxPatientName.Location = new Point(113, 17);
            textBoxPatientName.Name = "textBoxPatientName";
            textBoxPatientName.Size = new Size(253, 20);
            textBoxPatientName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 9.75F);
            label2.ForeColor = Color.FromArgb(49, 54, 63);
            label2.Location = new Point(12, 10);
            label2.Name = "label2";
            label2.Size = new Size(84, 16);
            label2.TabIndex = 0;
            label2.Text = "Patient Name";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(240, 237, 212);
            panel3.Controls.Add(textBoxDosage);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(821, 169);
            panel3.Name = "panel3";
            panel3.Size = new Size(175, 51);
            panel3.TabIndex = 3;
            // 
            // textBoxDosage
            // 
            textBoxDosage.BackColor = Color.FromArgb(240, 237, 212);
            textBoxDosage.BorderStyle = BorderStyle.None;
            textBoxDosage.Font = new Font("Bahnschrift", 12F);
            textBoxDosage.Location = new Point(73, 16);
            textBoxDosage.Name = "textBoxDosage";
            textBoxDosage.Size = new Size(90, 20);
            textBoxDosage.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 9.75F);
            label3.ForeColor = Color.FromArgb(49, 54, 63);
            label3.Location = new Point(12, 10);
            label3.Name = "label3";
            label3.Size = new Size(51, 16);
            label3.TabIndex = 0;
            label3.Text = "Dosage";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(240, 237, 212);
            panel4.Controls.Add(textBoxMedicineName);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(224, 169);
            panel4.Name = "panel4";
            panel4.Size = new Size(376, 51);
            panel4.TabIndex = 3;
            // 
            // textBoxMedicineName
            // 
            textBoxMedicineName.BackColor = Color.FromArgb(240, 237, 212);
            textBoxMedicineName.BorderStyle = BorderStyle.None;
            textBoxMedicineName.Font = new Font("Bahnschrift", 12F);
            textBoxMedicineName.Location = new Point(133, 16);
            textBoxMedicineName.Name = "textBoxMedicineName";
            textBoxMedicineName.Size = new Size(229, 20);
            textBoxMedicineName.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 9.75F);
            label4.ForeColor = Color.FromArgb(49, 54, 63);
            label4.Location = new Point(12, 10);
            label4.Name = "label4";
            label4.Size = new Size(94, 16);
            label4.TabIndex = 0;
            label4.Text = "Medicine Name";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(240, 237, 212);
            panel5.Controls.Add(comboBoxType);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(606, 169);
            panel5.Name = "panel5";
            panel5.Size = new Size(209, 51);
            panel5.TabIndex = 4;
            // 
            // comboBoxType
            // 
            comboBoxType.BackColor = Color.FromArgb(255, 251, 245);
            comboBoxType.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxType.ForeColor = Color.FromArgb(49, 54, 63);
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Syrup", "Capsule", "Tablet" });
            comboBoxType.Location = new Point(67, 13);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(111, 27);
            comboBoxType.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 9.75F);
            label5.ForeColor = Color.FromArgb(49, 54, 63);
            label5.Location = new Point(12, 10);
            label5.Name = "label5";
            label5.Size = new Size(33, 16);
            label5.TabIndex = 0;
            label5.Text = "Type";
            // 
            // DGVMedicine
            // 
            DGVMedicine.BackgroundColor = Color.FromArgb(240, 237, 212);
            DGVMedicine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVMedicine.Location = new Point(224, 310);
            DGVMedicine.Name = "DGVMedicine";
            DGVMedicine.Size = new Size(774, 439);
            DGVMedicine.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(49, 54, 63);
            label6.Location = new Point(224, 285);
            label6.Name = "label6";
            label6.Size = new Size(134, 23);
            label6.TabIndex = 6;
            label6.Text = "Medicine's List";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(988, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(240, 237, 212);
            panel6.Controls.Add(textBoxPatientID);
            panel6.Controls.Add(label7);
            panel6.Location = new Point(808, 100);
            panel6.Name = "panel6";
            panel6.Size = new Size(190, 51);
            panel6.TabIndex = 4;
            // 
            // textBoxPatientID
            // 
            textBoxPatientID.BackColor = Color.FromArgb(240, 237, 212);
            textBoxPatientID.BorderStyle = BorderStyle.None;
            textBoxPatientID.Font = new Font("Bahnschrift", 12F);
            textBoxPatientID.Location = new Point(86, 17);
            textBoxPatientID.Name = "textBoxPatientID";
            textBoxPatientID.Size = new Size(90, 20);
            textBoxPatientID.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift", 9.75F);
            label7.ForeColor = Color.FromArgb(49, 54, 63);
            label7.Location = new Point(10, 10);
            label7.Name = "label7";
            label7.Size = new Size(63, 16);
            label7.TabIndex = 0;
            label7.Text = "Patient ID";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(240, 237, 212);
            panel7.Controls.Add(textBox1);
            panel7.Controls.Add(label8);
            panel7.Location = new Point(602, 100);
            panel7.Name = "panel7";
            panel7.Size = new Size(200, 51);
            panel7.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(240, 237, 212);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Bahnschrift", 12F);
            textBox1.Location = new Point(81, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(101, 20);
            textBox1.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift", 9.75F);
            label8.ForeColor = Color.FromArgb(49, 54, 63);
            label8.Location = new Point(9, 10);
            label8.Name = "label8";
            label8.Size = new Size(60, 16);
            label8.TabIndex = 0;
            label8.Text = "Ward No.";
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(220, 95, 0);
            buttonDelete.FlatAppearance.BorderColor = Color.FromArgb(220, 95, 0);
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Bahnschrift", 12F);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(642, 247);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 29);
            buttonDelete.TabIndex = 42;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(220, 95, 0);
            buttonAdd.FlatAppearance.BorderColor = Color.FromArgb(220, 95, 0);
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Bahnschrift", 12F);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(523, 247);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 29);
            buttonAdd.TabIndex = 41;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(73, 38);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 74);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // Medicine
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 228, 201);
            ClientSize = new Size(1024, 768);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(DGVMedicine);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Medicine";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Medicine";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVMedicine).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TextBox textBoxPatientName;
        private Label label2;
        private Panel panel3;
        private TextBox textBoxDosage;
        private Label label3;
        private Panel panel4;
        private TextBox textBoxMedicineName;
        private Label label4;
        private Panel panel5;
        private ComboBox comboBoxType;
        private Label label5;
        private DataGridView DGVMedicine;
        private Label label6;
        private PictureBox pictureBox1;
        private Button buttonLogout;
        private Button buttonMedicine;
        private Button buttonPatient;
        private Button buttonDiagnosis;
        private Button buttonDoctor;
        private Panel panel6;
        private TextBox textBoxPatientID;
        private Label label7;
        private Panel panel7;
        private TextBox textBox1;
        private Label label8;
        private Button buttonDelete;
        private Button buttonAdd;
        private PictureBox pictureBox2;
    }
}