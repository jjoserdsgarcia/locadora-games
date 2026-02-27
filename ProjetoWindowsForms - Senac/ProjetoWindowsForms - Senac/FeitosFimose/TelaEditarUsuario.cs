using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoWindowsForms___Senac.Repositories.RepoUser;

namespace ProjetoWindowsForms___Senac
{
    public partial class TelaEditarUsuario : Form
    {
        public TelaEditarUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelarEditarUsuario(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvarEditUsuario(object sender, EventArgs e)
        {
            string nomeUsuarioEditado = txtNomeEditUsuario.Text;
            string emailUsuarioEditado = txtEmailEditUsuario.Text;
            string telefoneUsuarioEditado = txtTelefoneEditUsuario.Text;

            MessageBox.Show("Usuário atualizado com sucesso!");
            Close();
        }

        private async void btnBuscarUsuarioEdit(object sender, EventArgs e)
        {
            string termo = txtBuscarUsuarioEditar.Text;

            if (string.IsNullOrWhiteSpace(termo))
            {
                MessageBox.Show("Digite um ID ou E-mail para buscar.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            var usuario = await RepositorioUsuario.BuscarPorTermo(termo);

            if (usuario != null)
            {
                txtNomeEditUsuario.Text = usuario.Nome;
                txtEmailEditUsuario.Text = usuario.Email;
                txtTelefoneEditUsuario.Text = usuario.Telefone;
                txtIdEditUsuario.Text = usuario.UsuarioID.ToString();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado.");
                LimparCampos(); 
            }
        }
        private void LimparCampos()
        {
              txtBuscarUsuarioEditar.Clear();
              txtNomeEditUsuario.Clear();
              txtEmailEditUsuario.Clear();
              txtTelefoneEditUsuario.Clear();
              txtIdEditUsuario.Clear();
        }
    }
}

