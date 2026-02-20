using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using ProjetoWindowsForms___Senac.Classes;
using ProjetoWindowsForms___Senac.Repositories.RepoUser;

namespace ProjetoWindowsForms___Senac
{
    public partial class CadastroUsuario : Form
    {

        private List<Usuario> usuarios = new List<Usuario>();
        public CadastroUsuario()
        {
            InitializeComponent();
        }

        private async Task btnSalvarCadastroUser(object sender, EventArgs e)
        {
            string nome = txtNomeCadastroUser.Text;
            string cpf = txtCPFCadastroUser.Text;
            string email = txtEmailCadastroUser.Text;
            string telefone = txtTelefoneCadastroUser.Text;
            DateTime dataNascimento = dtpData.Value;

            Usuario novoUsuario = new Usuario
            {
               Nome = nome,
               CPF = cpf,
               Email = email,
               Telefone = telefone,
               DataNascimento = dataNascimento
            };

            RepositoryUser.SalvarUsuario(novoUsuario);
            
            MessageBox.Show($"Um novo usuário foi cadastrado!");
        }
    }
}
