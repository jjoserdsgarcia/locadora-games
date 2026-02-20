using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoWindowsForms___Senac.TELAS;

namespace ProjetoWindowsForms___Senac
{
    public partial class LoginADM : Form
    {
        public LoginADM()
        {
            InitializeComponent();
        }

        private void btnENTRARADM_Click(object sender, EventArgs e)
        {
            var teladgvadm = new DgvTelaADMIN();
            this.Hide();
            teladgvadm.ShowDialog();
            this.Show();
        }
    }
}
