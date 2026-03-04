using ProjetoWindowsForms___Senac.Classes;
using ProjetoWindowsForms___Senac.Repositories.RepoUser;
using ProjetoWindowsForms___Senac.Repositories.RepoGamesInfo;

namespace ProjetoWindowsForms___Senac
{
    public partial class TelaCadastroJogo : Form
    {

        public TelaCadastroJogo()
        {
            InitializeComponent();
        }

        private async void btnSalvarJogo(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeJogo.Text) ||
                string.IsNullOrWhiteSpace(txtPlataforma.Text) ||
                string.IsNullOrWhiteSpace(txtGenero.Text))
            {
                MessageBox.Show(
                    "Preencha todos os campos!",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            int ano = dtpAnoLancamentoCadastro.Value.Year;

            var novoJogo = new Jogo
            {
                Titulo = txtNomeJogo.Text,
                Plataforma = txtPlataforma.Text,
                Genero = txtGenero.Text,
                Categoria = rbtnBronze.Checked ? CategoriaJogo.Bronze :
                            rbtnPrata.Checked ? CategoriaJogo.Prata :
                            CategoriaJogo.Ouro,
                Ano = ano,
                Status = "Disponível"
            };

            await RepositorioJogo.SalvarJogo(novoJogo);

            MessageBox.Show(
                "Jogo cadastrado com sucesso!");

            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbtnBronze_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
