namespace ProjetoWindowsForms___Senac
{
    partial class EditarJogo
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
            lblEditando = new Label();
            label2 = new Label();
            lblNome = new Label();
            lblPlataforma = new Label();
            lblGenero = new Label();
            lblAno = new Label();
            btnSalvarEdit = new Button();
            btnCancelarEdit = new Button();
            pictureBox1 = new PictureBox();
            txtNOMEJOGO = new TextBox();
            txtPLATAFORMAJOGO = new TextBox();
            txtGENEROJOGO = new TextBox();
            txtANOJOGO = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblEditando
            // 
            lblEditando.AutoSize = true;
            lblEditando.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblEditando.Location = new Point(43, 25);
            lblEditando.Name = "lblEditando";
            lblEditando.Size = new Size(77, 20);
            lblEditando.TabIndex = 0;
            lblEditando.Text = "Editando:";
            lblEditando.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(195, 25);
            label2.Name = "label2";
            label2.Size = new Size(212, 25);
            label2.TabIndex = 1;
            label2.Text = "Informações do Jogo";
            label2.Click += label2_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Underline);
            lblNome.Location = new Point(195, 90);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(61, 24);
            lblNome.TabIndex = 3;
            lblNome.Text = "Título:";
            lblNome.Click += lblNome_Click;
            // 
            // lblPlataforma
            // 
            lblPlataforma.AutoSize = true;
            lblPlataforma.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Underline);
            lblPlataforma.Location = new Point(195, 135);
            lblPlataforma.Name = "lblPlataforma";
            lblPlataforma.Size = new Size(102, 24);
            lblPlataforma.TabIndex = 4;
            lblPlataforma.Text = "Plataforma:";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Underline);
            lblGenero.Location = new Point(195, 186);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(79, 24);
            lblGenero.TabIndex = 5;
            lblGenero.Text = "Gênero:";
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Underline);
            lblAno.Location = new Point(195, 239);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(50, 24);
            lblAno.TabIndex = 6;
            lblAno.Text = "Ano:";
            lblAno.Click += label7_Click;
            // 
            // btnSalvarEdit
            // 
            btnSalvarEdit.Font = new Font("Microsoft Sans Serif", 15.75F);
            btnSalvarEdit.Location = new Point(672, 383);
            btnSalvarEdit.Name = "btnSalvarEdit";
            btnSalvarEdit.Size = new Size(100, 40);
            btnSalvarEdit.TabIndex = 16;
            btnSalvarEdit.Text = "Salvar";
            btnSalvarEdit.UseVisualStyleBackColor = true;
            btnSalvarEdit.Click += button1_Click;
            // 
            // btnCancelarEdit
            // 
            btnCancelarEdit.Font = new Font("Microsoft Sans Serif", 15.75F);
            btnCancelarEdit.Location = new Point(550, 383);
            btnCancelarEdit.Name = "btnCancelarEdit";
            btnCancelarEdit.Size = new Size(100, 40);
            btnCancelarEdit.TabIndex = 17;
            btnCancelarEdit.Text = "Cancelar";
            btnCancelarEdit.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 218);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // txtNOMEJOGO
            // 
            txtNOMEJOGO.Location = new Point(264, 88);
            txtNOMEJOGO.Name = "txtNOMEJOGO";
            txtNOMEJOGO.Size = new Size(184, 23);
            txtNOMEJOGO.TabIndex = 19;
            // 
            // txtPLATAFORMAJOGO
            // 
            txtPLATAFORMAJOGO.Location = new Point(303, 137);
            txtPLATAFORMAJOGO.Name = "txtPLATAFORMAJOGO";
            txtPLATAFORMAJOGO.Size = new Size(174, 23);
            txtPLATAFORMAJOGO.TabIndex = 20;
            // 
            // txtGENEROJOGO
            // 
            txtGENEROJOGO.Location = new Point(270, 188);
            txtGENEROJOGO.Name = "txtGENEROJOGO";
            txtGENEROJOGO.Size = new Size(160, 23);
            txtGENEROJOGO.TabIndex = 21;
            // 
            // txtANOJOGO
            // 
            txtANOJOGO.Location = new Point(247, 241);
            txtANOJOGO.Name = "txtANOJOGO";
            txtANOJOGO.Size = new Size(165, 23);
            txtANOJOGO.TabIndex = 22;
            // 
            // EditarJogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtANOJOGO);
            Controls.Add(txtGENEROJOGO);
            Controls.Add(txtPLATAFORMAJOGO);
            Controls.Add(txtNOMEJOGO);
            Controls.Add(pictureBox1);
            Controls.Add(btnCancelarEdit);
            Controls.Add(btnSalvarEdit);
            Controls.Add(lblAno);
            Controls.Add(lblGenero);
            Controls.Add(lblPlataforma);
            Controls.Add(lblNome);
            Controls.Add(label2);
            Controls.Add(lblEditando);
            Name = "EditarJogo";
            Text = "EditarJogo";
            Load += EditarJogo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEditando;
        private Label label2;
        private Label lblNome;
        private Label lblPlataforma;
        private Label lblGenero;
        private Label lblAno;
        private Button btnSalvarEdit;
        private Button btnCancelarEdit;
        private PictureBox pictureBox1;
        private TextBox txtNOMEJOGO;
        private TextBox txtPLATAFORMAJOGO;
        private TextBox txtGENEROJOGO;
        private TextBox txtANOJOGO;
    }
}