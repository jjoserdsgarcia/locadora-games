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

namespace ProjetoWindowsForms___Senac.TELAS
{
    public partial class TelaALUGAR : Form
    {
        public Jogo JogoSelecionado { get; set; }
        public Usuario UsuarioSelecionado { get; set; }
        public string CPFUsuario { get; set; }
        ///

        public TelaALUGAR()
        {
            InitializeComponent();
        }

        private void btnALUGARUSUARIO_Click(object sender, EventArgs e)
        {

            if (dtpEntrega.Value.Date <= DateTime.Today)
            {
                MessageBox.Show("Data inválida!");
                return;
            }

            if (JogoSelecionado == null)
            {
                MessageBox.Show("Erro ao carregar jogo.");
                return;
            }

            if (JogoSelecionado.Status == "Alugado")
            {
                MessageBox.Show("Esse jogo já está alugado!");
                return;
            }

            JogoSelecionado.Status = "Alugado";

            MessageBox.Show("Aluguel realizado com sucesso!");

            Close();
        }

        private void btnCANCELARALUGAR_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void TelaALUGAR_Load(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(CPFUsuario))
            {
                var usuario = await RepositorioUsuario.ObterPorCPF(CPFUsuario);

                if (usuario != null)
                {
                    txtNomeUsuarioAlugar.Text = usuario.Nome;
                    txtCpfUsuarioAlugar.Text = usuario.CPF;
                    txtTelefoneUsuarioAlugar.Text = usuario.Telefone;
                }
            }

            if (JogoSelecionado != null)
            {
                txtNomeJogoAlugar.Text = JogoSelecionado.Titulo;
                txtCategoriaJogoAlugar.Text = JogoSelecionado.Genero;
                txtPlataformaJogoAlugar.Text = JogoSelecionado.Plataforma;
                txtValorJogoAlugar.Text = JogoSelecionado.Valor.ToString();
            }

            dtpEntrega.MinDate = DateTime.Today.AddDays(1);

            txtNomeUsuarioAlugar.ReadOnly = true;
            txtCpfUsuarioAlugar.ReadOnly = true;
            txtTelefoneUsuarioAlugar.ReadOnly = true;
            ///
            txtNomeJogoAlugar.ReadOnly = true;
            txtCategoriaJogoAlugar.ReadOnly = true;
            txtPlataformaJogoAlugar.ReadOnly = true;
            txtValorJogoAlugar.ReadOnly = true;
        }

        private void txtCpfUsuarioAlugar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
