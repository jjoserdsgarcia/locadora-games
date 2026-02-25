using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using ProjetoWindowsForms___Senac.Classes;
using ProjetoWindowsForms___Senac.Repositories.RepoUser;

namespace ProjetoWindowsForms___Senac
{
    using System.ComponentModel.DataAnnotations;
    using System.Net.Mail;
    using System.Runtime.CompilerServices;
    using System.Text;

    public partial class TelaCadastroUsuario : Form
    {
        private readonly DgvTelaADMIN dgvTelaADMIN;



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

        private async void BtnSalvarCadastroUser(object sender, EventArgs e)
        {
            var usuario = new Usuario();
            usuario.Nome = txtNomeCadastroUser.Text;
            usuario.CPF = txtCPFCadastroUser.Text;
            usuario.Email = txtEmailCadastroUser.Text;
            usuario.Telefone = txtTelefoneCadastroUser.Text;
            usuario.DataNascimento = DateTime.Now;

            var stringBuilder = new StringBuilder();
            var ListaDeErros = new List<ValidationResult>();

           
           

            var contexto = new ValidationContext(usuario);
            Validator.TryValidateObject(usuario, contexto, ListaDeErros, true);


            if (ListaDeErros.Count > 0)
            {
                foreach (var erro in ListaDeErros)
                {
                    stringBuilder.Append(erro.ErrorMessage + "\n");
                }

            }
            else
            {


                // Salvar na Lista

                RepositorioUsuario.SalvarUsuario(usuario);

                await this.dgvTelaADMIN.atualizartabelaadmindgv();

                this.Close();

            }
        }

        private void btnCancelarCadUsuario(object sender, EventArgs e)
        {

            Close();
        }

        private void CadastroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void txtCPFCadastroUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
