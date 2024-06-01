namespace Hosp
{
    partial class Admin_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Login));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            linkLabelUser = new LinkLabel();
            pictureBox4 = new PictureBox();
            textBoxPassword = new TextBox();
            label2 = new Label();
            textBoxUsername = new TextBox();
            label1 = new Label();
            buttonUserLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(520, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(232, 228, 201);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(linkLabelUser);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxUsername);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonUserLogin);
            panel1.Location = new Point(81, 143);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 409);
            panel1.TabIndex = 37;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(29, 233);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(170, 17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 74);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // linkLabelUser
            // 
            linkLabelUser.AutoSize = true;
            linkLabelUser.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabelUser.LinkColor = Color.Black;
            linkLabelUser.Location = new Point(265, 274);
            linkLabelUser.Name = "linkLabelUser";
            linkLabelUser.Size = new Size(43, 19);
            linkLabelUser.TabIndex = 15;
            linkLabelUser.TabStop = true;
            linkLabelUser.Text = "User";
            linkLabelUser.LinkClicked += linkLabelUser_LinkClicked_1;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(29, 138);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(42, 33);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(232, 228, 201);
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("Bahnschrift", 12F);
            textBoxPassword.Location = new Point(81, 233);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(242, 20);
            textBoxPassword.TabIndex = 4;
            textBoxPassword.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(62, 244);
            label2.Name = "label2";
            label2.Size = new Size(269, 21);
            label2.TabIndex = 3;
            label2.Text = "_____________________________________";
            // 
            // textBoxUsername
            // 
            textBoxUsername.BackColor = Color.FromArgb(232, 228, 201);
            textBoxUsername.BorderStyle = BorderStyle.None;
            textBoxUsername.Font = new Font("Bahnschrift", 12F);
            textBoxUsername.Location = new Point(81, 140);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(242, 20);
            textBoxUsername.TabIndex = 2;
            textBoxUsername.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(62, 150);
            label1.Name = "label1";
            label1.Size = new Size(269, 21);
            label1.TabIndex = 1;
            label1.Text = "_____________________________________";
            // 
            // buttonUserLogin
            // 
            buttonUserLogin.BackColor = Color.FromArgb(220, 95, 0);
            buttonUserLogin.FlatAppearance.BorderColor = Color.FromArgb(232, 228, 201);
            buttonUserLogin.FlatStyle = FlatStyle.Flat;
            buttonUserLogin.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonUserLogin.ForeColor = Color.White;
            buttonUserLogin.Location = new Point(62, 328);
            buttonUserLogin.Name = "buttonUserLogin";
            buttonUserLogin.Size = new Size(264, 45);
            buttonUserLogin.TabIndex = 0;
            buttonUserLogin.Text = "Log in";
            buttonUserLogin.UseVisualStyleBackColor = false;
            buttonUserLogin.Click += buttonUserLogin_Click;
            // 
            // Admin_Login
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 238, 234);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(561, 718);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Admin_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin_Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private LinkLabel linkLabelUser;
        private PictureBox pictureBox4;
        private TextBox textBoxPassword;
        private Label label2;
        private TextBox textBoxUsername;
        private Label label1;
        private Button buttonUserLogin;
    }
}