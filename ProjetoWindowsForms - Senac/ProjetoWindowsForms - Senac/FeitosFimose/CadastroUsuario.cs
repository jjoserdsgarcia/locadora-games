using Microsoft.VisualBasic.ApplicationServices;

namespace ProjetoWindowsForms___Senac
{
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnSalvarCadastroUser(object sender, EventArgs e)
        {
            string nome = txtNomeCadastroUser.Text;
            string cpf = txtCPFCadastroUser.Text;
            string email = txtEmailCadastroUser.Text;
            string telefone = txtTelefoneCadastroUser.Text;
            string data = txtDataCadastroUser.Text;

            User novoUsuario = new User
            {
                Nome = nome,
                CPF = cpf,
                Email = email,


            };
        }
    }
}
