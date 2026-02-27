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
using Dapper;
﻿using System.Threading.Tasks;
using ProjetoWindowsForms___Senac.Classes;
using ProjetoWindowsForms___Senac.Repositories.RepoGamesInfo;

using ProjetoWindowsForms___Senac.Repositories.RepoUser;

namespace ProjetoWindowsForms___Senac
{

    public partial class DgvTelaADMIN : Form
    {
        string modoAtivo = "";
        string contextoAtual = "";
        private string tipoSelecionado = "";
        private TipoCadastroUsuarioJogo tipoAtual;

        public DgvTelaADMIN()
        {
            InitializeComponent();
            Load += DgvTelaADMIN_Load;
        }

        private async void DgvTelaADMIN_Load(object? sender, EventArgs e)
        {
            await atualizartabelaadmindgv();
        }

        public async Task atualizartabelaadmindgv()
        {
            var usuario = await RepositorioUsuario.ObterTodos();
            dgvADMIN.DataSource = new BindingList<Usuario>(usuario.ToList());
        }

        private async void btnUsuarios(object sender, EventArgs e)
        {
            modoAtivo = "USUARIOS";
            contextoAtual = "Usuarios";
            lblStatus.Text = "Gerenciando: Usuários";

            tipoAtual = TipoCadastroUsuarioJogo.Usuarios;
            dgvADMIN.DataSource = await RepositorioUsuario.ObterTodos();
        }

        private async void btnJogos(object sender, EventArgs e)
        {
            modoAtivo = "JOGOS";
            contextoAtual = "Jogos";
            lblStatus.Text = "Gerenciando: Jogos";


            tipoAtual = TipoCadastroUsuarioJogo.Jogos;
            dgvADMIN.DataSource = await RepositorioJogo.ObterTodos();
        }
        private void dgvADMINCADASTRAR_Click(object sender, EventArgs e)
        {
            if (modoAtivo == "USUARIOS")
            {

                TelaCadastroUsuario tela = new TelaCadastroUsuario();
                this.Hide();
                tela.ShowDialog();
                this.Show();
            }
            else if (modoAtivo == "JOGOS")
            {
                TelaCadastroJogo telaJogo = new TelaCadastroJogo();
                this.Hide();
                telaJogo.ShowDialog();
                this.Show();
            }
        }

        private void btnSAIRDGVADM_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void dgvADMINEXCLUIR_Click(object sender, EventArgs e)
        {

            if (dgvADMIN.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um item para excluir.");
                return;
            }

            string nomeUsuario = dgvADMIN.SelectedRows[0].Cells[1].Value.ToString();
            int id = (int)dgvADMIN.SelectedRows[0].Cells[0].Value;

            if (tipoAtual == TipoCadastroUsuarioJogo.Usuarios)
            {
                var retorno = MessageBox.Show(
                    $"Deseja excluir o usuário {nomeUsuario}?",
                    "Excluir usuário",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (retorno == DialogResult.Yes)
                {
                    await RepositorioUsuario.Deletar(id);
                    dgvADMIN.DataSource = await RepositorioUsuario.ObterTodos();
                }
            }
            else if (tipoAtual == TipoCadastroUsuarioJogo.Jogos)
            {
                var retorno = MessageBox.Show(
                    $"Deseja excluir o jogo {nomeUsuario}?",
                    "Excluir jogo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (retorno == DialogResult.Yes)
                {
                    await RepositorioJogo.Deletar(id);
                    dgvADMIN.DataSource = await RepositorioJogo.ObterTodos();
                }
            }

        }

        private void dgvAdminEditar(object sender, EventArgs e)
        {
            if (modoAtivo == "USUARIOS")
            {

                TelaEditarUsuario tela = new TelaEditarUsuario();
                this.Hide();
                tela.ShowDialog();
                this.Show();
            }
            else if (modoAtivo == "JOGOS")
            {
                var jogoSelecionado = (Jogo)dgvADMIN.SelectedRows[0].DataBoundItem;

      
                TelaEditarJogo telaJogo = new TelaEditarJogo(jogoSelecionado); this.Hide();
                this.Hide();
                telaJogo.ShowDialog();
                this.Show();
            }
        }
    }
}

