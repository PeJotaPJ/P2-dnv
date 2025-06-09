namespace P22
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string caminhoCsv = "Usuários.csv";
            string Usuario = txtUsuario.Text;
            string Senha = txtSenha.Text;
            if (txtUsuario.Text == Usuario && txtSenha.Text == Senha)
            {
                
                frmPrincipal principalForm = new frmPrincipal();
                principalForm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Senha ou usuário inválidos");
            }
        }
    }
}
