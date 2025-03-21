namespace AT2_WFCadastroPessoa
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        public void LimparFormulario()
        {
            txtLogin.Clear();
            txtSenha.Clear();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            Usuario us1 = new Usuario();
            us1.Codigo = 1001;
            us1.Login = "sistema";
            us1.Senha = "123456";
            Usuario.ListaUsuarios.Add(us1);
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            foreach (Usuario user in Usuario.ListaUsuarios)
            {
                if (user.Login == txtLogin.Text && user.Senha == txtSenha.Text)
                {
                    FormPrincipal form = new FormPrincipal();
                    form.ShowDialog();
                    LimparFormulario();
                    return;
                }
            }
            MessageBox.Show("Senha e/ou Usuário incorreto(s)!",
                            "Erro!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            LimparFormulario();
            return;
        }

        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogar_Click(sender, e);
                txtLogin.Focus();
            }
        }

        private void btnLogar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtLogin.Focus();
            }
        }
    }
}
