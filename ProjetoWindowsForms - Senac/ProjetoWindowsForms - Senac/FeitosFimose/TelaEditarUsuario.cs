using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoWindowsForms___Senac.Classes;
using ProjetoWindowsForms___Senac.Repositories.RepoUser;

namespace ProjetoWindowsForms___Senac
{
    public partial class TelaEditarUsuario : Form
    {
        private int _usuarioId;
        public TelaEditarUsuario(Usuario usuario)
        {
            InitializeComponent();

            _usuarioId = usuario.UsuarioID;

            lblEditandoUsuario.Text = $"Editando: {usuario.Nome}";

<<<<<<< HEAD
            
=======
>>>>>>> b12447c45db917e1fa63f23d1b1c76d286cc71ab
            txtNomeEditUsuario.Text = usuario.Nome;
            txtEmailEditUsuario.Text = usuario.Email;
            txtTelefoneEditUsuario.Text = usuario.Telefone;
        }

        private void btnCancelarEditarUsuario(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnSalvarEditUsuario(object sender, EventArgs e)
        {
            Usuario usuarioAtualizado = new Usuario
            {
                UsuarioID = _usuarioId,
                Nome = txtNomeEditUsuario.Text,
                Email = txtEmailEditUsuario.Text,
                Telefone = txtTelefoneEditUsuario.Text
            };

            await RepositorioUsuario.Atualizar(usuarioAtualizado);

            MessageBox.Show("Usuário atualizado com sucesso!");
            LimparCampos();
            Close();
        }
        private void LimparCampos()
        {
<<<<<<< HEAD
            txtNomeEditUsuario.Clear();
            txtEmailEditUsuario.Clear();
            txtTelefoneEditUsuario.Clear();
            
        }

        private void txtIdEditUsuario_TextChanged(object sender, EventArgs e)
        {

=======
              txtNomeEditUsuario.Clear();
              txtEmailEditUsuario.Clear();
              txtTelefoneEditUsuario.Clear();
>>>>>>> b12447c45db917e1fa63f23d1b1c76d286cc71ab
        }
    }
}

