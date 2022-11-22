namespace project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = Username.Text;
            int i = 0;
            int UserAge = Convert.ToInt32(Userage.Text);
            if (UserAge>= 18)
            {
                MessageBox.Show("You are elligible");

            }
            else
            {
                MessageBox.Show("You are not elligible");

            }
            for (i = 0; i < 3; i++)
            {
                MessageBox.Show("Your name is " + userName);
            }
           
        }
    }
}