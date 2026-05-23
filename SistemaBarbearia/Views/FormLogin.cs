using SistemaBarbearia.Services;
using SistemaBarbearia.Views;

namespace SistemaBarbearia
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void pcOlho_Click(object sender, EventArgs e)
        {
            if (txtSenha.PasswordChar == '*')
            {
                txtSenha.PasswordChar = '\0';
            }
            else
            {
                txtSenha.PasswordChar = '*';
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                var service = new UsuarioService();

                var usuarioLogado = service.FazerLogin(txtLogin.Text, txtSenha.Text);

                this.Hide();

                var form = new FormBarbeiros();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro de Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lklEsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Por favor, entre em contato com o Administrador do Sistema para solicitar a redefinição da sua senha.",
                    "Recuperação de Acesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
