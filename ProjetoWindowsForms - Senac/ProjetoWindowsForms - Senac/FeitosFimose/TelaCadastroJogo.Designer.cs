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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroJogo));
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            btnVoltar = new Button();
            btnSalvar = new Button();
            txtNomeJogo = new TextBox();
            txtPlataforma = new TextBox();
            txtGenero = new TextBox();
            label1 = new Label();
            dtpAnoLancamentoCadastro = new DateTimePicker();
            gbCategoria = new GroupBox();
            rbtnBronze = new RadioButton();
            rbtnPrata = new RadioButton();
            rbtnOuro = new RadioButton();
            gbCategoria.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 80);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 1;
            label2.Text = "Nome do Jogo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 149);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 2;
            label3.Text = "Plataforma:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 226);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 3;
            label4.Text = "Gênero:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(32, 298);
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
            btnSalvar.Location = new Point(198, 390);
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
            txtNomeJogo.Size = new Size(157, 23);
            txtNomeJogo.TabIndex = 8;
            // 
            // txtPlataforma
            // 
            txtPlataforma.Location = new Point(32, 172);
            txtPlataforma.Name = "txtPlataforma";
            txtPlataforma.Size = new Size(157, 23);
            txtPlataforma.TabIndex = 9;
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(32, 249);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(157, 23);
            txtGenero.TabIndex = 10;
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
            // dtpAnoLancamentoCadastro
            // 
            dtpAnoLancamentoCadastro.Format = DateTimePickerFormat.Short;
            dtpAnoLancamentoCadastro.Location = new Point(32, 331);
            dtpAnoLancamentoCadastro.Name = "dtpAnoLancamentoCadastro";
            dtpAnoLancamentoCadastro.Size = new Size(102, 23);
            dtpAnoLancamentoCadastro.TabIndex = 14;
            // 
            // gbCategoria
            // 
            gbCategoria.BackColor = SystemColors.ButtonHighlight;
            gbCategoria.Controls.Add(rbtnOuro);
            gbCategoria.Controls.Add(rbtnPrata);
            gbCategoria.Controls.Add(rbtnBronze);
            gbCategoria.Location = new Point(248, 80);
            gbCategoria.Name = "gbCategoria";
            gbCategoria.Size = new Size(236, 78);
            gbCategoria.TabIndex = 15;
            gbCategoria.TabStop = false;
            gbCategoria.Text = "Categoria";
            // 
            // rbtnBronze
            // 
            rbtnBronze.AutoSize = true;
            rbtnBronze.Checked = true;
            rbtnBronze.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtnBronze.Location = new Point(6, 32);
            rbtnBronze.Name = "rbtnBronze";
            rbtnBronze.Size = new Size(67, 20);
            rbtnBronze.TabIndex = 0;
            rbtnBronze.TabStop = true;
            rbtnBronze.Text = "Bronze";
            rbtnBronze.UseVisualStyleBackColor = true;
            rbtnBronze.CheckedChanged += rbtnBronze_CheckedChanged;
            // 
            // rbtnPrata
            // 
            rbtnPrata.AutoSize = true;
            rbtnPrata.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtnPrata.Location = new Point(87, 32);
            rbtnPrata.Name = "rbtnPrata";
            rbtnPrata.Size = new Size(57, 20);
            rbtnPrata.TabIndex = 1;
            rbtnPrata.Text = "Prata";
            rbtnPrata.UseVisualStyleBackColor = true;
            // 
            // rbtnOuro
            // 
            rbtnOuro.AutoSize = true;
            rbtnOuro.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtnOuro.Location = new Point(169, 32);
            rbtnOuro.Name = "rbtnOuro";
            rbtnOuro.Size = new Size(54, 20);
            rbtnOuro.TabIndex = 2;
            rbtnOuro.Text = "Ouro";
            rbtnOuro.UseVisualStyleBackColor = true;
            // 
            // TelaCadastroJogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(755, 450);
            Controls.Add(gbCategoria);
            Controls.Add(dtpAnoLancamentoCadastro);
            Controls.Add(label1);
            Controls.Add(txtGenero);
            Controls.Add(txtPlataforma);
            Controls.Add(txtNomeJogo);
            Controls.Add(btnSalvar);
            Controls.Add(btnVoltar);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaCadastroJogo";
            Text = "TelaCadastroJogo";
            gbCategoria.ResumeLayout(false);
            gbCategoria.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Button btnVoltar;
        private Button btnSalvar;
        private TextBox txtNomeJogo;
        private TextBox txtPlataforma;
        private TextBox txtGenero;
        private Label label1;
        private DateTimePicker dtpAnoLancamentoCadastro;
        private GroupBox gbCategoria;
        private RadioButton rbtnOuro;
        private RadioButton rbtnPrata;
        private RadioButton rbtnBronze;
    }
}