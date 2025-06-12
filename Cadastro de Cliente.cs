using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P22
{
    public partial class Cadastro_de_Cliente : Form
    {
        private string cpfOriginalEmEdicao = null;
        public Cadastro_de_Cliente()
        {
            InitializeComponent();
        }

        private async void txtCEP_Leave(object sender, EventArgs e)
        {
            string cep = txtCEP.Text.Trim().Replace("-", "");
            if (cep.Length == 8)
            {
                await PreencherEnderecoPorCEP(cep);
            }
        }

        private async Task PreencherEnderecoPorCEP(string cep)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync($"https://viacep.com.br/ws/{cep}/json/");
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        var endereco = JsonSerializer.Deserialize<ViaCepResponse>(json);

                        if (endereco != null && endereco.cep != null)
                        {
                            txtLogradouro.Text = endereco.logradouro;
                            txtBairro.Text = endereco.bairro;
                            txtCidade.Text = endereco.localidade;
                            txtEstado.Text = endereco.uf;
                        }
                        else
                        {
                            MessageBox.Show("CEP não encontrado.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro ao consultar o CEP.");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Erro ao consultar o CEP.");
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            string caminhoCsv = "Clientes.csv";
            bool arquivoExiste = File.Exists(caminhoCsv);

            using (var sw = new StreamWriter(caminhoCsv, true, Encoding.UTF8))
            {
                if (!arquivoExiste)
                {
                    sw.WriteLine("Nome,CPF,Email,CEP,Logradouro,Numero,Bairro,Cidade,Estado,Telefone,WhatsApp");
                }

                sw.WriteLine($"{txtNome.Text},{txtCPF.Text},{txtEmail.Text},{txtCEP.Text},{txtLogradouro.Text},{txtNumero.Text},{txtBairro.Text},{txtCidade.Text},{txtEstado.Text},{txtTelefone.Text},{txtWhatsapp.Text}");
            }

            MessageBox.Show("Cliente cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparCampos();
            CarregarClientesNoListBox();
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtCPF.Clear();
            txtEmail.Clear();
            txtCEP.Clear();
            txtLogradouro.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtTelefone.Clear();
            txtWhatsapp.Clear();
        }

        private async void btBuscarCEP_Click(object sender, EventArgs e)
        {
            string cep = txtCEP.Text.Trim().Replace("-", "");
            if (cep.Length == 8)
            {
                await PreencherEnderecoPorCEP(cep);
            }
            else
            {
                MessageBox.Show("Digite um CEP válido com 8 dígitos.");
            }
        }

        private void lbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Pode ser usado para habilitar/desabilitar botões, se desejar
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (lbClientes.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um cliente para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtém o CPF do item selecionado (antes do " - ")
            string itemSelecionado = lbClientes.SelectedItem.ToString();
            string cpfSelecionado = itemSelecionado.Split('-')[0].Trim();

            string caminhoCsv = "Clientes.csv";
            if (!File.Exists(caminhoCsv))
                return;

            // Lê todas as linhas do arquivo
            var linhas = File.ReadAllLines(caminhoCsv).ToList();

            // Mantém o cabeçalho
            var novasLinhas = new List<string> { linhas[0] };

            // Adiciona todas as linhas exceto a do CPF selecionado
            for (int i = 1; i < linhas.Count; i++)
            {
                var partes = linhas[i].Split(',');
                if (partes.Length > 1 && partes[1].Trim() != cpfSelecionado)
                {
                    novasLinhas.Add(linhas[i]);
                }
            }

            // Reescreve o arquivo sem o cliente excluído
            File.WriteAllLines(caminhoCsv, novasLinhas, Encoding.UTF8);

            // Remove do ListBox
            lbClientes.Items.RemoveAt(lbClientes.SelectedIndex);

            MessageBox.Show("Cliente excluído com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CarregarClientesNoListBox();
        }

        private void Cadastro_de_Cliente_Load(object sender, EventArgs e)
        {
            CarregarClientesNoListBox();
        }

        private void lbClientes_DoubleClick(object sender, EventArgs e)
        {
            if (lbClientes.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um cliente para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string itemSelecionado = lbClientes.SelectedItem.ToString();
            string cpfSelecionado = itemSelecionado.Split('-')[0].Trim();
            cpfOriginalEmEdicao = cpfSelecionado; // Salva o CPF original

            string caminhoCsv = "Clientes.csv";
            if (!File.Exists(caminhoCsv))
                return;

            var linhas = File.ReadAllLines(caminhoCsv);

            // Procura o cliente pelo CPF (pulando o cabeçalho)
            for (int i = 1; i < linhas.Length; i++)
            {
                var partes = linhas[i].Split(',');

                // Garante que o array tenha pelo menos 11 posições
                if (partes.Length >= 11 && partes[1].Trim() == cpfSelecionado)
                {
                    txtNome.Text = partes[0].Trim();
                    txtCPF.Text = partes[1].Trim();
                    txtEmail.Text = partes[2].Trim();
                    txtCEP.Text = partes[3].Trim();
                    txtLogradouro.Text = partes[4].Trim();
                    txtNumero.Text = partes[5].Trim();
                    txtBairro.Text = partes[6].Trim();
                    txtCidade.Text = partes[7].Trim();
                    txtEstado.Text = partes[8].Trim();
                    txtTelefone.Text = partes[9].Trim();
                    txtWhatsapp.Text = partes[10].Trim();
                    break;
                }
            }
        }

        private void CarregarClientesNoListBox()
        {
            string caminhoCsv = "Clientes.csv";
            lbClientes.Items.Clear();

            if (!File.Exists(caminhoCsv))
                return;

            var linhas = File.ReadAllLines(caminhoCsv);
            // Começa do índice 1 para pular o cabeçalho
            for (int i = 1; i < linhas.Length; i++)
            {
                var partes = linhas[i].Split(',');
                if (partes.Length >= 2)
                {
                    // Exibe CPF - Nome
                    lbClientes.Items.Add($"{partes[1].Trim()} - {partes[0].Trim()}");
                }
            }
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            if (cpfOriginalEmEdicao == null)
            {
                MessageBox.Show("Nenhum cliente selecionado para edição.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string caminhoCsv = "Clientes.csv";
            if (!File.Exists(caminhoCsv))
                return;

            var linhas = File.ReadAllLines(caminhoCsv).ToList();
            bool alterado = false;

            // Mantém o cabeçalho
            for (int i = 1; i < linhas.Count; i++)
            {
                var partes = linhas[i].Split(',');
                if (partes.Length >= 2 && partes[1].Trim() == cpfOriginalEmEdicao)
                {
                    // Atualiza a linha com os novos dados
                    linhas[i] = $"{txtNome.Text},{txtCPF.Text},{txtEmail.Text},{txtCEP.Text},{txtLogradouro.Text},{txtNumero.Text},{txtBairro.Text},{txtCidade.Text},{txtEstado.Text},{txtTelefone.Text},{txtWhatsapp.Text}";
                    alterado = true;
                    break;
                }
            }

            if (alterado)
            {
                File.WriteAllLines(caminhoCsv, linhas, Encoding.UTF8);
                MessageBox.Show("Cliente atualizado com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                cpfOriginalEmEdicao = null;
                CarregarClientesNoListBox();
            }
            else
            {
                MessageBox.Show("Cliente não encontrado para atualização.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class ViaCepResponse
    {
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }
    }
}
