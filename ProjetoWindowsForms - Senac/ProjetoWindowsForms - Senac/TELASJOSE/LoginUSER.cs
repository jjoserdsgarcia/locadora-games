using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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




               

                if (txtCPFUSUARIO.Text.Length != 11 || !long.TryParse(txtCPFUSUARIO.Text, out _))
                {
                    MessageBox.Show(
                        "CPF inválido. Digite 11 números.",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }



            }
            string CPFUSUARIO = txtCPFUSUARIO.Text;

            var telaprincipal = new TelaPrincipalUsuario(false, CPFUSUARIO);
            this.Hide();
            telaprincipal.ShowDialog();
            this.Show();
            }


        private void lblCPFUSER_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVOLTARUSER_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginUSER_Load(object sender, EventArgs e)
        {

        }
    }
}
