namespace LibProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text;
            string password = textBox_password.Text;

            if (username == "imad" && password == "1234")
            {
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {
                label_erreur.Text = "username ou mot de passe incorrects!";
                label_erreur.Visible = true;
            }
        }
    }
}