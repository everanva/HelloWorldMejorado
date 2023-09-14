using HelloWorldMejorado.formas;

namespace HelloWorldMejorado
{
    public partial class FormaLogin : Form
    {
        public FormaLogin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            FormaHome formaHome = new FormaHome();
            Hide();
            formaHome.Show();
        }
    }
}