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
            btnDGVADMINEDITAR = new Button();
            dgvADMINJOGOS = new Button();
            dgvADMINUSUARIOS = new Button();
            dgvADMINCADASTRAR = new Button();
            dgvADMINEXCLUIR = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvADMIN).BeginInit();
            SuspendLayout();
            // 
            // dgvADMIN
            // 
            dgvADMIN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvADMIN.Location = new Point(187, 12);
            dgvADMIN.Name = "dgvADMIN";
            dgvADMIN.Size = new Size(601, 260);
            dgvADMIN.TabIndex = 0;
            // 
            // btnDGVADMINEDITAR
            // 
            btnDGVADMINEDITAR.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btnDGVADMINEDITAR.Location = new Point(484, 366);
            btnDGVADMINEDITAR.Name = "btnDGVADMINEDITAR";
            btnDGVADMINEDITAR.Size = new Size(108, 40);
            btnDGVADMINEDITAR.TabIndex = 2;
            btnDGVADMINEDITAR.Text = "Editar";
            btnDGVADMINEDITAR.UseVisualStyleBackColor = true;
            // 
            // dgvADMINJOGOS
            // 
            dgvADMINJOGOS.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvADMINJOGOS.Location = new Point(38, 163);
            dgvADMINJOGOS.Name = "dgvADMINJOGOS";
            dgvADMINJOGOS.Size = new Size(108, 40);
            dgvADMINJOGOS.TabIndex = 5;
            dgvADMINJOGOS.Text = "Jogos";
            dgvADMINJOGOS.UseVisualStyleBackColor = true;
            // 
            // dgvADMINUSUARIOS
            // 
            dgvADMINUSUARIOS.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvADMINUSUARIOS.Location = new Point(38, 66);
            dgvADMINUSUARIOS.Name = "dgvADMINUSUARIOS";
            dgvADMINUSUARIOS.Size = new Size(108, 40);
            dgvADMINUSUARIOS.TabIndex = 6;
            dgvADMINUSUARIOS.Text = "Usuários";
            dgvADMINUSUARIOS.UseVisualStyleBackColor = true;
            // 
            // dgvADMINCADASTRAR
            // 
            dgvADMINCADASTRAR.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvADMINCADASTRAR.Location = new Point(322, 366);
            dgvADMINCADASTRAR.Name = "dgvADMINCADASTRAR";
            dgvADMINCADASTRAR.Size = new Size(108, 40);
            dgvADMINCADASTRAR.TabIndex = 7;
            dgvADMINCADASTRAR.Text = "Cadastrar";
            dgvADMINCADASTRAR.UseVisualStyleBackColor = true;
            // 
            // dgvADMINEXCLUIR
            // 
            dgvADMINEXCLUIR.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvADMINEXCLUIR.Location = new Point(649, 366);
            dgvADMINEXCLUIR.Name = "dgvADMINEXCLUIR";
            dgvADMINEXCLUIR.Size = new Size(108, 40);
            dgvADMINEXCLUIR.TabIndex = 8;
            dgvADMINEXCLUIR.Text = "Excluir";
            dgvADMINEXCLUIR.UseVisualStyleBackColor = true;
            // 
            // DgvTelaADMIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvADMINEXCLUIR);
            Controls.Add(dgvADMINCADASTRAR);
            Controls.Add(dgvADMINUSUARIOS);
            Controls.Add(dgvADMINJOGOS);
            Controls.Add(btnDGVADMINEDITAR);
            Controls.Add(dgvADMIN);
            Name = "DgvTelaADMIN";
            Text = "Tela Principal - ADMIN";
            Load += DgvTelaADMIN_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvADMIN).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvADMIN;
        private Button btnDGVADMINCRIAR;
        private Button btnDGVADMINEDITAR;
        private Button button1;
        private Button button2;
        private Button dgvADMINJOGOS;
        private Button dgvADMINUSUARIOS;
        private Button dgvADMINCADASTRAR;
        private Button dgvADMINEXCLUIR;
    }
}