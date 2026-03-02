using System.Configuration;
using ProjetoWindowsForms___Senac.Classes;
using ProjetoWindowsForms___Senac.Repositories.RepoGamesInfo;

namespace ProjetoWindowsForms___Senac
{
    public partial class TelaEditarJogo : Form
    {
        private Jogo jogo;
        public TelaEditarJogo(Jogo jogoRecebido)
        {
            InitializeComponent();
            jogo = jogoRecebido;

            lblEditando.Text = $"Editando: {jogo.Titulo}";

            txtTituloJogoEdit.Text = jogo.Titulo;
            txtPlataformaJogoEdit.Text = jogo.Plataforma;
            txtGeneroJogoEdit.Text = jogo.Genero;
            txtAnoJogoEdit.Text = jogo.Ano.ToString();


        }

        private async void btnSalvarEditJogo(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTituloJogoEdit.Text) ||
                string.IsNullOrWhiteSpace(txtPlataformaJogoEdit.Text) ||
                string.IsNullOrWhiteSpace(txtGeneroJogoEdit.Text) ||
                string.IsNullOrWhiteSpace(txtAnoJogoEdit.Text))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            jogo.Titulo = txtTituloJogoEdit.Text;
            jogo.Plataforma = txtPlataformaJogoEdit.Text;
            jogo.Genero = txtGeneroJogoEdit.Text;
            jogo.Ano = int.Parse(txtAnoJogoEdit.Text);

            await RepositorioJogo.Atualizar(jogo);

            MessageBox.Show("Jogo atualizado com sucesso!");
            Close();
        }

        private void btnCancelarEdit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
