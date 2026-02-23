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
            label12 = new Label();
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
            label2.Font = new Font("Modern No. 20", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(195, 54);
            label2.Name = "label2";
            label2.Size = new Size(180, 24);
            label2.TabIndex = 1;
            label2.Text = "Informações do Jogo";
            label2.Click += label2_Click;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Modern No. 20", 15.75F);
            lblID.Location = new Point(195, 111);
            lblID.Name = "lblID";
            lblID.Size = new Size(39, 24);
            lblID.TabIndex = 2;
            lblID.Text = "ID:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Modern No. 20", 15.75F);
            lblNome.Location = new Point(195, 157);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(68, 24);
            lblNome.TabIndex = 3;
            lblNome.Text = "Título:";
            lblNome.Click += lblNome_Click;
            // 
            // lblPlataforma
            // 
            lblPlataforma.AutoSize = true;
            lblPlataforma.Font = new Font("Modern No. 20", 15.75F);
            lblPlataforma.Location = new Point(195, 193);
            lblPlataforma.Name = "lblPlataforma";
            lblPlataforma.Size = new Size(112, 24);
            lblPlataforma.TabIndex = 4;
            lblPlataforma.Text = "Plataforma:";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Font = new Font("Modern No. 20", 15.75F);
            lblGenero.Location = new Point(195, 229);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(73, 24);
            lblGenero.TabIndex = 5;
            lblGenero.Text = "Gênero:";
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Font = new Font("Modern No. 20", 15.75F);
            lblAno.Location = new Point(195, 262);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(49, 24);
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
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(58, 373);
            label12.Name = "label12";
            label12.Size = new Size(42, 15);
            label12.TabIndex = 11;
            label12.Text = "Status:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(116, 370);
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
            Controls.Add(label12);
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
        private Label label12;
        private TextBox textBox4;
        private Button btnSalvarEdit;
        private Button btnCancelarEdit;
        private PictureBox pictureBox1;
        
    }
}