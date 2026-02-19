namespace ProjetoWindowsForms___Senac
{
    public partial class CadastroGame : Form
    {
        private List<Jogo> jogos = new List<Jogo>(); 

        public CadastroGame()
        {  
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnSalvarJogo(object sender, EventArgs e)
        {
            //pegar os campos digitados

            string titulo = txtNomeJogo.Text;
            string plataforma = txtPlataforma.Text;
            string genero = txtGenero.Text;
            string valor = txtValor.Text;
            string ano = txtAnoLanca.Text;

            Jogo novoJogo = new Jogo()
            {
                Titulo = titulo,
                Plataforma = plataforma,
                Genero = genero,
                Valor = decimal.Parse(txtValor.Text),
                Ano = int.Parse(txtAnoLanca.Text)
            };

            jogos.Add(novoJogo);
            MessageBox.Show("Jogo cadastrado com sucesso!");
        }
    }
}
