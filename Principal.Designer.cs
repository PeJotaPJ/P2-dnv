namespace P22
{
    partial class frmPrincipal
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
            btCadastroClientes = new Button();
            btCadastroProdutos = new Button();
            btCadastroPedidos = new Button();
            btCadastroUsuario = new Button();
            SuspendLayout();
            // 
            // btCadastroClientes
            // 
            btCadastroClientes.Location = new Point(12, 12);
            btCadastroClientes.Name = "btCadastroClientes";
            btCadastroClientes.Size = new Size(179, 66);
            btCadastroClientes.TabIndex = 0;
            btCadastroClientes.Text = "Cadastro de Clientes";
            btCadastroClientes.UseVisualStyleBackColor = true;
            btCadastroClientes.Click += btCadastroClientes_Click;
            // 
            // btCadastroProdutos
            // 
            btCadastroProdutos.Location = new Point(251, 12);
            btCadastroProdutos.Name = "btCadastroProdutos";
            btCadastroProdutos.Size = new Size(179, 66);
            btCadastroProdutos.TabIndex = 1;
            btCadastroProdutos.Text = "Cadastro de Produtos";
            btCadastroProdutos.UseVisualStyleBackColor = true;
            btCadastroProdutos.Click += btCadastroProdutos_Click;
            // 
            // btCadastroPedidos
            // 
            btCadastroPedidos.Location = new Point(12, 123);
            btCadastroPedidos.Name = "btCadastroPedidos";
            btCadastroPedidos.Size = new Size(179, 66);
            btCadastroPedidos.TabIndex = 2;
            btCadastroPedidos.Text = "Cadastro de Pedidos";
            btCadastroPedidos.UseVisualStyleBackColor = true;
            btCadastroPedidos.Click += btCadastroPedidos_Click;
            // 
            // btCadastroUsuario
            // 
            btCadastroUsuario.Location = new Point(251, 123);
            btCadastroUsuario.Name = "btCadastroUsuario";
            btCadastroUsuario.Size = new Size(179, 66);
            btCadastroUsuario.TabIndex = 3;
            btCadastroUsuario.Text = "Cadastro de Usuario";
            btCadastroUsuario.UseVisualStyleBackColor = true;
            btCadastroUsuario.Click += btCadastroUsuario_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 205);
            Controls.Add(btCadastroUsuario);
            Controls.Add(btCadastroPedidos);
            Controls.Add(btCadastroProdutos);
            Controls.Add(btCadastroClientes);
            Name = "frmPrincipal";
            Text = "Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button btCadastroClientes;
        private Button btCadastroProdutos;
        private Button btCadastroPedidos;
        private Button btCadastroUsuario;
    }
}