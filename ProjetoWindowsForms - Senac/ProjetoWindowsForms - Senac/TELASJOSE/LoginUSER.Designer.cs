namespace ProjetoWindowsForms___Senac
{
    partial class LoginUSER
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
            lblCPFUSER = new Label();
            textBox1 = new TextBox();
            btnPROSSEGUIRUSER = new Button();
            btnVOLTARUSER = new Button();
            SuspendLayout();
            // 
            // lblCPFUSER
            // 
            lblCPFUSER.AutoSize = true;
            lblCPFUSER.Font = new Font("Modern No. 20", 17.9999981F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblCPFUSER.Location = new Point(290, 166);
            lblCPFUSER.Name = "lblCPFUSER";
            lblCPFUSER.Size = new Size(170, 25);
            lblCPFUSER.TabIndex = 0;
            lblCPFUSER.Text = "CPF do Usuário";
            lblCPFUSER.Click += lblCPFUSER_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(290, 217);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 23);
            textBox1.TabIndex = 1;
            // 
            // btnPROSSEGUIRUSER
            // 
            btnPROSSEGUIRUSER.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPROSSEGUIRUSER.Location = new Point(513, 369);
            btnPROSSEGUIRUSER.Name = "btnPROSSEGUIRUSER";
            btnPROSSEGUIRUSER.Size = new Size(235, 61);
            btnPROSSEGUIRUSER.TabIndex = 4;
            btnPROSSEGUIRUSER.Text = "Prosseguir";
            btnPROSSEGUIRUSER.UseVisualStyleBackColor = true;
            btnPROSSEGUIRUSER.Click += btnPROSSEGUIRUSER_Click;
            // 
            // btnVOLTARUSER
            // 
            btnVOLTARUSER.Font = new Font("Modern No. 20", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVOLTARUSER.Location = new Point(31, 373);
            btnVOLTARUSER.Name = "btnVOLTARUSER";
            btnVOLTARUSER.Size = new Size(209, 54);
            btnVOLTARUSER.TabIndex = 5;
            btnVOLTARUSER.Text = "Voltar";
            btnVOLTARUSER.UseVisualStyleBackColor = true;
            // 
            // LoginUSER
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVOLTARUSER);
            Controls.Add(btnPROSSEGUIRUSER);
            Controls.Add(textBox1);
            Controls.Add(lblCPFUSER);
            Name = "LoginUSER";
            Text = "Login de Usuário";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCPFUSER;
        private TextBox textBox1;
        private Button btnPROSSEGUIRUSER;
        private Button btnVOLTARUSER;
    }
}