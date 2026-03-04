namespace ProjetoWindowsForms___Senac.TELASJOSE
{
    partial class TelaDetalhesJogo
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
            btnFecharD = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnFecharD
            // 
            btnFecharD.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFecharD.Location = new Point(399, 378);
            btnFecharD.Name = "btnFecharD";
            btnFecharD.Size = new Size(108, 40);
            btnFecharD.TabIndex = 23;
            btnFecharD.Text = "Fechar";
            btnFecharD.UseVisualStyleBackColor = true;
            btnFecharD.Click += btnFecharDetalhe;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(410, 291);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(170, 23);
            textBox5.TabIndex = 22;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(410, 242);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(170, 23);
            textBox4.TabIndex = 21;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(410, 198);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(170, 23);
            textBox3.TabIndex = 20;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(410, 152);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(170, 23);
            textBox2.TabIndex = 19;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(410, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 23);
            textBox1.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(265, 289);
            label6.Name = "label6";
            label6.Size = new Size(55, 21);
            label6.TabIndex = 17;
            label6.Text = "Status:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(264, 240);
            label5.Name = "label5";
            label5.Size = new Size(123, 21);
            label5.TabIndex = 16;
            label5.Text = "Data de Entrega:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(265, 196);
            label4.Name = "label4";
            label4.Size = new Size(126, 21);
            label4.TabIndex = 15;
            label4.Text = "Data de Locação:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(265, 150);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 14;
            label3.Text = "Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(265, 101);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 13;
            label2.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(85, 29);
            label1.Name = "label1";
            label1.Size = new Size(180, 30);
            label1.TabIndex = 12;
            label1.Text = "Detalhes do Item";
            // 
            // TelaDetalhesJogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFecharD);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaDetalhesJogo";
            Text = "TelaDetalhesJogo";
            Load += TelaDetalhesJogo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFecharD;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}