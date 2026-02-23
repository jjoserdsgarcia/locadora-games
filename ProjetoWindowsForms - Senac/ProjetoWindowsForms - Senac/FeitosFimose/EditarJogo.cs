using System.Configuration;
using ProjetoWindowsForms___Senac.Classes;

namespace ProjetoWindowsForms___Senac
{
    public partial class EditarJogo : Form
    {
        private Jogo jogo;
        public EditarJogo(Jogo jogoRecebido)
        {
            InitializeComponent();
            jogo = jogoRecebido;

            lblEditando.Text = $"Editando: {jogo.Titulo}";
            lblID.Text = jogo.Id.ToString();
            lblNome.Text = jogo.Titulo;
            lblPlataforma.Text = jogo.Plataforma;
            lblGenero.Text = jogo.Genero;
            lblAno.Text = jogo.Ano.ToString();


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
