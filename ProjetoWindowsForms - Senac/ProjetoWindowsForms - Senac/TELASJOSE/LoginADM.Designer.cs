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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginADM));
            lblUsuarioADM = new Label();
            txtADMLOGIN = new TextBox();
            txtADMSENHA = new TextBox();
            lblSenhaADM = new Label();
            btnENTRARADM = new Button();
            btnSAIRADMLOG = new Button();
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
            // txtADMLOGIN
            // 
            txtADMLOGIN.Location = new Point(201, 128);
            txtADMLOGIN.Name = "txtADMLOGIN";
            txtADMLOGIN.Size = new Size(354, 23);
            txtADMLOGIN.TabIndex = 1;
            // 
            // txtADMSENHA
            // 
            txtADMSENHA.Font = new Font("Segoe UI", 11.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            txtADMSENHA.Location = new Point(201, 278);
            txtADMSENHA.Name = "txtADMSENHA";
            txtADMSENHA.PasswordChar = '*';
            txtADMSENHA.Size = new Size(354, 27);
            txtADMSENHA.TabIndex = 3;
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
            btnENTRARADM.BackColor = Color.LawnGreen;
            btnENTRARADM.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnENTRARADM.Location = new Point(447, 349);
            btnENTRARADM.Name = "btnENTRARADM";
            btnENTRARADM.Size = new Size(222, 48);
            btnENTRARADM.TabIndex = 4;
            btnENTRARADM.Text = "ENTRAR";
            btnENTRARADM.UseVisualStyleBackColor = false;
            btnENTRARADM.Click += btnENTRARADM_Click;
            // 
            // btnSAIRADMLOG
            // 
            btnSAIRADMLOG.BackColor = Color.Red;
            btnSAIRADMLOG.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSAIRADMLOG.ForeColor = SystemColors.ActiveCaptionText;
            btnSAIRADMLOG.Location = new Point(137, 349);
            btnSAIRADMLOG.Name = "btnSAIRADMLOG";
            btnSAIRADMLOG.Size = new Size(222, 48);
            btnSAIRADMLOG.TabIndex = 5;
            btnSAIRADMLOG.Text = "SAIR";
            btnSAIRADMLOG.UseVisualStyleBackColor = false;
            btnSAIRADMLOG.Click += btnSAIRADMLOG_Click;
            // 
            // LoginADM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSAIRADMLOG);
            Controls.Add(btnENTRARADM);
            Controls.Add(txtADMSENHA);
            Controls.Add(lblSenhaADM);
            Controls.Add(txtADMLOGIN);
            Controls.Add(lblUsuarioADM);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginADM";
            Text = "LoginADM";
            Load += LoginADM_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuarioADM;
        private TextBox txtADMLOGIN;
        private TextBox txtADMSENHA;
        private Label lblSenhaADM;
        private Button btnENTRARADM;
        private Button btnSAIRADMLOG;
    }
}