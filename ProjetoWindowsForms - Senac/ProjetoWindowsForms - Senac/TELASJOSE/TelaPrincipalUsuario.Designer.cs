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
            dgvMAINPAGE = new DataGridView();
            btnALUGAR = new Button();
            btnDEVOLVER = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMAINPAGE).BeginInit();
            SuspendLayout();
            // 
            // dgvMAINPAGE
            // 
            dgvMAINPAGE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMAINPAGE.Location = new Point(12, 12);
            dgvMAINPAGE.Name = "dgvMAINPAGE";
            dgvMAINPAGE.Size = new Size(776, 257);
            dgvMAINPAGE.TabIndex = 0;
            // 
            // btnALUGAR
            // 
            btnALUGAR.Font = new Font("Modern No. 20", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnALUGAR.Location = new Point(230, 360);
            btnALUGAR.Name = "btnALUGAR";
            btnALUGAR.Size = new Size(181, 67);
            btnALUGAR.TabIndex = 1;
            btnALUGAR.Text = "ALUGAR";
            btnALUGAR.UseVisualStyleBackColor = true;
            btnALUGAR.Click += btnALUGAR_Click;
            // 
            // btnDEVOLVER
            // 
            btnDEVOLVER.Font = new Font("Modern No. 20", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDEVOLVER.Location = new Point(452, 360);
            btnDEVOLVER.Name = "btnDEVOLVER";
            btnDEVOLVER.Size = new Size(181, 67);
            btnDEVOLVER.TabIndex = 2;
            btnDEVOLVER.Text = "DEVOLVER";
            btnDEVOLVER.UseVisualStyleBackColor = true;
            btnDEVOLVER.Click += btnDEVOLVER_Click;
            // 
            // TelaDgvUSER
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDEVOLVER);
            Controls.Add(btnALUGAR);
            Controls.Add(dgvMAINPAGE);
            Name = "TelaDgvUSER";
            Text = "Tela Principal - Main Page";
            ((System.ComponentModel.ISupportInitialize)dgvMAINPAGE).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMAINPAGE;
        private Button btnALUGAR;
        private Button btnDEVOLVER;
    }
}