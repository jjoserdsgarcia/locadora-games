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
    public partial class TelaDgvUSER : Form
    {

        private readonly string CPFUSUARIO;
        private readonly bool IsADMIN;
        public TelaDgvUSER(bool IsADMIN, string CPFUSUARIO)
        {
            InitializeComponent();
            this.CPFUSUARIO = CPFUSUARIO;
            this.IsADMIN = IsADMIN;

           
        }

        private void btnALUGAR_Click(object sender, EventArgs e)
        {
            var telaalugar = new TelaALUGAR();
            this.Hide();
            telaalugar.ShowDialog();
            this.Show();
        }

        private void btnDEVOLVER_Click(object sender, EventArgs e)
        {
            var teladevolver = new TelaDevolver();
            this.Hide();
            teladevolver.ShowDialog();
            this.Show();
        }
    }
}
