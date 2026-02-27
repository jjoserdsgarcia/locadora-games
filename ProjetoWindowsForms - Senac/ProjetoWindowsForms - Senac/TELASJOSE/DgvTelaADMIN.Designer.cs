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
            dgvADMINEDITAR = new Button();
            dgvADMINJOGOS = new Button();
            dgvADMINUSUARIOS = new Button();
            dgvADMINCADASTRAR = new Button();
            dgvADMINEXCLUIR = new Button();
            btnSAIRDGVADM = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvADMIN).BeginInit();
            SuspendLayout();
            // 
            // dgvADMIN
            // 
            dgvADMIN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvADMIN.Location = new Point(149, 12);
            dgvADMIN.Name = "dgvADMIN";
            dgvADMIN.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvADMIN.Size = new Size(639, 272);
            dgvADMIN.TabIndex = 0;
            // 
            // dgvADMINEDITAR
            // 
            dgvADMINEDITAR.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Underline, GraphicsUnit.Point, 0);
            dgvADMINEDITAR.Location = new Point(484, 366);
            dgvADMINEDITAR.Name = "dgvADMINEDITAR";
            dgvADMINEDITAR.Size = new Size(108, 40);
            dgvADMINEDITAR.TabIndex = 2;
            dgvADMINEDITAR.Text = "Editar";
            dgvADMINEDITAR.UseVisualStyleBackColor = true;
            // 
            // dgvADMINJOGOS
            // 
            dgvADMINJOGOS.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvADMINJOGOS.Location = new Point(12, 161);
            dgvADMINJOGOS.Name = "dgvADMINJOGOS";
            dgvADMINJOGOS.Size = new Size(108, 40);
            dgvADMINJOGOS.TabIndex = 5;
            dgvADMINJOGOS.Text = "Jogos";
            dgvADMINJOGOS.UseVisualStyleBackColor = true;
            dgvADMINJOGOS.Click += btnJogos;
            // 
            // dgvADMINUSUARIOS
            // 
            dgvADMINUSUARIOS.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvADMINUSUARIOS.Location = new Point(12, 59);
            dgvADMINUSUARIOS.Name = "dgvADMINUSUARIOS";
            dgvADMINUSUARIOS.Size = new Size(108, 40);
            dgvADMINUSUARIOS.TabIndex = 6;
            dgvADMINUSUARIOS.Text = "Usuários";
            dgvADMINUSUARIOS.UseVisualStyleBackColor = true;
            dgvADMINUSUARIOS.Click += btnUsuarios;
            // 
            // dgvADMINCADASTRAR
            // 
            dgvADMINCADASTRAR.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvADMINCADASTRAR.Location = new Point(322, 366);
            dgvADMINCADASTRAR.Name = "dgvADMINCADASTRAR";
            dgvADMINCADASTRAR.Size = new Size(108, 40);
            dgvADMINCADASTRAR.TabIndex = 7;
            dgvADMINCADASTRAR.Text = "Cadastrar";
            dgvADMINCADASTRAR.UseVisualStyleBackColor = true;
            dgvADMINCADASTRAR.Click += dgvADMINCADASTRAR_Click;
            // 
            // dgvADMINEXCLUIR
            // 
            dgvADMINEXCLUIR.BackColor = Color.LightGray;
            dgvADMINEXCLUIR.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvADMINEXCLUIR.Location = new Point(646, 366);
            dgvADMINEXCLUIR.Name = "dgvADMINEXCLUIR";
            dgvADMINEXCLUIR.Size = new Size(108, 40);
            dgvADMINEXCLUIR.TabIndex = 10;
            dgvADMINEXCLUIR.Text = "Excluir";
            dgvADMINEXCLUIR.UseVisualStyleBackColor = false;
            dgvADMINEXCLUIR.Click += dgvADMINEXCLUIR_Click;
            // 
            // btnSAIRDGVADM
            // 
            btnSAIRDGVADM.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSAIRDGVADM.Location = new Point(53, 362);
            btnSAIRDGVADM.Name = "btnSAIRDGVADM";
            btnSAIRDGVADM.Size = new Size(149, 48);
            btnSAIRDGVADM.TabIndex = 9;
            btnSAIRDGVADM.Text = "SAIR";
            btnSAIRDGVADM.UseVisualStyleBackColor = true;
            btnSAIRDGVADM.Click += btnSAIRDGVADM_Click;
            // 
            // DgvTelaADMIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSAIRDGVADM);
            Controls.Add(dgvADMINEXCLUIR);
            Controls.Add(dgvADMINCADASTRAR);
            Controls.Add(dgvADMINUSUARIOS);
            Controls.Add(dgvADMINJOGOS);
            Controls.Add(dgvADMINEDITAR);
            Controls.Add(dgvADMIN);
            Name = "DgvTelaADMIN";
            Text = "Tela Principal - ADMIN";
            ((System.ComponentModel.ISupportInitialize)dgvADMIN).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvADMIN;
        private Button btnDGVADMINCRIAR;
        private Button dgvADMINEDITAR;
        private Button button1;
        private Button button2;
        private Button dgvADMINJOGOS;
        private Button dgvADMINUSUARIOS;
        private Button dgvADMINCADASTRAR;
        private Button dgvADMINEXCLUIR;
        private Button btnSAIRDGVADM;
    }
}