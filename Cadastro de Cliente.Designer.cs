﻿namespace P22
{
    partial class Cadastro_de_Cliente
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
            txtNome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtTelefone = new MaskedTextBox();
            label6 = new Label();
            txtWhatsapp = new MaskedTextBox();
            txtLogradouro = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtNumero = new TextBox();
            label9 = new Label();
            txtBairro = new TextBox();
            label10 = new Label();
            txtCidade = new TextBox();
            label11 = new Label();
            txtEstado = new TextBox();
            btSalvar = new Button();
            txtCEP = new TextBox();
            btBuscarCEP = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btExcluir = new Button();
            lbClientes = new ListBox();
            txtCPF = new TextBox();
            btAtualizar = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(71, 60);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(154, 23);
            txtNome.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 42);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 100);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 3;
            label2.Text = "CPF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 148);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(71, 166);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(154, 23);
            txtEmail.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 208);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 8;
            label4.Text = "CEP";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(294, 42);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 10;
            label5.Text = "Telefone";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(294, 60);
            txtTelefone.Mask = "(99) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(100, 23);
            txtTelefone.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(294, 103);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 12;
            label6.Text = "Whatsapp";
            // 
            // txtWhatsapp
            // 
            txtWhatsapp.Location = new Point(294, 121);
            txtWhatsapp.Mask = "(99) 00000-0000";
            txtWhatsapp.Name = "txtWhatsapp";
            txtWhatsapp.Size = new Size(100, 23);
            txtWhatsapp.TabIndex = 11;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(71, 297);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(100, 23);
            txtLogradouro.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(71, 279);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 14;
            label7.Text = "Logradouro";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(202, 279);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 16;
            label8.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(202, 297);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(308, 279);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 18;
            label9.Text = "Bairro";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(308, 297);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(100, 23);
            txtBairro.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(414, 279);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 20;
            label10.Text = "Cidade";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(414, 297);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(100, 23);
            txtCidade.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(520, 279);
            label11.Name = "label11";
            label11.Size = new Size(42, 15);
            label11.TabIndex = 22;
            label11.Text = "Estado";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(520, 297);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(100, 23);
            txtEstado.TabIndex = 21;
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(545, 365);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(75, 23);
            btSalvar.TabIndex = 23;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(71, 226);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(100, 23);
            txtCEP.TabIndex = 24;
            // 
            // btBuscarCEP
            // 
            btBuscarCEP.Location = new Point(96, 255);
            btBuscarCEP.Name = "btBuscarCEP";
            btBuscarCEP.Size = new Size(75, 23);
            btBuscarCEP.TabIndex = 25;
            btBuscarCEP.Text = "Buscar CEP";
            btBuscarCEP.UseVisualStyleBackColor = true;
            btBuscarCEP.Click += btBuscarCEP_Click;
            // 
            // btExcluir
            // 
            btExcluir.Location = new Point(464, 365);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(75, 23);
            btExcluir.TabIndex = 27;
            btExcluir.Text = "Excluir";
            btExcluir.UseVisualStyleBackColor = true;
            btExcluir.Click += btExcluir_Click;
            // 
            // lbClientes
            // 
            lbClientes.FormattingEnabled = true;
            lbClientes.Location = new Point(656, 50);
            lbClientes.Name = "lbClientes";
            lbClientes.Size = new Size(185, 229);
            lbClientes.TabIndex = 28;
            lbClientes.SelectedIndexChanged += lbClientes_SelectedIndexChanged;
            lbClientes.DoubleClick += lbClientes_DoubleClick;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(71, 118);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(154, 23);
            txtCPF.TabIndex = 29;
            // 
            // btAtualizar
            // 
            btAtualizar.Location = new Point(626, 365);
            btAtualizar.Name = "btAtualizar";
            btAtualizar.Size = new Size(75, 23);
            btAtualizar.TabIndex = 30;
            btAtualizar.Text = "Atualizar";
            btAtualizar.UseVisualStyleBackColor = true;
            btAtualizar.Click += btAtualizar_Click;
            // 
            // Cadastro_de_Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 391);
            Controls.Add(btAtualizar);
            Controls.Add(txtCPF);
            Controls.Add(lbClientes);
            Controls.Add(btExcluir);
            Controls.Add(btBuscarCEP);
            Controls.Add(txtCEP);
            Controls.Add(btSalvar);
            Controls.Add(label11);
            Controls.Add(txtEstado);
            Controls.Add(label10);
            Controls.Add(txtCidade);
            Controls.Add(label9);
            Controls.Add(txtBairro);
            Controls.Add(label8);
            Controls.Add(txtNumero);
            Controls.Add(label7);
            Controls.Add(txtLogradouro);
            Controls.Add(label6);
            Controls.Add(txtWhatsapp);
            Controls.Add(label5);
            Controls.Add(txtTelefone);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Name = "Cadastro_de_Cliente";
            Text = "Cadastro_de_Cliente";
            Load += Cadastro_de_Cliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private Label label5;
        private MaskedTextBox txtTelefone;
        private Label label6;
        private MaskedTextBox txtWhatsapp;
        private TextBox txtLogradouro;
        private Label label7;
        private Label label8;
        private TextBox txtNumero;
        private Label label9;
        private TextBox txtBairro;
        private Label label10;
        private TextBox txtCidade;
        private Label label11;
        private TextBox txtEstado;
        private Button btSalvar;
        private TextBox txtCEP;
        private Button btBuscarCEP;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btExcluir;
        private ListBox lbClientes;
        private TextBox txtCPF;
        private Button btAtualizar;
    }
}