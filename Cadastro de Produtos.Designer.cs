namespace P22
{
    partial class Cadastro_de_Produtos
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
            txtProduto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPreco = new TextBox();
            label3 = new Label();
            txtDescricao = new TextBox();
            txtCodigo = new TextBox();
            label4 = new Label();
            lbProdutos = new ListBox();
            btSalvar = new Button();
            btExcluir = new Button();
            btAtualizar = new Button();
            SuspendLayout();
            // 
            // txtProduto
            // 
            txtProduto.Location = new Point(26, 35);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(140, 23);
            txtProduto.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 17);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 1;
            label1.Text = "Produto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 73);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 3;
            label2.Text = "Preço";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(26, 91);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(140, 23);
            txtPreco.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 119);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 5;
            label3.Text = "Descrição";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(26, 137);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(140, 99);
            txtDescricao.TabIndex = 4;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(172, 35);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(172, 17);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 7;
            label4.Text = "Código de produto";
            // 
            // lbProdutos
            // 
            lbProdutos.FormattingEnabled = true;
            lbProdutos.Location = new Point(172, 73);
            lbProdutos.Name = "lbProdutos";
            lbProdutos.Size = new Size(162, 154);
            lbProdutos.TabIndex = 8;
            lbProdutos.DoubleClick += lbProdutos_DoubleClick;
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(26, 242);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(75, 23);
            btSalvar.TabIndex = 9;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // btExcluir
            // 
            btExcluir.Location = new Point(107, 242);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(75, 23);
            btExcluir.TabIndex = 10;
            btExcluir.Text = "Excluir";
            btExcluir.UseVisualStyleBackColor = true;
            btExcluir.Click += btExcluir_Click;
            // 
            // btAtualizar
            // 
            btAtualizar.Location = new Point(188, 242);
            btAtualizar.Name = "btAtualizar";
            btAtualizar.Size = new Size(75, 23);
            btAtualizar.TabIndex = 11;
            btAtualizar.Text = "Atualizar";
            btAtualizar.UseVisualStyleBackColor = true;
            btAtualizar.Click += btAtualizar_Click;
            // 
            // Cadastro_de_Produtos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 309);
            Controls.Add(btAtualizar);
            Controls.Add(btExcluir);
            Controls.Add(btSalvar);
            Controls.Add(lbProdutos);
            Controls.Add(label4);
            Controls.Add(txtCodigo);
            Controls.Add(label3);
            Controls.Add(txtDescricao);
            Controls.Add(label2);
            Controls.Add(txtPreco);
            Controls.Add(label1);
            Controls.Add(txtProduto);
            Name = "Cadastro_de_Produtos";
            Text = "Cadastro_de_Produtos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProduto;
        private Label label1;
        private Label label2;
        private TextBox txtPreco;
        private Label label3;
        private TextBox txtDescricao;
        private TextBox txtCodigo;
        private Label label4;
        private ListBox lbProdutos;
        private Button btSalvar;
        private Button btExcluir;
        private Button btAtualizar;
    }
}