using System.Configuration;
using ProjetoWindowsForms___Senac.Classes;

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


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EditarJogo_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }
    }
}
