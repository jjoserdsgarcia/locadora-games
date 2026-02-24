using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using ProjetoWindowsForms___Senac.Classes;
using ProjetoWindowsForms___Senac.Repositories.RepoUser;

namespace ProjetoWindowsForms___Senac
{
    using System.Net.Mail;

    public partial class TelaCadastroUsuario : Form
    {
        private bool emailValido(string email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private List<Usuario> usuarios = new List<Usuario>();
        public TelaCadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnSalvarCadastroUser(object sender, EventArgs e)
        {
            string nome = txtNomeCadastroUser.Text;
            string cpf = txtCPFCadastroUser.Text;
            string email = txtEmailCadastroUser.Text;
            string telefone = txtTelefoneCadastroUser.Text;
            DateTime dataNascimento = dtpData.Value;

            string erros = "";

            if (string.IsNullOrWhiteSpace(nome))
            {
                erros += "• Nome é obrigatório.\n";
            }

            if (string.IsNullOrWhiteSpace(cpf))
            {
                erros += "• CPF é obrigatório.\n";
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                erros += "• Email é obrigatório.\n";
            }
            else if (!emailValido(email)) 
            { 
                erros += "E-Mail inválido. \n";
            }

            if (string.IsNullOrWhiteSpace(telefone))
            {
                erros += "• Telefone é obrigatório.\n";
            }

            if (erros != "")
            {
                MessageBox.Show(erros, "Campos obrigatórios");
                return;
            }

            if (!cpf.All(char.IsDigit))
            {
                MessageBox.Show("CPF deve conter apenas números.");
                txtCPFCadastroUser.Focus();
                return;
            }

            if (cpf.Length != 11)
            {
                MessageBox.Show("CPF deve conter apenas 11 números.");
                txtCPFCadastroUser.Focus();
                return;
            }

            if (telefone.Length != 11)
            {
                MessageBox.Show("Telefone deve conter 11 números com DDD");
                txtTelefoneCadastroUser.Focus();
                return;
            }

            //if (telefone.All(char.IsDigit))
            //{
            //    MessageBox.Show("Telefone deve conter 11 números com DDD.");
            //    txtTelefoneCadastroUser.Focus();
            //    return;
            //}
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
            Close();

        }

        private void btnCancelarCadUsuario(object sender, EventArgs e)
        {
            Close();
        }

        private void CadastroUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
