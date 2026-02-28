using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoWindowsForms___Senac.Classes;
using ProjetoWindowsForms___Senac.Repositories.RepoGamesInfo;

namespace ProjetoWindowsForms___Senac.TELAS
{

    public partial class TelaPrincipalUsuario : Form
    {
        public Jogo JogoSelecionado { get; set; }

        private readonly string CPFUSUARIO;
        private readonly bool IsADMIN;

        private async void CarregarJogo()
        {
            var jogos = await RepositorioJogo.ObterTodos();
            dgvListaJogos.DataSource = jogos;

            dgvListaJogos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaJogos.MultiSelect = false;
        }


        public TelaPrincipalUsuario(bool IsADMIN, string CPFUSUARIO)

        {
            InitializeComponent();
            this.CPFUSUARIO = CPFUSUARIO;
            this.IsADMIN = IsADMIN;
            CarregarJogo();
        }

        private void btnALUGAR_Click(object sender, EventArgs e)
        {
            if (dgvListaJogos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um jogo!");
                return;
            }

            Jogo jogoSelecionado =
                (Jogo)dgvListaJogos.SelectedRows[0].DataBoundItem;

            if (jogoSelecionado.Status == "Alugado")
            {
                MessageBox.Show("Esse jogo já está alugado!");
                return;
            }

            TelaALUGAR tela = new TelaALUGAR();
            tela.JogoSelecionado = jogoSelecionado;
            tela.CPFUsuario = CPFUSUARIO;
            tela.ShowDialog();

            dgvListaJogos.Refresh();
        }

        private void btnDEVOLVER_Click(object sender, EventArgs e)
        {
            var teladevolver = new TelaDevolver();
            this.Hide();
            teladevolver.ShowDialog();
            this.Show();
        }

        private void TelaPrincipalUsuario_Load(object sender, EventArgs e)
        {
            CarregarJogo();
        }

        private void dgvListaJog(object sender, QuestionEventArgs e)
        {

        }
    }

}

