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

            txtCPF.Text
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
