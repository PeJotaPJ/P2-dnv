namespace P22
{
    partial class Cadastro_de_Usuario
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
            txtUsuario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtSenha = new TextBox();
            btCadastrar = new Button();
            btMudarSenha = new Button();
            label3 = new Label();
            txtConfirmar = new TextBox();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(12, 34);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(139, 23);
            txtUsuario.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(12, 84);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(139, 23);
            txtSenha.TabIndex = 2;
            // 
            // btCadastrar
            // 
            btCadastrar.Location = new Point(12, 182);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(75, 23);
            btCadastrar.TabIndex = 4;
            btCadastrar.Text = "Cadastrar";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.Click += btCadastrar_Click;
            // 
            // btMudarSenha
            // 
            btMudarSenha.Location = new Point(114, 182);
            btMudarSenha.Name = "btMudarSenha";
            btMudarSenha.Size = new Size(119, 23);
            btMudarSenha.TabIndex = 5;
            btMudarSenha.Text = "Alterar Senha";
            btMudarSenha.UseVisualStyleBackColor = true;
            btMudarSenha.Click += btMudarSenha_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 123);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 7;
            label3.Text = "Confirme senha";
            // 
            // txtConfirmar
            // 
            txtConfirmar.Location = new Point(12, 141);
            txtConfirmar.Name = "txtConfirmar";
            txtConfirmar.Size = new Size(139, 23);
            txtConfirmar.TabIndex = 6;
            // 
            // Cadastro_de_Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 227);
            Controls.Add(label3);
            Controls.Add(txtConfirmar);
            Controls.Add(btMudarSenha);
            Controls.Add(btCadastrar);
            Controls.Add(label2);
            Controls.Add(txtSenha);
            Controls.Add(label1);
            Controls.Add(txtUsuario);
            Name = "Cadastro_de_Usuario";
            Text = "Cadastro_de_Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private Label label1;
        private Label label2;
        private TextBox txtSenha;
        private Button btCadastrar;
        private Button btMudarSenha;
        private Label label3;
        private TextBox txtConfirmar;
    }
}