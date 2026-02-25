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
            if (txtADMLOGIN.Text == "Admin" && txtADMSENHA.Text == "1234")
            {
                var teladgvadm = new DgvTelaADMIN();
                this.Close();
                teladgvadm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha Incorretos", "Erro ao realizar Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LoginADM_Load(object sender, EventArgs e)
        {

        }

        private void btnSAIRADMLOG_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
