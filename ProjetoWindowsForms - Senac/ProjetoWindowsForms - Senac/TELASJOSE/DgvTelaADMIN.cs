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
using ProjetoWindowsForms___Senac.TELAS;

namespace ProjetoWindowsForms___Senac
{
    public partial class DgvTelaADMIN : Form
    {
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
            dgvADMIN.DataSource = usuario;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var telacadastrousuario = new TelaCadastroUsuario();
            this.Hide();
            telacadastrousuario.ShowDialog();
            this.Show();

        }

        private void DgvTelaADMIN_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
