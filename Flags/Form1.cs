namespace Flags
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBoxFinland_Click(object sender, EventArgs e)
        {
            labelCountry.Text = "Finland";
        }

        private void pictureBoxFrance_Click(object sender, EventArgs e)
        {
            labelCountry.Text = "France";
        }

        private void pictureBoxGermany_Click(object sender, EventArgs e)
        {
            labelCountry.Text = "Germany";
        }
    }
}