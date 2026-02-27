namespace ProjetoWindowsForms___Senac
{
    partial class TelaEditarJogo
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
            pictureBox1 = new PictureBox();
            txtTituloJogoEdit = new TextBox();
            txtPlataformaJogoEdit = new TextBox();
            txtGeneroJogoEdit = new TextBox();
            txtAnoJogoEdit = new TextBox();
            btnCancelarEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblEditando
            // 
            lblEditando.AutoSize = true;
            lblEditando.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblEditando.Location = new Point(106, 40);
            lblEditando.Name = "lblEditando";
            lblEditando.Size = new Size(90, 24);
            lblEditando.TabIndex = 0;
            lblEditando.Text = "Editando:";
            lblEditando.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(300, 92);
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
            lblNome.Location = new Point(259, 140);
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
            lblPlataforma.Location = new Point(218, 180);
            lblPlataforma.Name = "lblPlataforma";
            lblPlataforma.Size = new Size(102, 24);
            lblPlataforma.TabIndex = 4;
            lblPlataforma.Text = "Plataforma:";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Underline);
            lblGenero.Location = new Point(241, 218);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(79, 24);
            lblGenero.TabIndex = 5;
            lblGenero.Text = "Gênero:";
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Underline);
            lblAno.Location = new Point(270, 257);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(50, 24);
            lblAno.TabIndex = 6;
            lblAno.Text = "Ano:";
            lblAno.Click += label7_Click;
            // 
            // btnSalvarEdit
            // 
            btnSalvarEdit.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvarEdit.Location = new Point(672, 383);
            btnSalvarEdit.Name = "btnSalvarEdit";
            btnSalvarEdit.Size = new Size(100, 40);
            btnSalvarEdit.TabIndex = 16;
            btnSalvarEdit.Text = "Salvar";
            btnSalvarEdit.UseVisualStyleBackColor = true;
            btnSalvarEdit.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(30, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 218);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // txtTituloJogoEdit
            // 
            txtTituloJogoEdit.Location = new Point(326, 141);
            txtTituloJogoEdit.Name = "txtTituloJogoEdit";
            txtTituloJogoEdit.Size = new Size(165, 23);
            txtTituloJogoEdit.TabIndex = 19;
            // 
            // txtPlataformaJogoEdit
            // 
            txtPlataformaJogoEdit.Location = new Point(326, 180);
            txtPlataformaJogoEdit.Name = "txtPlataformaJogoEdit";
            txtPlataformaJogoEdit.Size = new Size(165, 23);
            txtPlataformaJogoEdit.TabIndex = 20;
            // 
            // txtGeneroJogoEdit
            // 
            txtGeneroJogoEdit.Location = new Point(326, 218);
            txtGeneroJogoEdit.Name = "txtGeneroJogoEdit";
            txtGeneroJogoEdit.Size = new Size(165, 23);
            txtGeneroJogoEdit.TabIndex = 21;
            // 
            // txtAnoJogoEdit
            // 
            txtAnoJogoEdit.Location = new Point(326, 257);
            txtAnoJogoEdit.Name = "txtAnoJogoEdit";
            txtAnoJogoEdit.Size = new Size(165, 23);
            txtAnoJogoEdit.TabIndex = 22;
            // 
            // btnCancelarEdit
            // 
            btnCancelarEdit.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelarEdit.Location = new Point(552, 383);
            btnCancelarEdit.Name = "btnCancelarEdit";
            btnCancelarEdit.Size = new Size(100, 40);
            btnCancelarEdit.TabIndex = 23;
            btnCancelarEdit.Text = "Cancelar";
            btnCancelarEdit.UseVisualStyleBackColor = true;
            // 
            // TelaEditarJogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelarEdit);
            Controls.Add(txtAnoJogoEdit);
            Controls.Add(txtGeneroJogoEdit);
            Controls.Add(txtPlataformaJogoEdit);
            Controls.Add(txtTituloJogoEdit);
            Controls.Add(pictureBox1);
            Controls.Add(btnSalvarEdit);
            Controls.Add(lblAno);
            Controls.Add(lblGenero);
            Controls.Add(lblPlataforma);
            Controls.Add(lblNome);
            Controls.Add(label2);
            Controls.Add(lblEditando);
            Name = "TelaEditarJogo";
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
        private PictureBox pictureBox1;
        private TextBox txtTituloJogoEdit;
        private TextBox txtPlataformaJogoEdit;
        private TextBox txtGeneroJogoEdit;
        private TextBox txtAnoJogoEdit;
        private Button btnCancelarEdit;
    }
}