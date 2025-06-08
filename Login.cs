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
            if (txtUsuario.Text == "admin" && txtSenha.Text == "1234")
            {
                MessageBox.Show("Login successful!");
                frmPrincipal principalForm = new frmPrincipal();
                principalForm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
