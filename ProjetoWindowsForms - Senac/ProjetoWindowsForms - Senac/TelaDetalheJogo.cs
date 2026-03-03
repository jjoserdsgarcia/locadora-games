using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoWindowsForms___Senac.Repositories.RepoGamesInfo;

namespace ProjetoWindowsForms___Senac
{
    public partial class TelaDetalheJogo : Form
    {
        private int _idLocacao;
        public TelaDetalheJogo(int Id)
        {
            InitializeComponent();
            _idLocacao = Id;
        }
        private void TelaDetalheJogo_Load(object sender, EventArgs e)
        {
            CarregarInformacoes();
        }

        private void CarregarInformacoes()
        {
            var repo = new RepositorioJogo();
            var dados = repo.ObterDetalhesPorId(_idLocacao);

            if (dados != null)
            {
                txtNomeDetalhe.Text = dados.NomeJogo;
                txtClienteDetalhe.Text = dados.NomeCliente;
                txtLocacaoDetalhe.Text = dados.DataLocacao.ToString("dd/MM/yyyy");
                txtEntregaDetalhe.Text = dados.DataEntrega.ToString("dd/MM/yyyy");
                txtStatusDetalhe.Text = dados.Status;
            }
            else
            {
                MessageBox.Show("Registro não encontrado no banco de dados.");
            }
        }
        
        private void btnFecharDetalhar(object sender, EventArgs e)
        {
            Close();
        }

    }
}
