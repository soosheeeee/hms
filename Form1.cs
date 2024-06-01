namespace Hosp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            ProgressBar1.Value = startpoint;
            if (ProgressBar1.Value == 100)
            {
                ProgressBar1.Value = 0;
                Timer1.Stop();
                User_Login Page = new User_Login();
                Page.Show();
                this.Hide();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
