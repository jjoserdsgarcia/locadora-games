namespace ProjetoWindowsForms___Senac
{
    public partial class FPage : Form
    {
        public FPage()
        {
            InitializeComponent();
        }

        private void FPage_Load(object sender, EventArgs e)
        {

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            var  LoginUSER = new LoginUSER();
            this.Hide();
            LoginUSER.ShowDialog();
            this.Show();
        }

        private void btnAdm_Click(object sender, EventArgs e)
        {
            var LoginADM = new LoginADM();
            this.Hide();
            LoginADM.ShowDialog();
            this.Show();
        }
    }
}
