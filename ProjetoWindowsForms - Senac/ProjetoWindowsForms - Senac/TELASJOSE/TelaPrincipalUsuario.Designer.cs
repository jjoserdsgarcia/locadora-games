namespace ProjetoWindowsForms___Senac.TELAS
{
    partial class TelaPrincipalUsuario
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
            dgvListaJogos = new DataGridView();
            btnALUGAR = new Button();
            btnDEVOLVER = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListaJogos).BeginInit();
            SuspendLayout();
            // 
            // dgvListaJogos
            // 
            dgvListaJogos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaJogos.Location = new Point(33, 60);
            dgvListaJogos.Name = "dgvListaJogos";
            dgvListaJogos.Size = new Size(731, 225);
            dgvListaJogos.TabIndex = 0;
            dgvListaJogos.CancelRowEdit += dgvListaJog;
            // 
            // btnALUGAR
            // 
            btnALUGAR.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnALUGAR.Location = new Point(189, 346);
            btnALUGAR.Name = "btnALUGAR";
            btnALUGAR.Size = new Size(181, 67);
            btnALUGAR.TabIndex = 1;
            btnALUGAR.Text = "ALUGAR";
            btnALUGAR.UseVisualStyleBackColor = true;
            btnALUGAR.Click += btnALUGAR_Click;
            // 
            // btnDEVOLVER
            // 
            btnDEVOLVER.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDEVOLVER.Location = new Point(449, 346);
            btnDEVOLVER.Name = "btnDEVOLVER";
            btnDEVOLVER.Size = new Size(181, 67);
            btnDEVOLVER.TabIndex = 2;
            btnDEVOLVER.Text = "DEVOLVER";
            btnDEVOLVER.UseVisualStyleBackColor = true;
            btnDEVOLVER.Click += btnDEVOLVER_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(254, 21);
            label1.Name = "label1";
            label1.Size = new Size(302, 25);
            label1.TabIndex = 3;
            label1.Text = "Escolha um dos jogos para Alugar:";
            // 
            // TelaPrincipalUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnDEVOLVER);
            Controls.Add(btnALUGAR);
            Controls.Add(dgvListaJogos);
            Name = "TelaPrincipalUsuario";
            Text = "Tela Principal - Main Page";
            Load += TelaPrincipalUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaJogos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnALUGAR;
        private Button btnDEVOLVER;
        private Label label1;
        private DataGridView dgvListaJogos;
        
    }
}