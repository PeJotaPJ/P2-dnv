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
    public partial class Cadastro_de_Produtos : Form
    {
        private string codigoOriginalEmEdicao = null;

        public Cadastro_de_Produtos()
        {
            InitializeComponent();
        }

        private void Cadastro_de_Produtos_Load(object sender, EventArgs e)
        {
            CarregarProdutosNoListBox();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            string caminhoCsv = "Produtos.csv";
            bool arquivoExiste = File.Exists(caminhoCsv);

            using (var sw = new StreamWriter(caminhoCsv, true, Encoding.UTF8))
            {
                if (!arquivoExiste)
                    sw.WriteLine("Codigo,Nome,Descricao");

                sw.WriteLine($"{txtCodigo.Text},{txtProduto.Text},{txtDescricao.Text}");
            }

            MessageBox.Show("Produto cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparCampos();
            CarregarProdutosNoListBox();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (lbProdutos.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um produto para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string itemSelecionado = lbProdutos.SelectedItem.ToString();
            string codigoSelecionado = itemSelecionado.Split('-')[0].Trim();

            string caminhoCsv = "Produtos.csv";
            if (!File.Exists(caminhoCsv))
                return;

            var linhas = File.ReadAllLines(caminhoCsv).ToList();
            var novasLinhas = new System.Collections.Generic.List<string> { linhas[0] };

            for (int i = 1; i < linhas.Count; i++)
            {
                var partes = linhas[i].Split(',');
                if (partes.Length > 0 && partes[0].Trim() != codigoSelecionado)
                    novasLinhas.Add(linhas[i]);
            }

            File.WriteAllLines(caminhoCsv, novasLinhas, Encoding.UTF8);
            MessageBox.Show("Produto excluído com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparCampos();
            CarregarProdutosNoListBox();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            if (codigoOriginalEmEdicao == null)
            {
                MessageBox.Show("Nenhum produto selecionado para edição.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string caminhoCsv = "Produtos.csv";
            if (!File.Exists(caminhoCsv))
                return;

            var linhas = File.ReadAllLines(caminhoCsv).ToList();
            bool alterado = false;

            for (int i = 1; i < linhas.Count; i++)
            {
                var partes = linhas[i].Split(',');
                if (partes.Length > 0 && partes[0].Trim() == codigoOriginalEmEdicao)
                {
                    linhas[i] = $"{txtCodigo.Text},{txtProduto.Text},{txtDescricao.Text}";
                    alterado = true;
                    break;
                }
            }

            if (alterado)
            {
                File.WriteAllLines(caminhoCsv, linhas, Encoding.UTF8);
                MessageBox.Show("Produto atualizado com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                codigoOriginalEmEdicao = null;
                CarregarProdutosNoListBox();
            }
            else
            {
                MessageBox.Show("Produto não encontrado para atualização.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbProdutos_DoubleClick(object sender, EventArgs e)
        {
            if (lbProdutos.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um produto para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string itemSelecionado = lbProdutos.SelectedItem.ToString();
            string codigoSelecionado = itemSelecionado.Split('-')[0].Trim();
            string caminhoCsv = "Produtos.csv";
            if (!File.Exists(caminhoCsv))
                return;

            var linhas = File.ReadAllLines(caminhoCsv);

            for (int i = 1; i < linhas.Length; i++)
            {
                var partes = linhas[i].Split(',');
                if (partes.Length >= 3 && partes[0].Trim() == codigoSelecionado)
                {
                    txtCodigo.Text = partes[0].Trim();
                    txtProduto.Text = partes[1].Trim();
                    txtDescricao.Text = partes[2].Trim();
                    codigoOriginalEmEdicao = partes[0].Trim();
                    break;
                }
            }
        }

        private void CarregarProdutosNoListBox()
        {
            string caminhoCsv = "Produtos.csv";
            lbProdutos.Items.Clear();

            if (!File.Exists(caminhoCsv))
                return;

            var linhas = File.ReadAllLines(caminhoCsv);
            for (int i = 1; i < linhas.Length; i++)
            {
                var partes = linhas[i].Split(',');
                if (partes.Length >= 2)
                {
                    lbProdutos.Items.Add($"{partes[0].Trim()} - {partes[1].Trim()}");
                }
            }
        }

        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtProduto.Clear();
            txtDescricao.Clear();
            codigoOriginalEmEdicao = null;
        }
    }
}
