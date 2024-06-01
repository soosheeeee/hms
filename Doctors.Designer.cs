namespace Hosp
{
    partial class Doctors
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctors));
            label2 = new Label();
            DGVDoctor = new DataGridView();
            textBoxDoctorID = new TextBox();
            label3 = new Label();
            panel3 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            buttonLogout = new Button();
            buttonMedicine = new Button();
            buttonPatients = new Button();
            buttonDiagnosis = new Button();
            button5 = new Button();
            panel1 = new Panel();
            label4 = new Label();
            textBoxDoctorName = new TextBox();
            panel2 = new Panel();
            label5 = new Label();
            textBoxDoctorPassword = new TextBox();
            pictureBox1 = new PictureBox();
            buttonDelete = new Button();
            buttonAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)DGVDoctor).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(562, 38);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 29);
            label2.TabIndex = 27;
            label2.Text = "Doctors";
            // 
            // DGVDoctor
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new Font("Bahnschrift", 10F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 128, 0);
            DGVDoctor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DGVDoctor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVDoctor.BackgroundColor = Color.FromArgb(240, 237, 212);
            DGVDoctor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new Font("Bahnschrift", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGVDoctor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGVDoctor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Bahnschrift", 10F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DGVDoctor.DefaultCellStyle = dataGridViewCellStyle3;
            DGVDoctor.GridColor = Color.Black;
            DGVDoctor.Location = new Point(229, 303);
            DGVDoctor.Margin = new Padding(4);
            DGVDoctor.Name = "DGVDoctor";
            DGVDoctor.ReadOnly = true;
            DGVDoctor.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Bahnschrift", 10F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DGVDoctor.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DGVDoctor.RowHeadersVisible = false;
            DGVDoctor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVDoctor.Size = new Size(764, 450);
            DGVDoctor.TabIndex = 31;
            DGVDoctor.CellContentClick += DGVDoctor_CellContentClick;
            // 
            // textBoxDoctorID
            // 
            textBoxDoctorID.BackColor = Color.FromArgb(240, 237, 212);
            textBoxDoctorID.BorderStyle = BorderStyle.None;
            textBoxDoctorID.Font = new Font("Bahnschrift", 9.75F);
            textBoxDoctorID.Location = new Point(86, 15);
            textBoxDoctorID.Margin = new Padding(4);
            textBoxDoctorID.Name = "textBoxDoctorID";
            textBoxDoctorID.Size = new Size(124, 16);
            textBoxDoctorID.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(229, 279);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(99, 19);
            label3.TabIndex = 30;
            label3.Text = "Doctor's List";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(240, 237, 212);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(textBoxDoctorID);
            panel3.Location = new Point(229, 144);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(224, 50);
            panel3.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 9.75F);
            label1.Location = new Point(9, 6);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 16);
            label1.TabIndex = 34;
            label1.Text = "Doctor ID";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(220, 95, 0);
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(buttonLogout);
            panel4.Controls.Add(buttonMedicine);
            panel4.Controls.Add(buttonPatients);
            panel4.Controls.Add(buttonDiagnosis);
            panel4.Controls.Add(button5);
            panel4.Dock = DockStyle.Left;
            panel4.Font = new Font("Arial Rounded MT Bold", 12F);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 768);
            panel4.TabIndex = 33;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(73, 38);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 74);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
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
            buttonMedicine.Click += buttonMedicine_Click;
            // 
            // buttonPatients
            // 
            buttonPatients.FlatAppearance.BorderColor = Color.FromArgb(220, 95, 0);
            buttonPatients.FlatStyle = FlatStyle.Flat;
            buttonPatients.Font = new Font("Bahnschrift", 12F);
            buttonPatients.ForeColor = Color.White;
            buttonPatients.Location = new Point(4, 191);
            buttonPatients.Margin = new Padding(4);
            buttonPatients.Name = "buttonPatients";
            buttonPatients.Size = new Size(190, 39);
            buttonPatients.TabIndex = 7;
            buttonPatients.Text = "Patients";
            buttonPatients.UseVisualStyleBackColor = true;
            buttonPatients.Click += buttonPatients_Click;
            // 
            // buttonDiagnosis
            // 
            buttonDiagnosis.FlatAppearance.BorderColor = Color.FromArgb(220, 95, 0);
            buttonDiagnosis.FlatStyle = FlatStyle.Flat;
            buttonDiagnosis.Font = new Font("Bahnschrift", 12F);
            buttonDiagnosis.ForeColor = Color.White;
            buttonDiagnosis.Location = new Point(9, 237);
            buttonDiagnosis.Margin = new Padding(4);
            buttonDiagnosis.Name = "buttonDiagnosis";
            buttonDiagnosis.Size = new Size(190, 50);
            buttonDiagnosis.TabIndex = 6;
            buttonDiagnosis.Text = "Diagnosis";
            buttonDiagnosis.UseVisualStyleBackColor = true;
            buttonDiagnosis.Click += buttonDiagnosis_Click;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderColor = Color.FromArgb(220, 95, 0);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(6, 144);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(190, 39);
            button5.TabIndex = 5;
            button5.Text = "Doctors";
            button5.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(240, 237, 212);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBoxDoctorName);
            panel1.Location = new Point(472, 144);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 50);
            panel1.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 9.75F);
            label4.Location = new Point(9, 6);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(83, 16);
            label4.TabIndex = 34;
            label4.Text = "Doctor Name";
            // 
            // textBoxDoctorName
            // 
            textBoxDoctorName.BackColor = Color.FromArgb(240, 237, 212);
            textBoxDoctorName.BorderStyle = BorderStyle.None;
            textBoxDoctorName.Font = new Font("Bahnschrift", 9.75F);
            textBoxDoctorName.Location = new Point(110, 15);
            textBoxDoctorName.Margin = new Padding(4);
            textBoxDoctorName.Name = "textBoxDoctorName";
            textBoxDoctorName.Size = new Size(151, 16);
            textBoxDoctorName.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(240, 237, 212);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBoxDoctorPassword);
            panel2.Location = new Point(770, 144);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(224, 50);
            panel2.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 9.75F);
            label5.Location = new Point(9, 6);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(66, 16);
            label5.TabIndex = 34;
            label5.Text = "Password";
            // 
            // textBoxDoctorPassword
            // 
            textBoxDoctorPassword.BackColor = Color.FromArgb(240, 237, 212);
            textBoxDoctorPassword.BorderStyle = BorderStyle.None;
            textBoxDoctorPassword.Font = new Font("Bahnschrift", 9.75F);
            textBoxDoctorPassword.Location = new Point(86, 15);
            textBoxDoctorPassword.Margin = new Padding(4);
            textBoxDoctorPassword.Name = "textBoxDoctorPassword";
            textBoxDoctorPassword.Size = new Size(124, 16);
            textBoxDoctorPassword.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(983, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(220, 95, 0);
            buttonDelete.FlatAppearance.BorderColor = Color.FromArgb(220, 95, 0);
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Bahnschrift", 12F);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(642, 222);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 29);
            buttonDelete.TabIndex = 40;
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
            buttonAdd.Location = new Point(523, 222);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 29);
            buttonAdd.TabIndex = 39;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // Doctors
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 228, 201);
            ClientSize = new Size(1024, 768);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(label2);
            Controls.Add(DGVDoctor);
            Controls.Add(label3);
            Controls.Add(panel3);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Doctors";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doctors";
            ((System.ComponentModel.ISupportInitialize)DGVDoctor).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private DataGridView DGVDoctor;
        private TextBox textBoxDoctorID;
        private Label label3;
        private Panel panel3;
        private Panel panel4;
        private Button buttonLogout;
        private Button buttonMedicine;
        private Button buttonPatients;
        private Button buttonDiagnosis;
        private Button button5;
        private Label label1;
        private Panel panel1;
        private Label label4;
        private TextBox textBoxDoctorName;
        private Panel panel2;
        private Label label5;
        private TextBox textBoxDoctorPassword;
        private PictureBox pictureBox1;
        private Button buttonDelete;
        private Button buttonAdd;
        private PictureBox pictureBox2;
    }
}