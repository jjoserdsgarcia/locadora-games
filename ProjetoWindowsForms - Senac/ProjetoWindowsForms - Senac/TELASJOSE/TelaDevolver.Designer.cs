namespace ProjetoWindowsForms___Senac.TELAS
{
    partial class TelaDevolver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaDevolver));
            btnDevo = new Button();
            btnCancelar = new Button();
            lblCodigoaluguel = new Label();
            txtcodigo = new TextBox();
            lblCliente = new Label();
            txtCliente = new TextBox();
            lblJogo = new Label();
            txtJogo = new TextBox();
            lblDataprevista = new Label();
            txtDataprevista = new TextBox();
            lblDataDevolucao = new Label();
            dtpDataDevo = new DateTimePicker();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // btnDevo
            // 
            btnDevo.Location = new Point(107, 361);
            btnDevo.Name = "btnDevo";
            btnDevo.Size = new Size(221, 59);
            btnDevo.TabIndex = 0;
            btnDevo.Text = "CONFIRMAR DEVOLUÇÃO";
            btnDevo.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(430, 361);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(238, 59);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblCodigoaluguel
            // 
            lblCodigoaluguel.AutoSize = true;
            lblCodigoaluguel.Location = new Point(265, 34);
            lblCodigoaluguel.Name = "lblCodigoaluguel";
            lblCodigoaluguel.Size = new Size(107, 15);
            lblCodigoaluguel.TabIndex = 2;
            lblCodigoaluguel.Text = "Código do Aluguel";
            
            // 
            // txtcodigo
            // 
            txtcodigo.Location = new Point(304, 89);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(139, 23);
            txtcodigo.TabIndex = 3;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(363, 158);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(44, 15);
            lblCliente.TabIndex = 4;
            lblCliente.Text = "Cliente";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(355, 202);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(125, 23);
            txtCliente.TabIndex = 5;
            // 
            // lblJogo
            // 
            lblJogo.AutoSize = true;
            lblJogo.Location = new Point(167, 187);
            lblJogo.Name = "lblJogo";
            lblJogo.Size = new Size(32, 15);
            lblJogo.TabIndex = 6;
            lblJogo.Text = "Jogo";
            // 
            // txtJogo
            // 
            txtJogo.Location = new Point(122, 212);
            txtJogo.Name = "txtJogo";
            txtJogo.Size = new Size(139, 23);
            txtJogo.TabIndex = 7;
            // 
            // lblDataprevista
            // 
            lblDataprevista.AutoSize = true;
            lblDataprevista.Location = new Point(343, 261);
            lblDataprevista.Name = "lblDataprevista";
            lblDataprevista.Size = new Size(75, 15);
            lblDataprevista.TabIndex = 8;
            lblDataprevista.Text = "Data Prevista";
            // 
            // txtDataprevista
            // 
            txtDataprevista.Enabled = false;
            txtDataprevista.Location = new Point(333, 295);
            txtDataprevista.Name = "txtDataprevista";
            txtDataprevista.Size = new Size(109, 23);
            txtDataprevista.TabIndex = 9;
            // 
            // lblDataDevolucao
            // 
            lblDataDevolucao.AutoSize = true;
            lblDataDevolucao.Location = new Point(478, 69);
            lblDataDevolucao.Name = "lblDataDevolucao";
            lblDataDevolucao.Size = new Size(90, 15);
            lblDataDevolucao.TabIndex = 10;
            lblDataDevolucao.Text = "Data Devolução";
            // 
            // dtpDataDevo
            // 
            dtpDataDevo.Location = new Point(474, 101);
            dtpDataDevo.Name = "dtpDataDevo";
            dtpDataDevo.Size = new Size(87, 23);
            dtpDataDevo.TabIndex = 11;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(630, 211);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(127, 43);
            btnCalcular.TabIndex = 12;
            btnCalcular.Text = "CALCULAR MULTA";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // TelaDevolver
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(dtpDataDevo);
            Controls.Add(lblDataDevolucao);
            Controls.Add(txtDataprevista);
            Controls.Add(lblDataprevista);
            Controls.Add(txtJogo);
            Controls.Add(lblJogo);
            Controls.Add(txtCliente);
            Controls.Add(lblCliente);
            Controls.Add(txtcodigo);
            Controls.Add(lblCodigoaluguel);
            Controls.Add(btnCancelar);
            Controls.Add(btnDevo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaDevolver";
            Text = "Usuário - Devolução";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDevo;
        private Button btnCancelar;
        private Label lblCodigoaluguel;
        private TextBox txtcodigo;
        private Label lblCliente;
        private TextBox txtCliente;
        private Label lblJogo;
        private TextBox txtJogo;
        private Label lblDataprevista;
        private TextBox txtDataprevista;
        private Label lblDataDevolucao;
        private DateTimePicker dtpDataDevo;
        private Button btnCalcular;
    }
}