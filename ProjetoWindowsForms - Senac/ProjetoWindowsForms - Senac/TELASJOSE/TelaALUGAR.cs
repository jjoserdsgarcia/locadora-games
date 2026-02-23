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
            var telaalugar = new TelaALUGAR();
            this.Hide();
            telaalugar.ShowDialog();
            this.Show();

        }

        private void btnCANCELARALUGAR_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
