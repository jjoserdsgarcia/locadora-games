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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaEditarJogo));
            lblEditando = new Label();
            label2 = new Label();
            lblNome = new Label();
            lblPlataforma = new Label();
            lblGenero = new Label();
            lblAno = new Label();
            btnSalvarEdit = new Button();
            txtTituloJogoEdit = new TextBox();
            txtPlataformaJogoEdit = new TextBox();
            txtGeneroJogoEdit = new TextBox();
            txtAnoJogoEdit = new TextBox();
            btnCancelarEdit = new Button();
            SuspendLayout();
            // 
            // lblEditando
            // 
            lblEditando.AutoSize = true;
            lblEditando.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblEditando.Location = new Point(12, 34);
            lblEditando.Name = "lblEditando";
            lblEditando.Size = new Size(90, 24);
            lblEditando.TabIndex = 0;
            lblEditando.Text = "Editando:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(155, 174);
            label2.Name = "label2";
            label2.Size = new Size(212, 25);
            label2.TabIndex = 1;
            label2.Text = "Informações do Jogo";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Underline);
            lblNome.Location = new Point(114, 222);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(61, 24);
            lblNome.TabIndex = 3;
            lblNome.Text = "Título:";
            // 
            // lblPlataforma
            // 
            lblPlataforma.AutoSize = true;
            lblPlataforma.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Underline);
            lblPlataforma.Location = new Point(73, 262);
            lblPlataforma.Name = "lblPlataforma";
            lblPlataforma.Size = new Size(102, 24);
            lblPlataforma.TabIndex = 4;
            lblPlataforma.Text = "Plataforma:";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Underline);
            lblGenero.Location = new Point(96, 300);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(79, 24);
            lblGenero.TabIndex = 5;
            lblGenero.Text = "Gênero:";
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Underline);
            lblAno.Location = new Point(125, 339);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(50, 24);
            lblAno.TabIndex = 6;
            lblAno.Text = "Ano:";
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
            btnSalvarEdit.Click += btnSalvarEditJogo;
            // 
            // txtTituloJogoEdit
            // 
            txtTituloJogoEdit.Enabled = false;
            txtTituloJogoEdit.Location = new Point(181, 223);
            txtTituloJogoEdit.Name = "txtTituloJogoEdit";
            txtTituloJogoEdit.Size = new Size(165, 23);
            txtTituloJogoEdit.TabIndex = 19;
            // 
            // txtPlataformaJogoEdit
            // 
            txtPlataformaJogoEdit.Location = new Point(181, 262);
            txtPlataformaJogoEdit.Name = "txtPlataformaJogoEdit";
            txtPlataformaJogoEdit.Size = new Size(165, 23);
            txtPlataformaJogoEdit.TabIndex = 20;
            // 
            // txtGeneroJogoEdit
            // 
            txtGeneroJogoEdit.Location = new Point(181, 300);
            txtGeneroJogoEdit.Name = "txtGeneroJogoEdit";
            txtGeneroJogoEdit.Size = new Size(165, 23);
            txtGeneroJogoEdit.TabIndex = 21;
            // 
            // txtAnoJogoEdit
            // 
            txtAnoJogoEdit.Location = new Point(181, 339);
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
            btnCancelarEdit.Click += btnCancelarEdit_Click;
            // 
            // TelaEditarJogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelarEdit);
            Controls.Add(txtAnoJogoEdit);
            Controls.Add(txtGeneroJogoEdit);
            Controls.Add(txtPlataformaJogoEdit);
            Controls.Add(txtTituloJogoEdit);
            Controls.Add(btnSalvarEdit);
            Controls.Add(lblAno);
            Controls.Add(lblGenero);
            Controls.Add(lblPlataforma);
            Controls.Add(lblNome);
            Controls.Add(label2);
            Controls.Add(lblEditando);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaEditarJogo";
            Text = "EditarJogo";
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
        private TextBox txtTituloJogoEdit;
        private TextBox txtPlataformaJogoEdit;
        private TextBox txtGeneroJogoEdit;
        private TextBox txtAnoJogoEdit;
        private Button btnCancelarEdit;
    }
}