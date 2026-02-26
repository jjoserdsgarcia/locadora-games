using ProjetoWindowsForms___Senac.Classes;
using ProjetoWindowsForms___Senac.Repositories.RepoUser;
using ProjetoWindowsForms___Senac.Repositories.RepoGamesInfo;

namespace ProjetoWindowsForms___Senac
{
    public partial class TelaPrincipalUsuario : Form
    {

        public TelaPrincipalUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtNJogo(object sender, EventArgs e)
        {

        }


        private async void btnSalvarJogo(object sender, EventArgs e)
        {
           if (string.IsNullOrWhiteSpace(txtNomeJogo.Text) ||
               string.IsNullOrWhiteSpace(txtPlataforma.Text) ||
               string.IsNullOrWhiteSpace(txtGenero.Text) ||
               string.IsNullOrWhiteSpace(txtValorSemanal.Text) ||
               string.IsNullOrWhiteSpace(txtAnoLancamento.Text))
            {
                MessageBox.Show(
                    "Preencha todos os campos!",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

             if (!decimal.TryParse(txtValorSemanal.Text, out decimal valor))
            {
                MessageBox.Show("Valor inválido!");
                return;
            } 

             if (!int.TryParse(txtAnoLancamento.Text, out int ano))
            {
                MessageBox.Show("Ano inválido!");
                return;
            }   

            var novoJogo = new Jogo
            {
                Titulo = txtNomeJogo.Text,
                Plataforma = txtPlataforma.Text,
                Genero = txtGenero.Text,
                Valor = valor,
                Ano = ano
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

        private void CadastroJogo_Load(object sender, EventArgs e)
        {

        }
    }
}
