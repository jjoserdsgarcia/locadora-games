namespace ProjetoWindowsForms___Senac
{
    partial class LoginADM
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
            lblUsuarioADM = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lblSenhaADM = new Label();
            btnENTRARADM = new Button();
            SuspendLayout();
            // 
            // lblUsuarioADM
            // 
            lblUsuarioADM.AutoSize = true;
            lblUsuarioADM.BackColor = Color.Black;
            lblUsuarioADM.Font = new Font("Modern No. 20", 17.9999981F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblUsuarioADM.ForeColor = Color.Red;
            lblUsuarioADM.Location = new Point(201, 84);
            lblUsuarioADM.Name = "lblUsuarioADM";
            lblUsuarioADM.Size = new Size(89, 25);
            lblUsuarioADM.TabIndex = 0;
            lblUsuarioADM.Text = "Usuário";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(201, 128);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(354, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Underline, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(201, 278);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(354, 24);
            textBox2.TabIndex = 3;
            // 
            // lblSenhaADM
            // 
            lblSenhaADM.AutoSize = true;
            lblSenhaADM.BackColor = Color.Black;
            lblSenhaADM.Font = new Font("Modern No. 20", 17.9999981F, FontStyle.Underline);
            lblSenhaADM.ForeColor = Color.Red;
            lblSenhaADM.Location = new Point(201, 232);
            lblSenhaADM.Name = "lblSenhaADM";
            lblSenhaADM.Size = new Size(72, 25);
            lblSenhaADM.TabIndex = 2;
            lblSenhaADM.Text = "Senha";
            // 
            // btnENTRARADM
            // 
            btnENTRARADM.Location = new Point(259, 357);
            btnENTRARADM.Name = "btnENTRARADM";
            btnENTRARADM.Size = new Size(222, 48);
            btnENTRARADM.TabIndex = 4;
            btnENTRARADM.Text = "Entrar";
            btnENTRARADM.UseVisualStyleBackColor = true;
            // 
            // LoginADM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(btnENTRARADM);
            Controls.Add(textBox2);
            Controls.Add(lblSenhaADM);
            Controls.Add(textBox1);
            Controls.Add(lblUsuarioADM);
            Name = "LoginADM";
            Text = "LoginADM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuarioADM;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lblSenhaADM;
        private Button btnENTRARADM;
    }
}