namespace ProjetoWindowsForms___Senac
{
    partial class DgvTelaADMIN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvADMIN = new DataGridView();
            btnDGVADMINCRIAR = new Button();
            btnDGVADMINEDITAR = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvADMIN).BeginInit();
            SuspendLayout();
            // 
            // dgvADMIN
            // 
            dgvADMIN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvADMIN.Location = new Point(195, 7);
            dgvADMIN.Name = "dgvADMIN";
            dgvADMIN.Size = new Size(601, 260);
            dgvADMIN.TabIndex = 0;
            // 
            // btnDGVADMINCRIAR
            // 
            btnDGVADMINCRIAR.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btnDGVADMINCRIAR.Location = new Point(18, 21);
            btnDGVADMINCRIAR.Name = "btnDGVADMINCRIAR";
            btnDGVADMINCRIAR.Size = new Size(148, 47);
            btnDGVADMINCRIAR.TabIndex = 1;
            btnDGVADMINCRIAR.Text = "Cadastrar Usuário";
            btnDGVADMINCRIAR.UseVisualStyleBackColor = true;
            btnDGVADMINCRIAR.Click += button1_Click;
            // 
            // btnDGVADMINEDITAR
            // 
            btnDGVADMINEDITAR.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btnDGVADMINEDITAR.Location = new Point(18, 97);
            btnDGVADMINEDITAR.Name = "btnDGVADMINEDITAR";
            btnDGVADMINEDITAR.Size = new Size(144, 47);
            btnDGVADMINEDITAR.TabIndex = 2;
            btnDGVADMINEDITAR.Text = "Editar";
            btnDGVADMINEDITAR.UseVisualStyleBackColor = true;
            // 
            // DgvTelaADMIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDGVADMINEDITAR);
            Controls.Add(btnDGVADMINCRIAR);
            Controls.Add(dgvADMIN);
            Name = "DgvTelaADMIN";
            Text = "Tela Principal - ADMIN";
            ((System.ComponentModel.ISupportInitialize)dgvADMIN).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvADMIN;
        private Button btnDGVADMINCRIAR;
        private Button btnDGVADMINEDITAR;
    }
}