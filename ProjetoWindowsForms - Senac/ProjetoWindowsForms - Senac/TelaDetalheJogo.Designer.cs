namespace ProjetoWindowsForms___Senac
{
    partial class TelaDetalheJogo
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
            txtStatusDetalhe = new TextBox();
            txtEntregaDetalhe = new TextBox();
            txtLocacaoDetalhe = new TextBox();
            txtClienteDetalhe = new TextBox();
            txtNomeDetalhe = new TextBox();
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtStatusDetalhe
            // 
            txtStatusDetalhe.Enabled = false;
            txtStatusDetalhe.Location = new Point(453, 287);
            txtStatusDetalhe.Name = "txtStatusDetalhe";
            txtStatusDetalhe.Size = new Size(178, 23);
            txtStatusDetalhe.TabIndex = 28;
            // 
            // txtEntregaDetalhe
            // 
            txtEntregaDetalhe.Enabled = false;
            txtEntregaDetalhe.Location = new Point(453, 244);
            txtEntregaDetalhe.Name = "txtEntregaDetalhe";
            txtEntregaDetalhe.Size = new Size(178, 23);
            txtEntregaDetalhe.TabIndex = 27;
            // 
            // txtLocacaoDetalhe
            // 
            txtLocacaoDetalhe.Enabled = false;
            txtLocacaoDetalhe.Location = new Point(453, 196);
            txtLocacaoDetalhe.Name = "txtLocacaoDetalhe";
            txtLocacaoDetalhe.Size = new Size(178, 23);
            txtLocacaoDetalhe.TabIndex = 26;
            // 
            // txtClienteDetalhe
            // 
            txtClienteDetalhe.Enabled = false;
            txtClienteDetalhe.Location = new Point(453, 146);
            txtClienteDetalhe.Name = "txtClienteDetalhe";
            txtClienteDetalhe.Size = new Size(178, 23);
            txtClienteDetalhe.TabIndex = 25;
            // 
            // txtNomeDetalhe
            // 
            txtNomeDetalhe.Enabled = false;
            txtNomeDetalhe.Location = new Point(453, 95);
            txtNomeDetalhe.Name = "txtNomeDetalhe";
            txtNomeDetalhe.Size = new Size(178, 23);
            txtNomeDetalhe.TabIndex = 24;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(461, 382);
            button1.Name = "button1";
            button1.Size = new Size(108, 40);
            button1.TabIndex = 23;
            button1.Text = "Fechar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnFecharDetalhar;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(345, 290);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 22;
            label6.Text = "Status:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(294, 244);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 21;
            label5.Text = "Data de Entrega:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(290, 199);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 20;
            label4.Text = "Data da Locação:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(340, 149);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 19;
            label3.Text = "Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(299, 95);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 18;
            label2.Text = "Nome do Jogo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(169, 29);
            label1.Name = "label1";
            label1.Size = new Size(154, 25);
            label1.TabIndex = 17;
            label1.Text = "Detalhes do Item";
            // 
            // TelaDetalheJogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtStatusDetalhe);
            Controls.Add(txtEntregaDetalhe);
            Controls.Add(txtLocacaoDetalhe);
            Controls.Add(txtClienteDetalhe);
            Controls.Add(txtNomeDetalhe);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaDetalheJogo";
            Text = "TelaDetalheJogo";
            Load += TelaDetalheJogo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStatusDetalhe;
        private TextBox txtEntregaDetalhe;
        private TextBox txtLocacaoDetalhe;
        private TextBox txtClienteDetalhe;
        private TextBox txtNomeDetalhe;
        private Button button1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}