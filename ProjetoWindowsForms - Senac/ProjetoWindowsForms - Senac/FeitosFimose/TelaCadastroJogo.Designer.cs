namespace ProjetoWindowsForms___Senac
{
    partial class TelaCadastroJogo
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnVoltar = new Button();
            btnSalvar = new Button();
            txtNomeJogo = new TextBox();
            txtPlataforma = new TextBox();
            txtGenero = new TextBox();
            txtValor = new TextBox();
            txtAnoLancamento = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 82);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 1;
            label2.Text = "Nome do Jogo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 151);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 2;
            label3.Text = "Plataforma:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(33, 230);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 3;
            label4.Text = "Gênero:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(31, 309);
            label5.Name = "label5";
            label5.Size = new Size(117, 20);
            label5.TabIndex = 4;
            label5.Text = "Valor Semanal:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(322, 308);
            label6.Name = "label6";
            label6.Size = new Size(157, 20);
            label6.TabIndex = 5;
            label6.Text = "Ano de Lançamento:";
            // 
            // btnVoltar
            // 
            btnVoltar.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltar.Location = new Point(37, 390);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(100, 40);
            btnVoltar.TabIndex = 6;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(360, 390);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(100, 40);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvarJogo;
            // 
            // txtNomeJogo
            // 
            txtNomeJogo.Location = new Point(32, 103);
            txtNomeJogo.Name = "txtNomeJogo";
            txtNomeJogo.Size = new Size(293, 23);
            txtNomeJogo.TabIndex = 8;
            txtNomeJogo.Click += txtNJogo;
            // 
            // txtPlataforma
            // 
            txtPlataforma.Location = new Point(32, 172);
            txtPlataforma.Name = "txtPlataforma";
            txtPlataforma.Size = new Size(293, 23);
            txtPlataforma.TabIndex = 9;
            txtPlataforma.TextChanged += textBox2_TextChanged;
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(32, 249);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(293, 23);
            txtGenero.TabIndex = 10;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(32, 329);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 11;
            // 
            // txtAnoLancamento
            // 
            txtAnoLancamento.Location = new Point(322, 329);
            txtAnoLancamento.Name = "txtAnoLancamento";
            txtAnoLancamento.Size = new Size(124, 23);
            txtAnoLancamento.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 24);
            label1.Name = "label1";
            label1.Size = new Size(227, 25);
            label1.TabIndex = 13;
            label1.Text = "Cadastrar Novo Item";
            // 
            // TelaCadastroJogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 450);
            Controls.Add(label1);
            Controls.Add(txtAnoLancamento);
            Controls.Add(txtValor);
            Controls.Add(txtGenero);
            Controls.Add(txtPlataforma);
            Controls.Add(txtNomeJogo);
            Controls.Add(btnSalvar);
            Controls.Add(btnVoltar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "TelaCadastroJogo";
            Text = "TelaCadastroJogo";
            Load += CadastroJogo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnVoltar;
        private Button btnSalvar;
        private TextBox txtNomeJogo;
        private TextBox txtPlataforma;
        private TextBox txtGenero;
        private TextBox txtValor;
        private TextBox txtAnoLancamento;
        private Label label1;
    }
}