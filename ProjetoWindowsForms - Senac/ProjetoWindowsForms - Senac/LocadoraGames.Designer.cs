namespace ProjetoWindowsForms___Senac
{
    partial class FPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblOpcaoLog = new Label();
            btnUser = new Button();
            btnAdm = new Button();
            label1 = new Label();
            lblNomeLocadora = new Label();
            SuspendLayout();
            // 
            // lblOpcaoLog
            // 
            lblOpcaoLog.AutoSize = true;
            lblOpcaoLog.BackColor = Color.LightGray;
            lblOpcaoLog.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblOpcaoLog.ForeColor = Color.Red;
            lblOpcaoLog.Location = new Point(159, 156);
            lblOpcaoLog.Name = "lblOpcaoLog";
            lblOpcaoLog.Size = new Size(507, 29);
            lblOpcaoLog.TabIndex = 0;
            lblOpcaoLog.Text = "Escolha uma das opções para fazer Login";
            // 
            // btnUser
            // 
            btnUser.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btnUser.ForeColor = Color.Red;
            btnUser.Location = new Point(281, 238);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(259, 41);
            btnUser.TabIndex = 1;
            btnUser.Text = "Usuário";
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // btnAdm
            // 
            btnAdm.BackColor = Color.Snow;
            btnAdm.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btnAdm.ForeColor = Color.Red;
            btnAdm.Location = new Point(281, 355);
            btnAdm.Name = "btnAdm";
            btnAdm.Size = new Size(259, 45);
            btnAdm.TabIndex = 2;
            btnAdm.Text = "Administrador";
            btnAdm.UseVisualStyleBackColor = false;
            btnAdm.Click += btnAdm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightGray;
            label1.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(394, 306);
            label1.Name = "label1";
            label1.Size = new Size(32, 21);
            label1.TabIndex = 3;
            label1.Text = "Ou";
            // 
            // lblNomeLocadora
            // 
            lblNomeLocadora.AutoSize = true;
            lblNomeLocadora.BackColor = Color.LightGray;
            lblNomeLocadora.Font = new Font("Modern No. 20", 17.9999981F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblNomeLocadora.ForeColor = Color.Red;
            lblNomeLocadora.Location = new Point(344, 32);
            lblNomeLocadora.Name = "lblNomeLocadora";
            lblNomeLocadora.Size = new Size(145, 25);
            lblNomeLocadora.TabIndex = 4;
            lblNomeLocadora.Text = "Noxus Rental";
            // 
            // FPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.noxus_lol_cinematic_2025_1_1024x437;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNomeLocadora);
            Controls.Add(label1);
            Controls.Add(btnAdm);
            Controls.Add(btnUser);
            Controls.Add(lblOpcaoLog);
            Name = "FPage";
            Text = "Tela de Login";
            Load += FPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOpcaoLog;
        private Button btnUser;
        private Button btnAdm;
        private Label label1;
        private Label lblNomeLocadora;
    }
}
