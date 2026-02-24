using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoWindowsForms___Senac
{
    public partial class EditarUsuario : Form
    {
        public EditarUsuario()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {

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
    }
}
