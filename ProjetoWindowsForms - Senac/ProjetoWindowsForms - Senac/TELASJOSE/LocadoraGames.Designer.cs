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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPage));
            lblOpcaoLog = new Label();
            btnUser = new Button();
            btnAdm = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblOpcaoLog
            // 
            lblOpcaoLog.AutoSize = true;
            lblOpcaoLog.BackColor = Color.Black;
            lblOpcaoLog.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblOpcaoLog.ForeColor = Color.White;
            lblOpcaoLog.Location = new Point(169, 209);
            lblOpcaoLog.Name = "lblOpcaoLog";
            lblOpcaoLog.Size = new Size(507, 29);
            lblOpcaoLog.TabIndex = 0;
            lblOpcaoLog.Text = "Escolha uma das opções para fazer Login";
            // 
            // btnUser
            // 
            btnUser.BackColor = Color.Black;
            btnUser.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btnUser.ForeColor = Color.White;
            btnUser.Location = new Point(282, 272);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(259, 41);
            btnUser.TabIndex = 1;
            btnUser.Text = "Usuário";
            btnUser.UseVisualStyleBackColor = false;
            btnUser.Click += btnUser_Click;
            // 
            // btnAdm
            // 
            btnAdm.BackColor = Color.Black;
            btnAdm.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btnAdm.ForeColor = Color.White;
            btnAdm.Location = new Point(282, 378);
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
            label1.BackColor = Color.Black;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(394, 334);
            label1.Name = "label1";
            label1.Size = new Size(36, 24);
            label1.TabIndex = 3;
            label1.Text = "Ou";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.ChatGPT_Image_4_de_mar__de_2026__14_56_58;
            pictureBox1.Location = new Point(255, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(312, 174);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // FPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 435);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnAdm);
            Controls.Add(btnUser);
            Controls.Add(lblOpcaoLog);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FPage";
            Text = "Tela de Login";
            Load += FPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOpcaoLog;
        private Button btnUser;
        private Button btnAdm;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
