namespace ProjetoWindowsForms___Senac
{
    partial class ListaUsuarios
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
            ListaUsuario = new DataGridView();
            btnCadastrarUsuario = new Button();
            btnExcluirUsuario = new Button();
            btnEditarUsuario = new Button();
            ((System.ComponentModel.ISupportInitialize)ListaUsuario).BeginInit();
            SuspendLayout();
            // 
            // ListaUsuario
            // 
            ListaUsuario.AllowUserToAddRows = false;
            ListaUsuario.AllowUserToDeleteRows = false;
            ListaUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListaUsuario.Location = new Point(12, 12);
            ListaUsuario.Name = "ListaUsuario";
            ListaUsuario.ReadOnly = true;
            ListaUsuario.Size = new Size(776, 277);
            ListaUsuario.TabIndex = 0;
            // 
            // btnCadastrarUsuario
            // 
            btnCadastrarUsuario.Location = new Point(29, 357);
            btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            btnCadastrarUsuario.Size = new Size(108, 40);
            btnCadastrarUsuario.TabIndex = 1;
            btnCadastrarUsuario.Text = "Cadastrar";
            btnCadastrarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnExcluirUsuario
            // 
            btnExcluirUsuario.Location = new Point(660, 357);
            btnExcluirUsuario.Name = "btnExcluirUsuario";
            btnExcluirUsuario.Size = new Size(108, 40);
            btnExcluirUsuario.TabIndex = 2;
            btnExcluirUsuario.Text = "Excluir";
            btnExcluirUsuario.UseVisualStyleBackColor = true;
            // 
            // btnEditarUsuario
            // 
            btnEditarUsuario.Location = new Point(530, 357);
            btnEditarUsuario.Name = "btnEditarUsuario";
            btnEditarUsuario.Size = new Size(108, 40);
            btnEditarUsuario.TabIndex = 3;
            btnEditarUsuario.Text = "Editar";
            btnEditarUsuario.UseVisualStyleBackColor = true;
            // 
            // ListaUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditarUsuario);
            Controls.Add(btnExcluirUsuario);
            Controls.Add(btnCadastrarUsuario);
            Controls.Add(ListaUsuario);
            Name = "ListaUsuarios";
            Text = "ListaUsuarios";
            ((System.ComponentModel.ISupportInitialize)ListaUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ListaUsuario;
        private Button btnCadastrarUsuario;
        private Button btnExcluirUsuario;
        private Button btnEditarUsuario;
    }
}