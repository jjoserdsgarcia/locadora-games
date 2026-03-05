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
using ProjetoWindowsForms___Senac.Repositórios.RepoLocacaoInfo;

namespace ProjetoWindowsForms___Senac.TELASJOSE
{
    public partial class TelaDetalhesJogo : Form
    {

        public TelaDetalhesJogo(RegistroLocacao locacao)
        {
            InitializeComponent();

            txtNomeDetalhe.Text = locacao.NomeJogo;
            txtClienteDetalhe.Text = locacao.Cliente;
            txtLocacaoDetalhe.Text = locacao.DataLocacao.ToString("dd/MM/yyyy");
            txtEntregaDetalhe.Text = locacao.DataEntrega?.ToString("dd/MM/yyyy") ?? "Não entregue";
            txtStatusDetalhe.Text = locacao.Status;
        }

        private void btnFecharDetalhe(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TelaDetalhesJogo_Load(object sender, EventArgs e)
        {

        }
<<<<<<< HEAD

        private void txtNomeDetalhe_TextChanged(object sender, EventArgs e)
        {

        }
=======
>>>>>>> f250fabb055dae7552cdb501d82d44dd1cafc365
    }
}
