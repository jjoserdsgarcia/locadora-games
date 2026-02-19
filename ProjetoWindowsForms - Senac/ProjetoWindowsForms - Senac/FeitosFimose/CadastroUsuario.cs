using Microsoft.VisualBasic.ApplicationServices;
using ProjetoWindowsForms___Senac.Classes;

namespace ProjetoWindowsForms___Senac
{
    public partial class CadastroUsuario : Form
    {

        private List<Usuario> usuarios = new List<Usuario>();
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

            Usuario novoUsuario = new Usuario
            {
               Nome = nome,
               CPF = cpf,
               Email = email,
               Telefone = telefone,
               Data = data
            };

            usuarios.Add(novoUsuario);
            MessageBox.Show($"Um novo usuário foi cadastrado!");
        }
    }
}
