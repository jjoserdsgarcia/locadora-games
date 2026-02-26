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




        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dgvADMINCADASTRAR_Click(object sender, EventArgs e)
        {

            var telacadastrousuario = new TelaCadastroUsuario(this);
            this.Hide();
            telacadastrousuario.ShowDialog();
            this.Show();

        }

        private void btnSAIRDGVADM_Click(object sender, EventArgs e)
        {
            Close();



        }



        private async void btnUsuarios(object sender, EventArgs e)
        {
            tipoAtual = TipoCadastroUsuarioJogo.Usuarios;
            dgvADMIN.DataSource = await RepositorioUsuario.ObterTodos();
        }

        private async void btnJogos(object sender, EventArgs e)
        {
            //if (tipoAtual == TipoCadastroUsuarioJogo.Usuarios)
            //    {
            //        var tela = new TelaCadastroUsuario(this);
            //tela.ShowDialog();
            //    }
            //    else if (tipoAtual == TipoCadastroUsuarioJogo.Jogos)
            //    {
            //        var tela = new TelaCadastroJogo();
            //      tela.ShowDialog();
            //    }


            tipoAtual = TipoCadastroUsuarioJogo.Jogos;
            dgvADMIN.DataSource = await RepositorioJogo.ObterTodos();
        }

        private async void dgvADMINEXCLUIR_Click(object sender, EventArgs e)
        {
            string nomeUsuario = dgvADMIN.SelectedRows[0].Cells[1].Value.ToString();

            var retorno = MessageBox.Show($"Deseja mesmo excluir o usuário {nomeUsuario}?", "Excluindo usuário.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (retorno == DialogResult.Yes)
            {
                int UsuarioID = (int)dgvADMIN.SelectedRows[0].Cells[0].Value;
                await RepositorioUsuario.Deletar(UsuarioID);
                MessageBox.Show($"O usuário {nomeUsuario} foi deletado.", "Exclusão de usuário.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                await this.atualizartabelaadmindgv();

            }
        }
    }
}
