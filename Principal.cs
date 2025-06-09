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

        private void btCadastroUsuario_Click(object sender, EventArgs e)
        {
            Cadastro_de_Usuario cadastroUsuarioForm = new Cadastro_de_Usuario();
            cadastroUsuarioForm.Show();
        }
    }
}
