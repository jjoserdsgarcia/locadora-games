using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoWindowsForms___Senac.TELAS
{
    public partial class TelaALUGAR : Form
    {
        public TelaALUGAR()
        {
            InitializeComponent();
        }

        private void lblCPFUSERALUGAR_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnALUGARUSUARIO_Click(object sender, EventArgs e)
        {

            if (cmbJogo.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um jogo!");
                return;
            }

            if (dtpEntrega.Value <= DateTime.Now)
            {
                MessageBox.Show("Data inválida!");
                return;
            }

            MessageBox.Show("Aluguel realizado com sucesso!");

            ///

            DateTime dataEntrega = dtpEntrega.Value;

            ///

            /*var telaalugar = new TelaALUGAR();
            this.Hide();
            telaalugar.ShowDialog();
            this.Show();*/
            Close();
        }

        private void btnCANCELARALUGAR_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TelaALUGAR_Load(object sender, EventArgs e)
        {
            cmbJogo.Items.Add("God of War Ragnarok");
            cmbJogo.Items.Add("Silent Hill II");
            cmbJogo.Items.Add("Reanimal");

            txtNomeUsuarioAlugar.Text = "Pedro Vieira";
            txtCpfUsuarioAlugar.Text = "12345678900";
            txtTelefoneUsuarioAlugar.Text = "51985376634";

            txtNomeUsuarioAlugar.ReadOnly = true;
            txtCpfUsuarioAlugar.ReadOnly = true;
            txtTelefoneUsuarioAlugar.ReadOnly = true;

            ////


        }
    }
}
