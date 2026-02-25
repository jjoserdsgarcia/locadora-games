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
    public partial class LoginUSER : Form
    {
        public LoginUSER()
        {
            InitializeComponent();
        }

        private void btnPROSSEGUIRUSER_Click(object sender, EventArgs e)
        {
            {



                var telaprincipal = new TelaDgvUSER(false, txtCPFUSUARIO.Text);
                this.Hide();
                telaprincipal.ShowDialog();
                this.Show();



            }
          
        }

        private void lblCPFUSER_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
