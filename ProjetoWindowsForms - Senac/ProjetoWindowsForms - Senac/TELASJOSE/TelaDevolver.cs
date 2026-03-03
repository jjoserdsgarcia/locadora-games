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
    public partial class TelaDevolver : Form
    {
        public TelaDevolver()
        {
            InitializeComponent();
        }

        public partial class FormDevolucao : Form
        {
            // Valor da diária de multa
            private decimal multaPorDia = 5.00m;

            // Data prevista de devolução (simulação)
            private DateTime dataPrevista = DateTime.Now.AddDays(-2); // Simulando atraso de 2 dias

            private void FormDevolucao_Load(object sender, EventArgs e)
            {
                txtDataPrevista.Text = dataPrevista.ToShortDateString();
                dtpDataDevolucao.Value = DateTime.Now;
            }

            private void btnCalcular_Click(object sender, EventArgs e)
            {
                DateTime dataDevolucao = dtpDataDevolucao.Value;

                if (dataDevolucao > dataPrevista)
                {
                    int diasAtraso = (dataDevolucao - dataPrevista).Days;
                    decimal valorMulta = diasAtraso * multaPorDia;

                    lblResultado.Text = $"Atraso de {diasAtraso} dias.\nMulta: R$ {valorMulta:F2}";
                }
                else
                {
                    lblResultado.Text = "Devolução dentro do prazo.\nSem multa.";
                }
            }

            private void btnConfirmar_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Devolução registrada com sucesso!",
                                "Sucesso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

