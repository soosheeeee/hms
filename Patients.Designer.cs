namespace Hosp
{
    partial class Patients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patients));
            textBoxPatientID = new TextBox();
            DGVPatient = new DataGridView();
            label3 = new Label();
            comboBoxYear = new ComboBox();
            comboBoxDay = new ComboBox();
            comboBoxMonth = new ComboBox();
            comboBoxPatientBloodType = new ComboBox();
            comboBoxPatientSex = new ComboBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            buttonLogout = new Button();
            buttonMedicine = new Button();
            buttonPatient = new Button();
            buttonDiagnosis = new Button();
            buttonDoctor = new Button();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            label5 = new Label();
            textBoxPatientName = new TextBox();
            panel5 = new Panel();
            label6 = new Label();
            textBoxContactInfo = new TextBox();
            panel6 = new Panel();
            label7 = new Label();
            textBoxPatientAge = new TextBox();
            panel7 = new Panel();
            label8 = new Label();
            textBoxPatientAddress = new TextBox();
            panel8 = new Panel();
            label9 = new Label();
            textBoxReligion = new TextBox();
            panel9 = new Panel();
            label10 = new Label();
            panel10 = new Panel();
            label11 = new Label();
            panel11 = new Panel();
            label12 = new Label();
            panel12 = new Panel();
            label13 = new Label();
            textBoxWardNo = new TextBox();
            panel13 = new Panel();
            label4 = new Label();
            comboBoxYearBday = new ComboBox();
            comboBoxDayBday = new ComboBox();
            comboBoxMonthBday = new ComboBox();
            panel14 = new Panel();
            label14 = new Label();
            textBoxHistory = new TextBox();
            panel15 = new Panel();
            label15 = new Label();
            textBoxPreviously = new TextBox();
            pictureBox1 = new PictureBox();
            buttonDelete = new Button();
            buttonAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)DGVPatient).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            panel14.SuspendLayout();
            panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxPatientID
            // 
            textBoxPatientID.BackColor = Color.FromArgb(240, 237, 212);
            textBoxPatientID.BorderStyle = BorderStyle.None;
            textBoxPatientID.Font = new Font("Bahnschrift", 9.75F);
            textBoxPatientID.Location = new Point(85, 15);
            textBoxPatientID.Margin = new Padding(4);
            textBoxPatientID.Name = "textBoxPatientID";
            textBoxPatientID.Size = new Size(105, 16);
            textBoxPatientID.TabIndex = 1;
            // 
            // DGVPatient
            // 
            DGVPatient.BackgroundColor = Color.FromArgb(240, 237, 212);
            DGVPatient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVPatient.Location = new Point(223, 395);
            DGVPatient.Margin = new Padding(4);
            DGVPatient.Name = "DGVPatient";
            DGVPatient.Size = new Size(773, 352);
            DGVPatient.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(222, 372);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(101, 19);
            label3.TabIndex = 24;
            label3.Text = "Patient's List";
            // 
            // comboBoxYear
            // 
            comboBoxYear.BackColor = Color.White;
            comboBoxYear.Font = new Font("Bahnschrift", 9.75F);
            comboBoxYear.FormattingEnabled = true;
            comboBoxYear.Items.AddRange(new object[] { "2024", "2025", "2026", "2027", "2028", "2029", "2030" });
            comboBoxYear.Location = new Point(226, 10);
            comboBoxYear.Name = "comboBoxYear";
            comboBoxYear.Size = new Size(68, 24);
            comboBoxYear.TabIndex = 16;
            comboBoxYear.Text = "Year";
            // 
            // comboBoxDay
            // 
            comboBoxDay.BackColor = Color.White;
            comboBoxDay.Font = new Font("Bahnschrift", 9.75F);
            comboBoxDay.FormattingEnabled = true;
            comboBoxDay.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            comboBoxDay.Location = new Point(163, 10);
            comboBoxDay.Name = "comboBoxDay";
            comboBoxDay.Size = new Size(53, 24);
            comboBoxDay.TabIndex = 15;
            comboBoxDay.Text = "Day";
            // 
            // comboBoxMonth
            // 
            comboBoxMonth.BackColor = Color.White;
            comboBoxMonth.Font = new Font("Bahnschrift", 9.75F);
            comboBoxMonth.FormattingEnabled = true;
            comboBoxMonth.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            comboBoxMonth.Location = new Point(95, 10);
            comboBoxMonth.Name = "comboBoxMonth";
            comboBoxMonth.Size = new Size(62, 24);
            comboBoxMonth.TabIndex = 14;
            comboBoxMonth.Text = "Month";
            // 
            // comboBoxPatientBloodType
            // 
            comboBoxPatientBloodType.AutoCompleteCustomSource.AddRange(new string[] { "A+", "B+", "AB+", "O+", "A-", "B-", "AB-", "O-", "Other" });
            comboBoxPatientBloodType.BackColor = Color.White;
            comboBoxPatientBloodType.FlatStyle = FlatStyle.Flat;
            comboBoxPatientBloodType.Font = new Font("Bahnschrift", 9.75F);
            comboBoxPatientBloodType.FormattingEnabled = true;
            comboBoxPatientBloodType.Items.AddRange(new object[] { "A+", "B+", "AB+", "O+", "A-", "B-", "AB-", "O-", "Other" });
            comboBoxPatientBloodType.Location = new Point(86, 10);
            comboBoxPatientBloodType.Margin = new Padding(4);
            comboBoxPatientBloodType.Name = "comboBoxPatientBloodType";
            comboBoxPatientBloodType.Size = new Size(97, 24);
            comboBoxPatientBloodType.TabIndex = 11;
            // 
            // comboBoxPatientSex
            // 
            comboBoxPatientSex.AutoCompleteCustomSource.AddRange(new string[] { "Male", "Female" });
            comboBoxPatientSex.BackColor = Color.White;
            comboBoxPatientSex.Font = new Font("Bahnschrift", 9.75F);
            comboBoxPatientSex.FormattingEnabled = true;
            comboBoxPatientSex.Items.AddRange(new object[] { "Male", "Female" });
            comboBoxPatientSex.Location = new Point(43, 11);
            comboBoxPatientSex.Margin = new Padding(4);
            comboBoxPatientSex.Name = "comboBoxPatientSex";
            comboBoxPatientSex.Size = new Size(78, 24);
            comboBoxPatientSex.TabIndex = 9;
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
            panel1.TabIndex = 26;
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
            buttonLogout.Location = new Point(4, 695);
            buttonLogout.Margin = new Padding(4);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(190, 52);
            buttonLogout.TabIndex = 9;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click_1;
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
            buttonMedicine.Click += buttonMedicine_Click_1;
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
            buttonDiagnosis.Click += buttonDiagnosis_Click_1;
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
            buttonDoctor.Click += buttonDoctor_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(533, 34);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(169, 29);
            label2.TabIndex = 28;
            label2.Text = "Patient Details";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(240, 237, 212);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBoxPatientID);
            panel2.Location = new Point(222, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 47);
            panel2.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 9.75F);
            label1.Location = new Point(8, 7);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 16);
            label1.TabIndex = 30;
            label1.Text = "Patient ID";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(240, 237, 212);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(textBoxPatientName);
            panel4.Location = new Point(440, 83);
            panel4.Name = "panel4";
            panel4.Size = new Size(273, 47);
            panel4.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 9.75F);
            label5.Location = new Point(8, 7);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(84, 16);
            label5.TabIndex = 30;
            label5.Text = "Patient Name";
            // 
            // textBoxPatientName
            // 
            textBoxPatientName.BackColor = Color.FromArgb(240, 237, 212);
            textBoxPatientName.BorderStyle = BorderStyle.None;
            textBoxPatientName.Font = new Font("Bahnschrift", 9.75F);
            textBoxPatientName.Location = new Point(108, 15);
            textBoxPatientName.Margin = new Padding(4);
            textBoxPatientName.Name = "textBoxPatientName";
            textBoxPatientName.Size = new Size(158, 16);
            textBoxPatientName.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(240, 237, 212);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(textBoxContactInfo);
            panel5.Location = new Point(723, 83);
            panel5.Name = "panel5";
            panel5.Size = new Size(273, 47);
            panel5.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 9.75F);
            label6.Location = new Point(8, 7);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(72, 16);
            label6.TabIndex = 30;
            label6.Text = "Contact No.";
            // 
            // textBoxContactInfo
            // 
            textBoxContactInfo.BackColor = Color.FromArgb(240, 237, 212);
            textBoxContactInfo.BorderStyle = BorderStyle.None;
            textBoxContactInfo.Font = new Font("Bahnschrift", 9.75F);
            textBoxContactInfo.Location = new Point(92, 15);
            textBoxContactInfo.Margin = new Padding(4);
            textBoxContactInfo.Name = "textBoxContactInfo";
            textBoxContactInfo.Size = new Size(175, 16);
            textBoxContactInfo.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(240, 237, 212);
            panel6.Controls.Add(label7);
            panel6.Controls.Add(textBoxPatientAge);
            panel6.Location = new Point(222, 140);
            panel6.Name = "panel6";
            panel6.Size = new Size(118, 47);
            panel6.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift", 9.75F);
            label7.Location = new Point(8, 7);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(29, 16);
            label7.TabIndex = 30;
            label7.Text = "Age";
            // 
            // textBoxPatientAge
            // 
            textBoxPatientAge.BackColor = Color.FromArgb(240, 237, 212);
            textBoxPatientAge.BorderStyle = BorderStyle.None;
            textBoxPatientAge.Font = new Font("Bahnschrift", 9.75F);
            textBoxPatientAge.Location = new Point(44, 15);
            textBoxPatientAge.Margin = new Padding(4);
            textBoxPatientAge.Name = "textBoxPatientAge";
            textBoxPatientAge.Size = new Size(62, 16);
            textBoxPatientAge.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(240, 237, 212);
            panel7.Controls.Add(label8);
            panel7.Controls.Add(textBoxPatientAddress);
            panel7.Location = new Point(351, 140);
            panel7.Name = "panel7";
            panel7.Size = new Size(294, 47);
            panel7.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift", 9.75F);
            label8.Location = new Point(7, 6);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(99, 16);
            label8.TabIndex = 30;
            label8.Text = "Patient Address";
            // 
            // textBoxPatientAddress
            // 
            textBoxPatientAddress.BackColor = Color.FromArgb(240, 237, 212);
            textBoxPatientAddress.BorderStyle = BorderStyle.None;
            textBoxPatientAddress.Font = new Font("Bahnschrift", 9.75F);
            textBoxPatientAddress.Location = new Point(126, 14);
            textBoxPatientAddress.Margin = new Padding(4);
            textBoxPatientAddress.Name = "textBoxPatientAddress";
            textBoxPatientAddress.Size = new Size(153, 16);
            textBoxPatientAddress.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(240, 237, 212);
            panel8.Controls.Add(label9);
            panel8.Controls.Add(textBoxReligion);
            panel8.Location = new Point(655, 140);
            panel8.Name = "panel8";
            panel8.Size = new Size(200, 47);
            panel8.TabIndex = 33;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bahnschrift", 9.75F);
            label9.Location = new Point(8, 7);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(53, 16);
            label9.TabIndex = 30;
            label9.Text = "Religion";
            // 
            // textBoxReligion
            // 
            textBoxReligion.BackColor = Color.FromArgb(240, 237, 212);
            textBoxReligion.BorderStyle = BorderStyle.None;
            textBoxReligion.Font = new Font("Bahnschrift", 9.75F);
            textBoxReligion.Location = new Point(76, 15);
            textBoxReligion.Margin = new Padding(4);
            textBoxReligion.Name = "textBoxReligion";
            textBoxReligion.Size = new Size(105, 16);
            textBoxReligion.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(240, 237, 212);
            panel9.Controls.Add(label10);
            panel9.Controls.Add(comboBoxPatientSex);
            panel9.Location = new Point(864, 140);
            panel9.Name = "panel9";
            panel9.Size = new Size(132, 47);
            panel9.TabIndex = 34;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bahnschrift", 9.75F);
            label10.Location = new Point(4, 6);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(29, 16);
            label10.TabIndex = 30;
            label10.Text = "Sex";
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(240, 237, 212);
            panel10.Controls.Add(label11);
            panel10.Controls.Add(comboBoxPatientBloodType);
            panel10.Location = new Point(222, 197);
            panel10.Name = "panel10";
            panel10.Size = new Size(190, 47);
            panel10.TabIndex = 32;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Bahnschrift", 9.75F);
            label11.Location = new Point(6, 6);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(69, 16);
            label11.TabIndex = 30;
            label11.Text = "Blood Type";
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(240, 237, 212);
            panel11.Controls.Add(label12);
            panel11.Controls.Add(comboBoxYear);
            panel11.Controls.Add(comboBoxMonth);
            panel11.Controls.Add(comboBoxDay);
            panel11.Location = new Point(422, 197);
            panel11.Name = "panel11";
            panel11.Size = new Size(305, 47);
            panel11.TabIndex = 32;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Bahnschrift", 9.75F);
            label12.Location = new Point(6, 6);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(76, 16);
            label12.TabIndex = 30;
            label12.Text = "Date of Visit";
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(240, 237, 212);
            panel12.Controls.Add(label13);
            panel12.Controls.Add(textBoxWardNo);
            panel12.Location = new Point(222, 254);
            panel12.Name = "panel12";
            panel12.Size = new Size(167, 47);
            panel12.TabIndex = 32;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Bahnschrift", 9.75F);
            label13.Location = new Point(8, 7);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(60, 16);
            label13.TabIndex = 30;
            label13.Text = "Ward No.";
            // 
            // textBoxWardNo
            // 
            textBoxWardNo.BackColor = Color.FromArgb(240, 237, 212);
            textBoxWardNo.BorderStyle = BorderStyle.None;
            textBoxWardNo.Font = new Font("Bahnschrift", 9.75F);
            textBoxWardNo.Location = new Point(82, 15);
            textBoxWardNo.Margin = new Padding(4);
            textBoxWardNo.Name = "textBoxWardNo";
            textBoxWardNo.Size = new Size(72, 16);
            textBoxWardNo.TabIndex = 1;
            // 
            // panel13
            // 
            panel13.BackColor = Color.FromArgb(240, 237, 212);
            panel13.Controls.Add(label4);
            panel13.Controls.Add(comboBoxYearBday);
            panel13.Controls.Add(comboBoxDayBday);
            panel13.Controls.Add(comboBoxMonthBday);
            panel13.Location = new Point(733, 197);
            panel13.Name = "panel13";
            panel13.Size = new Size(263, 47);
            panel13.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 9.75F);
            label4.Location = new Point(5, 5);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 16);
            label4.TabIndex = 30;
            label4.Text = "Birthday";
            // 
            // comboBoxYearBday
            // 
            comboBoxYearBday.BackColor = Color.White;
            comboBoxYearBday.Font = new Font("Bahnschrift", 9.75F);
            comboBoxYearBday.FormattingEnabled = true;
            comboBoxYearBday.Items.AddRange(new object[] { "2024", "2025", "2026", "2027", "2028", "2029", "2030" });
            comboBoxYearBday.Location = new Point(198, 10);
            comboBoxYearBday.Name = "comboBoxYearBday";
            comboBoxYearBday.Size = new Size(57, 24);
            comboBoxYearBday.TabIndex = 16;
            comboBoxYearBday.Text = "Year";
            // 
            // comboBoxDayBday
            // 
            comboBoxDayBday.BackColor = Color.White;
            comboBoxDayBday.Font = new Font("Bahnschrift", 9.75F);
            comboBoxDayBday.FormattingEnabled = true;
            comboBoxDayBday.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            comboBoxDayBday.Location = new Point(142, 10);
            comboBoxDayBday.Name = "comboBoxDayBday";
            comboBoxDayBday.Size = new Size(50, 24);
            comboBoxDayBday.TabIndex = 15;
            comboBoxDayBday.Text = "Day";
            // 
            // comboBoxMonthBday
            // 
            comboBoxMonthBday.BackColor = Color.White;
            comboBoxMonthBday.Font = new Font("Bahnschrift", 9.75F);
            comboBoxMonthBday.FormattingEnabled = true;
            comboBoxMonthBday.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            comboBoxMonthBday.Location = new Point(74, 10);
            comboBoxMonthBday.Name = "comboBoxMonthBday";
            comboBoxMonthBday.Size = new Size(62, 24);
            comboBoxMonthBday.TabIndex = 14;
            comboBoxMonthBday.Text = "Month";
            // 
            // panel14
            // 
            panel14.BackColor = Color.FromArgb(240, 237, 212);
            panel14.Controls.Add(label14);
            panel14.Controls.Add(textBoxHistory);
            panel14.Location = new Point(222, 309);
            panel14.Name = "panel14";
            panel14.Size = new Size(774, 47);
            panel14.TabIndex = 32;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Bahnschrift", 9.75F);
            label14.Location = new Point(8, 7);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(127, 16);
            label14.TabIndex = 30;
            label14.Text = "History of Diagnosed";
            // 
            // textBoxHistory
            // 
            textBoxHistory.BackColor = Color.FromArgb(240, 237, 212);
            textBoxHistory.BorderStyle = BorderStyle.None;
            textBoxHistory.Font = new Font("Bahnschrift", 9.75F);
            textBoxHistory.Location = new Point(157, 13);
            textBoxHistory.Margin = new Padding(4);
            textBoxHistory.Name = "textBoxHistory";
            textBoxHistory.Size = new Size(606, 16);
            textBoxHistory.TabIndex = 1;
            // 
            // panel15
            // 
            panel15.BackColor = Color.FromArgb(240, 237, 212);
            panel15.Controls.Add(label15);
            panel15.Controls.Add(textBoxPreviously);
            panel15.Location = new Point(395, 254);
            panel15.Name = "panel15";
            panel15.Size = new Size(601, 47);
            panel15.TabIndex = 33;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Bahnschrift", 9.75F);
            label15.Location = new Point(8, 7);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(156, 16);
            label15.TabIndex = 30;
            label15.Text = "Previously Suffered From";
            // 
            // textBoxPreviously
            // 
            textBoxPreviously.BackColor = Color.FromArgb(240, 237, 212);
            textBoxPreviously.BorderStyle = BorderStyle.None;
            textBoxPreviously.Font = new Font("Bahnschrift", 9.75F);
            textBoxPreviously.Location = new Point(186, 15);
            textBoxPreviously.Margin = new Padding(4);
            textBoxPreviously.Name = "textBoxPreviously";
            textBoxPreviously.Size = new Size(404, 16);
            textBoxPreviously.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(967, 12);
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
            buttonDelete.Font = new Font("Bahnschrift", 11.25F);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(636, 362);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 26);
            buttonDelete.TabIndex = 42;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(220, 95, 0);
            buttonAdd.FlatAppearance.BorderColor = Color.FromArgb(220, 95, 0);
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Bahnschrift", 11.25F);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(517, 362);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 26);
            buttonAdd.TabIndex = 41;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // Patients
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 228, 201);
            ClientSize = new Size(1024, 768);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(pictureBox1);
            Controls.Add(panel15);
            Controls.Add(panel14);
            Controls.Add(panel13);
            Controls.Add(panel12);
            Controls.Add(panel11);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(DGVPatient);
            Controls.Add(label3);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Patients";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patients";
            ((System.ComponentModel.ISupportInitialize)DGVPatient).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxPatientID;
        private DataGridView DGVPatient;
        private Label label3;
        private Panel panel3;
        private TextBox textBoxPatientReligion;
        private ComboBox comboBoxPatientBloodType;
        private ComboBox comboBoxPatientSex;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Button buttonAdd;
        private TextBox textBoxPatientAge;
        private Panel panel7;
        private Label label8;
        private TextBox textBoxPatientAddress;
        private Panel panel8;
        private Label label9;
        private TextBox textBoxReligion;
        private Panel panel9;
        private Label label10;
        private ComboBox comboBoxYear;
        private ComboBox comboBoxDay;
        private ComboBox comboBoxMonth;
        private Panel panel1;
        private Button buttonLogout;
        private Button buttonMedicine;
        private Button buttonPatient;
        private Button buttonDiagnosis;
        private Button buttonDoctor;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private Panel panel4;
        private Label label5;
        private TextBox textBoxPatientName;
        private Panel panel5;
        private Label label6;
        private TextBox textBoxContactInfo;
        private Panel panel6;
        private Label label7;
        private Panel panel10;
        private Label label11;
        private Panel panel11;
        private Label label12;
        private Panel panel12;
        private Label label13;
        private TextBox textBoxWardNo;
        private Panel panel13;
        private Label label4;
        private ComboBox comboBoxYearBday;
        private ComboBox comboBox3;
        private ComboBox comboBoxMonthBday;
        private Panel panel14;
        private Label label14;
        private TextBox textBoxHistory;
        private Panel panel15;
        private Label label15;
        private TextBox textBoxPreviously;
        private ComboBox comboBoxDayBday;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}