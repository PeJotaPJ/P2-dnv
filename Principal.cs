using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P22
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        public string UsuarioLogado { get; set; }

        private void btCadastroClientes_Click(object sender, EventArgs e)
        {
            Cadastro_de_Cliente cadastroClienteForm = new Cadastro_de_Cliente();
            cadastroClienteForm.Show();
        }

        private void btCadastroProdutos_Click(object sender, EventArgs e)
        {
            Cadastro_de_Produtos cadastroProdutosForm = new Cadastro_de_Produtos();
            cadastroProdutosForm.Show();
        }

        private void btCadastroPedidos_Click(object sender, EventArgs e)
        {
            Cadastro_de_Pedidos cadastroPedidosForm = new Cadastro_de_Pedidos();
            cadastroPedidosForm.Show();
        }

        // No evento de abertura do Cadastro de Usuário (ex: botão "Cadastrar Usuário")
        private void btCadastroUsuario_Click(object sender, EventArgs e)
        {
            // Supondo que você armazene o usuário logado em uma propriedade pública
            if (UsuarioLogado != "ADMIN")
            {
                MessageBox.Show("Apenas o usuário ADMIN pode acessar o cadastro de usuários.", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Só ADMIN chega aqui
            var cadastroUsuarioForm = new Cadastro_de_Usuario();
            cadastroUsuarioForm.ShowDialog();
        }
    }
}
