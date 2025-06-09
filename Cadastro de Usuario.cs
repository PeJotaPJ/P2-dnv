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
    public partial class Cadastro_de_Usuario : Form
    {
        public Cadastro_de_Usuario()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            if (txtConfirmar.Text != txtSenha.Text)
            {
                MessageBox.Show("As senhas não conferem. Por favor, tente novamente.", "Erro de Senha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Clear();
                txtConfirmar.Clear();
                txtSenha.Focus();
            }
            string caminhoCsv = "Clientes.csv";
            string Usuario = txtUsuario.Text;
            string Senha = txtSenha.Text;
            bool arquivoExiste = File.Exists(caminhoCsv);
        }

        private void btMudarSenha_Click(object sender, EventArgs e)
        {

        }
    }
}
