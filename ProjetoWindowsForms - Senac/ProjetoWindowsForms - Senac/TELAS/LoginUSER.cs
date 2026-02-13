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
            var teladgvuser = new TelaDgvUSER();
            this.Hide();
            teladgvuser.ShowDialog();
            this.Show();
        }
    }
}
