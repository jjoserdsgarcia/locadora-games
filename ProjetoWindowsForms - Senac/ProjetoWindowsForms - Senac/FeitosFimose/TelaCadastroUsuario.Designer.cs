namespace ProjetoWindowsForms___Senac
{
    partial class TelaCadastroUsuario
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
            button1 = new Button();
            button2 = new Button();
            label6 = new Label();
            txtNomeCadastroUser = new TextBox();
            txtCPFCadastroUser = new TextBox();
            txtEmailCadastroUser = new TextBox();
            txtTelefoneCadastroUser = new TextBox();
            dtpData = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 74);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(45, 132);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 1;
            label2.Text = "CPF:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(45, 187);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(45, 249);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 3;
            label4.Text = "Telefone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(45, 311);
            label5.Name = "label5";
            label5.Size = new Size(158, 20);
            label5.TabIndex = 4;
            label5.Text = "Data de Nascimento:";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(62, 388);
            button1.Name = "button1";
            button1.Size = new Size(95, 40);
            button1.TabIndex = 5;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCancelarCadUsuario;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(616, 388);
            button2.Name = "button2";
            button2.Size = new Size(90, 40);
            button2.TabIndex = 6;
            button2.Text = "Salvar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnSalvarCadastroUser;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(41, 21);
            label6.Name = "label6";
            label6.Size = new Size(361, 25);
            label6.TabIndex = 7;
            label6.Text = "Digite as informações do Usuário";
            // 
            // txtNomeCadastroUser
            // 
            txtNomeCadastroUser.Location = new Point(45, 92);
            txtNomeCadastroUser.Name = "txtNomeCadastroUser";
            txtNomeCadastroUser.Size = new Size(241, 23);
            txtNomeCadastroUser.TabIndex = 8;
            // 
            // txtCPFCadastroUser
            // 
            txtCPFCadastroUser.Location = new Point(45, 152);
            txtCPFCadastroUser.Name = "txtCPFCadastroUser";
            txtCPFCadastroUser.Size = new Size(241, 23);
            txtCPFCadastroUser.TabIndex = 9;
            txtCPFCadastroUser.TextChanged += txtCPFCadastroUser_TextChanged;
            // 
            // txtEmailCadastroUser
            // 
            txtEmailCadastroUser.Location = new Point(45, 208);
            txtEmailCadastroUser.Name = "txtEmailCadastroUser";
            txtEmailCadastroUser.Size = new Size(241, 23);
            txtEmailCadastroUser.TabIndex = 10;
            // 
            // txtTelefoneCadastroUser
            // 
            txtTelefoneCadastroUser.Location = new Point(45, 270);
            txtTelefoneCadastroUser.Name = "txtTelefoneCadastroUser";
            txtTelefoneCadastroUser.Size = new Size(241, 23);
            txtTelefoneCadastroUser.TabIndex = 11;
            // 
            // dtpData
            // 
            dtpData.Location = new Point(45, 332);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(241, 23);
            dtpData.TabIndex = 13;
            // 
            // TelaCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpData);
            Controls.Add(txtTelefoneCadastroUser);
            Controls.Add(txtEmailCadastroUser);
            Controls.Add(txtCPFCadastroUser);
            Controls.Add(txtNomeCadastroUser);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaCadastroUsuario";
            Text = "Tela Cadastro Usuário ";
            Load += CadastroUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private Label label6;
        private TextBox txtNomeCadastroUser;
        private TextBox txtCPFCadastroUser;
        private TextBox txtEmailCadastroUser;
        private TextBox txtTelefoneCadastroUser;
        private DateTimePicker dtpData;
    }
}