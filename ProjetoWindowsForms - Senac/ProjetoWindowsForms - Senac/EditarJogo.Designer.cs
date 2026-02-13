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
            lblID = new Label();
            lblNome = new Label();
            lblPlataforma = new Label();
            lblGenero = new Label();
            lblAno = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            btnSalvarEdit = new Button();
            btnCancelarEdit = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblEditando
            // 
            lblEditando.AutoSize = true;
            lblEditando.Location = new Point(43, 25);
            lblEditando.Name = "lblEditando";
            lblEditando.Size = new Size(57, 15);
            lblEditando.TabIndex = 0;
            lblEditando.Text = "Editando:";
            lblEditando.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(195, 72);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 1;
            label2.Text = "Informações do Jogo";
            label2.Click += label2_Click;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(195, 111);
            lblID.Name = "lblID";
            lblID.Size = new Size(21, 15);
            lblID.TabIndex = 2;
            lblID.Text = "ID:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(195, 170);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(88, 15);
            lblNome.TabIndex = 3;
            lblNome.Text = "Nome do Jogo:";
            // 
            // lblPlataforma
            // 
            lblPlataforma.AutoSize = true;
            lblPlataforma.Location = new Point(195, 206);
            lblPlataforma.Name = "lblPlataforma";
            lblPlataforma.Size = new Size(68, 15);
            lblPlataforma.TabIndex = 4;
            lblPlataforma.Text = "Plataforma:";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(195, 242);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(48, 15);
            lblGenero.TabIndex = 5;
            lblGenero.Text = "Gênero:";
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Location = new Point(195, 275);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(32, 15);
            lblAno.TabIndex = 6;
            lblAno.Text = "Ano:";
            lblAno.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 323);
            label8.Name = "label8";
            label8.Size = new Size(103, 15);
            label8.TabIndex = 7;
            label8.Text = "Dados da Locação";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 368);
            label9.Name = "label9";
            label9.Size = new Size(89, 15);
            label9.TabIndex = 8;
            label9.Text = "Preço da Diária:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 413);
            label10.Name = "label10";
            label10.Size = new Size(72, 15);
            label10.TabIndex = 9;
            label10.Text = "Quantidade:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(308, 368);
            label11.Name = "label11";
            label11.Size = new Size(99, 15);
            label11.TabIndex = 10;
            label11.Text = "Multa por Atraso:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(308, 409);
            label12.Name = "label12";
            label12.Size = new Size(42, 15);
            label12.TabIndex = 11;
            label12.Text = "Status:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(117, 365);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(116, 409);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(433, 365);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(433, 405);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 15;
            // 
            // btnSalvarEdit
            // 
            btnSalvarEdit.Location = new Point(671, 343);
            btnSalvarEdit.Name = "btnSalvarEdit";
            btnSalvarEdit.Size = new Size(100, 40);
            btnSalvarEdit.TabIndex = 16;
            btnSalvarEdit.Text = "Salvar";
            btnSalvarEdit.UseVisualStyleBackColor = true;
            btnSalvarEdit.Click += button1_Click;
            // 
            // btnCancelarEdit
            // 
            btnCancelarEdit.Location = new Point(671, 395);
            btnCancelarEdit.Name = "btnCancelarEdit";
            btnCancelarEdit.Size = new Size(100, 40);
            btnCancelarEdit.TabIndex = 17;
            btnCancelarEdit.Text = "Cancelar";
            btnCancelarEdit.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 218);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // EditarJogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnCancelarEdit);
            Controls.Add(btnSalvarEdit);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(lblAno);
            Controls.Add(lblGenero);
            Controls.Add(lblPlataforma);
            Controls.Add(lblNome);
            Controls.Add(lblID);
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
        private Label lblID;
        private Label lblNome;
        private Label lblPlataforma;
        private Label lblGenero;
        private Label lblAno;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button btnSalvarEdit;
        private Button btnCancelarEdit;
        private PictureBox pictureBox1;
    }
}