namespace ProjetoWindowsForms___Senac.TELAS
{
    partial class TelaALUGAR
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
            lblDADOSUSER = new Label();
            lblNAMEUSERALUGAR = new Label();
            lblCPFUSERALUGAR = new Label();
            lblTELEFONEUSERALUGAR = new Label();
            txtNomeUsuarioAlugar = new TextBox();
            txtCpfUsuarioAlugar = new TextBox();
            txtTelefoneUsuarioAlugar = new TextBox();
            lblJOGOALUGADO = new Label();
            lblCATEGORIAALUGAR = new Label();
            txtCategoriaJogoAlugar = new TextBox();
            btnALUGARUSUARIO = new Button();
            btnCANCELARALUGAR = new Button();
            lblDATADEENTREGAALUGAR = new Label();
            dtpEntrega = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtValorJogoAlugar = new TextBox();
            txtPlataformaJogoAlugar = new TextBox();
            txtNomeJogoAlugar = new TextBox();
            SuspendLayout();
            // 
            // lblDADOSUSER
            // 
            lblDADOSUSER.AutoSize = true;
            lblDADOSUSER.BackColor = Color.Black;
            lblDADOSUSER.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblDADOSUSER.ForeColor = Color.White;
            lblDADOSUSER.Location = new Point(28, 13);
            lblDADOSUSER.Name = "lblDADOSUSER";
            lblDADOSUSER.Size = new Size(222, 31);
            lblDADOSUSER.TabIndex = 0;
            lblDADOSUSER.Text = "Dados do Cliente";
            // 
            // lblNAMEUSERALUGAR
            // 
            lblNAMEUSERALUGAR.AutoSize = true;
            lblNAMEUSERALUGAR.BackColor = Color.Black;
            lblNAMEUSERALUGAR.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblNAMEUSERALUGAR.ForeColor = Color.White;
            lblNAMEUSERALUGAR.Location = new Point(28, 61);
            lblNAMEUSERALUGAR.Name = "lblNAMEUSERALUGAR";
            lblNAMEUSERALUGAR.Size = new Size(59, 20);
            lblNAMEUSERALUGAR.TabIndex = 1;
            lblNAMEUSERALUGAR.Text = "Nome: ";
            // 
            // lblCPFUSERALUGAR
            // 
            lblCPFUSERALUGAR.AutoSize = true;
            lblCPFUSERALUGAR.BackColor = Color.Black;
            lblCPFUSERALUGAR.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblCPFUSERALUGAR.ForeColor = Color.White;
            lblCPFUSERALUGAR.Location = new Point(42, 99);
            lblCPFUSERALUGAR.Name = "lblCPFUSERALUGAR";
            lblCPFUSERALUGAR.Size = new Size(44, 20);
            lblCPFUSERALUGAR.TabIndex = 2;
            lblCPFUSERALUGAR.Text = "CPF:";
            // 
            // lblTELEFONEUSERALUGAR
            // 
            lblTELEFONEUSERALUGAR.AutoSize = true;
            lblTELEFONEUSERALUGAR.BackColor = Color.Black;
            lblTELEFONEUSERALUGAR.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTELEFONEUSERALUGAR.ForeColor = Color.White;
            lblTELEFONEUSERALUGAR.Location = new Point(11, 136);
            lblTELEFONEUSERALUGAR.Name = "lblTELEFONEUSERALUGAR";
            lblTELEFONEUSERALUGAR.Size = new Size(75, 20);
            lblTELEFONEUSERALUGAR.TabIndex = 3;
            lblTELEFONEUSERALUGAR.Text = "Telefone:";
            // 
            // txtNomeUsuarioAlugar
            // 
            txtNomeUsuarioAlugar.Location = new Point(108, 60);
            txtNomeUsuarioAlugar.Name = "txtNomeUsuarioAlugar";
            txtNomeUsuarioAlugar.Size = new Size(181, 23);
            txtNomeUsuarioAlugar.TabIndex = 8;
            // 
            // txtCpfUsuarioAlugar
            // 
            txtCpfUsuarioAlugar.Location = new Point(108, 99);
            txtCpfUsuarioAlugar.Name = "txtCpfUsuarioAlugar";
            txtCpfUsuarioAlugar.Size = new Size(181, 23);
            txtCpfUsuarioAlugar.TabIndex = 9;
            txtCpfUsuarioAlugar.TextChanged += txtCpfUsuarioAlugar_TextChanged;
            // 
            // txtTelefoneUsuarioAlugar
            // 
            txtTelefoneUsuarioAlugar.Location = new Point(108, 135);
            txtTelefoneUsuarioAlugar.Name = "txtTelefoneUsuarioAlugar";
            txtTelefoneUsuarioAlugar.Size = new Size(181, 23);
            txtTelefoneUsuarioAlugar.TabIndex = 10;
            // 
            // lblJOGOALUGADO
            // 
            lblJOGOALUGADO.AutoSize = true;
            lblJOGOALUGADO.BackColor = Color.Black;
            lblJOGOALUGADO.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblJOGOALUGADO.ForeColor = Color.White;
            lblJOGOALUGADO.Location = new Point(12, 182);
            lblJOGOALUGADO.Name = "lblJOGOALUGADO";
            lblJOGOALUGADO.Size = new Size(311, 31);
            lblJOGOALUGADO.TabIndex = 11;
            lblJOGOALUGADO.Text = "Dados do Jogo a Alugar:";
            // 
            // lblCATEGORIAALUGAR
            // 
            lblCATEGORIAALUGAR.AutoSize = true;
            lblCATEGORIAALUGAR.BackColor = Color.Black;
            lblCATEGORIAALUGAR.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblCATEGORIAALUGAR.ForeColor = Color.White;
            lblCATEGORIAALUGAR.Location = new Point(20, 319);
            lblCATEGORIAALUGAR.Name = "lblCATEGORIAALUGAR";
            lblCATEGORIAALUGAR.Size = new Size(82, 20);
            lblCATEGORIAALUGAR.TabIndex = 13;
            lblCATEGORIAALUGAR.Text = "Categoria:";
            // 
            // txtCategoriaJogoAlugar
            // 
            txtCategoriaJogoAlugar.Location = new Point(108, 318);
            txtCategoriaJogoAlugar.Name = "txtCategoriaJogoAlugar";
            txtCategoriaJogoAlugar.Size = new Size(181, 23);
            txtCategoriaJogoAlugar.TabIndex = 15;
            // 
            // btnALUGARUSUARIO
            // 
            btnALUGARUSUARIO.Location = new Point(623, 357);
            btnALUGARUSUARIO.Name = "btnALUGARUSUARIO";
            btnALUGARUSUARIO.Size = new Size(108, 40);
            btnALUGARUSUARIO.TabIndex = 17;
            btnALUGARUSUARIO.Text = "ALUGAR";
            btnALUGARUSUARIO.UseVisualStyleBackColor = true;
            btnALUGARUSUARIO.Click += btnALUGARUSUARIO_Click;
            // 
            // btnCANCELARALUGAR
            // 
            btnCANCELARALUGAR.Location = new Point(482, 357);
            btnCANCELARALUGAR.Name = "btnCANCELARALUGAR";
            btnCANCELARALUGAR.Size = new Size(108, 40);
            btnCANCELARALUGAR.TabIndex = 18;
            btnCANCELARALUGAR.Text = "VOLTAR";
            btnCANCELARALUGAR.UseVisualStyleBackColor = true;
            btnCANCELARALUGAR.Click += btnCANCELARALUGAR_Click;
            // 
            // lblDATADEENTREGAALUGAR
            // 
            lblDATADEENTREGAALUGAR.AutoSize = true;
            lblDATADEENTREGAALUGAR.BackColor = Color.Black;
            lblDATADEENTREGAALUGAR.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblDATADEENTREGAALUGAR.ForeColor = Color.White;
            lblDATADEENTREGAALUGAR.Location = new Point(539, 173);
            lblDATADEENTREGAALUGAR.Name = "lblDATADEENTREGAALUGAR";
            lblDATADEENTREGAALUGAR.Size = new Size(150, 24);
            lblDATADEENTREGAALUGAR.TabIndex = 14;
            lblDATADEENTREGAALUGAR.Text = "Data de Entrega:";
            // 
            // dtpEntrega
            // 
            dtpEntrega.Format = DateTimePickerFormat.Short;
            dtpEntrega.Location = new Point(515, 209);
            dtpEntrega.Name = "dtpEntrega";
            dtpEntrega.Size = new Size(200, 23);
            dtpEntrega.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 274);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 21;
            label1.Text = "Plataforma:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(47, 235);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 22;
            label2.Text = "Nome:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(47, 358);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 23;
            label3.Text = "Valor:";
            // 
            // txtValorJogoAlugar
            // 
            txtValorJogoAlugar.Location = new Point(108, 358);
            txtValorJogoAlugar.Name = "txtValorJogoAlugar";
            txtValorJogoAlugar.Size = new Size(181, 23);
            txtValorJogoAlugar.TabIndex = 24;
            // 
            // txtPlataformaJogoAlugar
            // 
            txtPlataformaJogoAlugar.Location = new Point(108, 275);
            txtPlataformaJogoAlugar.Name = "txtPlataformaJogoAlugar";
            txtPlataformaJogoAlugar.Size = new Size(181, 23);
            txtPlataformaJogoAlugar.TabIndex = 25;
            // 
            // txtNomeJogoAlugar
            // 
            txtNomeJogoAlugar.Location = new Point(108, 232);
            txtNomeJogoAlugar.Name = "txtNomeJogoAlugar";
            txtNomeJogoAlugar.Size = new Size(181, 23);
            txtNomeJogoAlugar.TabIndex = 26;
            // 
            // TelaALUGAR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            BackgroundImage = Properties.Resources.d0b7d847_5bad_4ed5_a76b_a413a0e81b87;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(797, 442);
            Controls.Add(txtNomeJogoAlugar);
            Controls.Add(txtPlataformaJogoAlugar);
            Controls.Add(txtValorJogoAlugar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpEntrega);
            Controls.Add(btnCANCELARALUGAR);
            Controls.Add(btnALUGARUSUARIO);
            Controls.Add(txtCategoriaJogoAlugar);
            Controls.Add(lblDATADEENTREGAALUGAR);
            Controls.Add(lblCATEGORIAALUGAR);
            Controls.Add(lblJOGOALUGADO);
            Controls.Add(txtTelefoneUsuarioAlugar);
            Controls.Add(txtCpfUsuarioAlugar);
            Controls.Add(txtNomeUsuarioAlugar);
            Controls.Add(lblTELEFONEUSERALUGAR);
            Controls.Add(lblCPFUSERALUGAR);
            Controls.Add(lblNAMEUSERALUGAR);
            Controls.Add(lblDADOSUSER);
            Name = "TelaALUGAR";
            Text = "Usuário - Alugar";
            Load += TelaALUGAR_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDADOSUSER;
        private Label lblNAMEUSERALUGAR;
        private Label lblCPFUSERALUGAR;
        private Label lblTELEFONEUSERALUGAR;
        private TextBox txtNomeUsuarioAlugar;
        private TextBox txtCpfUsuarioAlugar;
        private TextBox txtTelefoneUsuarioAlugar;
        private Label lblJOGOALUGADO;
        private Label lblCATEGORIAALUGAR;
        private TextBox txtCategoriaJogoAlugar;
        private Button btnALUGARUSUARIO;
        private Button btnCANCELARALUGAR;
        private Label lblDATADEENTREGAALUGAR;
        private DateTimePicker dtpEntrega;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtValorJogoAlugar;
        private TextBox txtPlataformaJogoAlugar;
        private TextBox txtNomeJogoAlugar;
    }
}