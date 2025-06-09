using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace P22
{
    public partial class Cadastro_de_Usuario : Form
    {
        private frmLogin _formLogin;
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

            using (var sw = new StreamWriter(caminhoCsv, true, Encoding.UTF8))
            {
                if (!arquivoExiste)
                    sw.WriteLine("Nome,Senha");

                sw.WriteLine($"{Usuario},{Senha}");
            }

            MessageBox.Show("Usuário cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtUsuario.Clear();
            txtSenha.Clear();
        }

        private void btMudarSenha_Click(object sender, EventArgs e)
        {
            string caminhoCsv = "Clientes.csv";

            // Verifica se as senhas coincidem
            if (txtSenha.Text != txtConfirmar.Text)
            {
                MessageBox.Show("As senhas não conferem. Por favor, tente novamente.", "Erro de Senha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Clear();
                txtConfirmar.Clear();
                txtSenha.Focus();
                return;
            }

            if (!File.Exists(caminhoCsv))
            {
                MessageBox.Show("Arquivo de usuários não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lê todas as linhas do arquivo
            var linhas = File.ReadAllLines(caminhoCsv).ToList();
            bool alterado = false;

            // Procura o usuário a partir da segunda linha (pulando o cabeçalho)
            for (int i = 1; i < linhas.Count; i++)
            {
                var partes = linhas[i].Split(',');
                if (partes.Length >= 2 && partes[0] == txtUsuario.Text)
                {
                    linhas[i] = $"{txtUsuario.Text},{txtSenha.Text}";
                    alterado = true;
                    break;
                }
            }

            if (alterado)
            {
                File.WriteAllLines(caminhoCsv, linhas, Encoding.UTF8);
                MessageBox.Show("Senha alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Clear();
                txtSenha.Clear();
                txtConfirmar.Clear();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Cadastro_de_Usuario(frmLogin formLogin)
        {
            InitializeComponent();
            _formLogin = formLogin;
        }
    }
}
