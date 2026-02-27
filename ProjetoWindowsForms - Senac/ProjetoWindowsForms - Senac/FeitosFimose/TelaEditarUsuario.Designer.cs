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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtBuscarUsuarioEditar = new TextBox();
            button1 = new Button();
            txtNomeEditUsuario = new TextBox();
            txtEmailEditUsuario = new TextBox();
            txtTelefoneEditUsuario = new TextBox();
            button3 = new Button();
            btnCancelarEditUsuario = new Button();
            label6 = new Label();
            txtIdEditUsuario = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 36);
            label1.Name = "label1";
            label1.Size = new Size(113, 16);
            label1.TabIndex = 0;
            label1.Text = "Buscar Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 62);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 1;
            label2.Text = "ID ou E-Mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(56, 208);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "Nome:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(54, 246);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 3;
            label4.Text = "E-Mail:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(36, 287);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 4;
            label5.Text = "Telefone:";
            // 
            // txtBuscarUsuarioEditar
            // 
            txtBuscarUsuarioEditar.Location = new Point(147, 60);
            txtBuscarUsuarioEditar.Name = "txtBuscarUsuarioEditar";
            txtBuscarUsuarioEditar.Size = new Size(337, 23);
            txtBuscarUsuarioEditar.TabIndex = 5;
            txtBuscarUsuarioEditar.Text = " ";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(542, 56);
            button1.Name = "button1";
            button1.Padding = new Padding(15, 0, 15, 5);
            button1.Size = new Size(100, 30);
            button1.TabIndex = 6;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnBuscarUsuarioEdit;
            // 
            // txtNomeEditUsuario
            // 
            txtNomeEditUsuario.Location = new Point(147, 208);
            txtNomeEditUsuario.Name = "txtNomeEditUsuario";
            txtNomeEditUsuario.Size = new Size(232, 23);
            txtNomeEditUsuario.TabIndex = 7;
            // 
            // txtEmailEditUsuario
            // 
            txtEmailEditUsuario.Location = new Point(147, 247);
            txtEmailEditUsuario.Name = "txtEmailEditUsuario";
            txtEmailEditUsuario.Size = new Size(232, 23);
            txtEmailEditUsuario.TabIndex = 8;
            // 
            // txtTelefoneEditUsuario
            // 
            txtTelefoneEditUsuario.Location = new Point(147, 288);
            txtTelefoneEditUsuario.Name = "txtTelefoneEditUsuario";
            txtTelefoneEditUsuario.Size = new Size(232, 23);
            txtTelefoneEditUsuario.TabIndex = 9;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(542, 361);
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
            btnCancelarEditUsuario.Location = new Point(386, 361);
            btnCancelarEditUsuario.Name = "btnCancelarEditUsuario";
            btnCancelarEditUsuario.Padding = new Padding(15, 0, 15, 0);
            btnCancelarEditUsuario.Size = new Size(131, 40);
            btnCancelarEditUsuario.TabIndex = 12;
            btnCancelarEditUsuario.Text = "Cancelar";
            btnCancelarEditUsuario.UseVisualStyleBackColor = true;
            btnCancelarEditUsuario.Click += btnCancelarEditarUsuario;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(81, 171);
            label6.Name = "label6";
            label6.Size = new Size(30, 20);
            label6.TabIndex = 13;
            label6.Text = "ID:";
            // 
            // txtIdEditUsuario
            // 
            txtIdEditUsuario.Location = new Point(147, 171);
            txtIdEditUsuario.Name = "txtIdEditUsuario";
            txtIdEditUsuario.Size = new Size(54, 23);
            txtIdEditUsuario.TabIndex = 14;
            txtIdEditUsuario.Visible = false;
            // 
            // TelaEditarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 450);
            Controls.Add(txtIdEditUsuario);
            Controls.Add(label6);
            Controls.Add(btnCancelarEditUsuario);
            Controls.Add(button3);
            Controls.Add(txtTelefoneEditUsuario);
            Controls.Add(txtEmailEditUsuario);
            Controls.Add(txtNomeEditUsuario);
            Controls.Add(button1);
            Controls.Add(txtBuscarUsuarioEditar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaEditarUsuario";
            Text = "EditarUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtBuscarUsuarioEditar;
        private Button button1;
        private TextBox txtNomeEditUsuario;
        private TextBox txtEmailEditUsuario;
        private TextBox txtTelefoneEditUsuario;
        private Button button3;
        private Button btnCancelarEditUsuario;
        private Label label6;
        private TextBox txtIdEditUsuario;
    }
}