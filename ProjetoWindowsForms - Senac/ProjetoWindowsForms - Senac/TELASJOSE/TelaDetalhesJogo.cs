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

namespace ProjetoWindowsForms___Senac.TELASJOSE
{
    public partial class TelaDetalhesJogo : Form
    {

        public TelaDetalhesJogo()
        {
            InitializeComponent();
        }

        private void btnFecharDetalhe(object sender, EventArgs e)
        {
            Close();
        }

        private async void TelaDetalhesJogo_Load(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty())
            //{
            //    var usuario = await RepositorioUsuario.ObterPorCPF(CPFUsuario);

            //    if (usuario != null)
            //    {
            //        txtNomeDetalhe.Text = usuario.Nome;
            //        txtClienteDetalhe.Text = usuario.Cliente;
            //        txtTelefoneUsuarioAlugar.Text = usuario.Telefone;
            //    }
            //}

            //if (JogoSelecionado != null)
            //{
            //    txtNomeJogoAlugar.Text = JogoSelecionado.Titulo;
            //    txtCategoriaJogoAlugar.Text = JogoSelecionado.Genero;
            //    txtPlataformaJogoAlugar.Text = JogoSelecionado.Plataforma;
            //}
        }

        private void txtNomeDetalhe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtClienteDetalhe_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
