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
            DateTime dataNascimento = dtpData.Value;

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(cpf) ||
               string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(telefone) )
            {
                MessageBox.Show("Por Favor, Preencha todos os campos!");
                    return;
            }

            Usuario novoUsuario = new Usuario
            {
                Nome = nome,
                CPF = cpf,
                Email = email,
                Telefone = telefone,
                DataNascimento = dataNascimento
            };

            usuarios.Add(novoUsuario);
            MessageBox.Show($"Um novo usuário foi cadastrado!");
            Close();

        }

        private void btnCancelarCadUsuario(object sender, EventArgs e)
        {
            Close();
        }
    }
}
