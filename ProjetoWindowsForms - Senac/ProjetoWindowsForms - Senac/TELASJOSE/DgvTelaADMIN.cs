<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoWindowsForms___Senac.Classes;
=======
﻿using System.Threading.Tasks;
using ProjetoWindowsForms___Senac.Classes;
using ProjetoWindowsForms___Senac.Repositories.RepoGamesInfo;
>>>>>>> e0fec772c23c7dfef436bdd6e33e03c43e5feb6b
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

        private async Task atualizartabelaadmindgv()
        {
            var usuario = await RepositoryUser.ObterTodos();
            dgvADMIN.DataSource = new BindingList<Usuario>(usuario.ToList());  
        }


       

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dgvADMINCADASTRAR_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            var telacadastrousuario = new TelaCadastroUsuario();
            this.Hide();
            telacadastrousuario.ShowDialog();
            this.Show();

        }

        private void btnSAIRDGVADM_Click(object sender, EventArgs e)
        {
            Close();
=======
            if (tipoAtual == TipoCadastroUsuarioJogo.Usuarios)
            {
                var tela = new TelaCadastroUsuario();
                tela.ShowDialog();
            }
            else if (tipoAtual == TipoCadastroUsuarioJogo.Jogos)
            {
                var tela = new TelaCadastroJogo();
                tela.ShowDialog();
            }

        }

        private void dgvADMIN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnUsuarios (object sender, EventArgs e)
        {
            tipoAtual = TipoCadastroUsuarioJogo.Usuarios;
            dgvADMIN.DataSource = await RepositoryUser.ObterTodos();
        }

        private async void btnJogos(object sender, EventArgs e)
        {
            tipoAtual = TipoCadastroUsuarioJogo.Jogos;
            dgvADMIN.DataSource = await RepositoryGame.ObterTodos();
>>>>>>> e0fec772c23c7dfef436bdd6e33e03c43e5feb6b
        }
    }
}
