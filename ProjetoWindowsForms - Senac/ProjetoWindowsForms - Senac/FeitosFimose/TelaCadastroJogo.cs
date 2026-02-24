using ProjetoWindowsForms___Senac.Classes;

namespace ProjetoWindowsForms___Senac
{
    public partial class TelaCadastroJogo : Form
    {
        private List<Jogo> jogos = new List<Jogo>();

        public TelaCadastroJogo()
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


        private void btnSalvarJogo(object sender, EventArgs e)
        {
            //pegar os campos digitados

            string titulo = txtNomeJogo.Text;
            string plataforma = txtPlataforma.Text;
            string genero = txtGenero.Text;
            string valor = txtValor.Text;
            string anoLancamentoCadastro = txtAnoLancamento.Text;

            Jogo novoJogo = new Jogo()
            {
                Titulo = titulo,
                Plataforma = plataforma,
                Genero = genero,
                Valor = decimal.Parse(txtValor.Text),
                Ano = int.Parse(anoLancamentoCadastro)
            };

            jogos.Add(novoJogo);
            MessageBox.Show("Jogo cadastrado com sucesso!");
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
