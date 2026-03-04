namespace ProjetoWindowsForms___Senac
{
    partial class TelaEditarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaEditarUsuario));
            lblEditandoUsuario = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNomeEditUsuario = new TextBox();
            txtEmailEditUsuario = new TextBox();
            txtTelefoneEditUsuario = new TextBox();
            button3 = new Button();
            btnCancelarEditUsuario = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblEditandoUsuario
            // 
            lblEditandoUsuario.AutoSize = true;
            lblEditandoUsuario.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEditandoUsuario.Location = new Point(33, 21);
            lblEditandoUsuario.Name = "lblEditandoUsuario";
            lblEditandoUsuario.Size = new Size(149, 20);
            lblEditandoUsuario.TabIndex = 0;
            lblEditandoUsuario.Text = "Editando o Usuário:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(51, 179);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "Nome:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(51, 226);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 3;
            label4.Text = "E-Mail:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(33, 271);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 4;
            label5.Text = "Telefone:";
            // 
            // txtNomeEditUsuario
            // 
            txtNomeEditUsuario.Enabled = false;
            txtNomeEditUsuario.Location = new Point(127, 177);
            txtNomeEditUsuario.Name = "txtNomeEditUsuario";
            txtNomeEditUsuario.Size = new Size(232, 23);
            txtNomeEditUsuario.TabIndex = 7;
            // 
            // txtEmailEditUsuario
            // 
            txtEmailEditUsuario.Location = new Point(127, 226);
            txtEmailEditUsuario.Name = "txtEmailEditUsuario";
            txtEmailEditUsuario.Size = new Size(232, 23);
            txtEmailEditUsuario.TabIndex = 8;
            // 
            // txtTelefoneEditUsuario
            // 
            txtTelefoneEditUsuario.Location = new Point(127, 271);
            txtTelefoneEditUsuario.Name = "txtTelefoneEditUsuario";
            txtTelefoneEditUsuario.Size = new Size(232, 23);
            txtTelefoneEditUsuario.TabIndex = 9;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(203, 367);
            button3.Name = "button3";
            button3.Padding = new Padding(15, 0, 15, 0);
            button3.Size = new Size(131, 40);
            button3.TabIndex = 11;
            button3.Text = "Salvar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnSalvarEditUsuario;
            // 
            // btnCancelarEditUsuario
            // 
            btnCancelarEditUsuario.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelarEditUsuario.Location = new Point(47, 367);
            btnCancelarEditUsuario.Name = "btnCancelarEditUsuario";
            btnCancelarEditUsuario.Padding = new Padding(15, 0, 15, 0);
            btnCancelarEditUsuario.Size = new Size(131, 40);
            btnCancelarEditUsuario.TabIndex = 12;
            btnCancelarEditUsuario.Text = "Cancelar";
            btnCancelarEditUsuario.UseVisualStyleBackColor = true;
            btnCancelarEditUsuario.Click += btnCancelarEditarUsuario;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(127, 111);
            label1.Name = "label1";
            label1.Size = new Size(226, 25);
            label1.TabIndex = 15;
            label1.Text = "Informações do Usuário";
            // 
            // TelaEditarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(804, 450);
            Controls.Add(label1);
            Controls.Add(btnCancelarEditUsuario);
            Controls.Add(button3);
            Controls.Add(txtTelefoneEditUsuario);
            Controls.Add(txtEmailEditUsuario);
            Controls.Add(txtNomeEditUsuario);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblEditandoUsuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaEditarUsuario";
            Text = "EditarUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEditandoUsuario;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNomeEditUsuario;
        private TextBox txtEmailEditUsuario;
        private TextBox txtTelefoneEditUsuario;
        private Button button3;
        private Button btnCancelarEditUsuario;
        private Label label1;
    }
}