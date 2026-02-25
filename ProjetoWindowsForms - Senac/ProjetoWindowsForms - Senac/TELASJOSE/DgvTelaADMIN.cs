using System.Threading.Tasks;
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

        private async Task atualizartabelaadmindgv()
        {
            var usuario = await RepositoryUser.ObterTodos();
            dgvADMIN.DataSource = usuario;
        }


        private void DgvTelaADMIN_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dgvADMINCADASTRAR_Click(object sender, EventArgs e)
        {
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
        }
    }
}
