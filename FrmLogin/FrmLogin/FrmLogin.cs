using BibliotecaStar;
using Guna.UI2.WinForms;

namespace FrmLogin
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            bool loginValido = ValidateLogin(guna2TextBox2.Text, guna2TextBox1.Text);

            if (loginValido)
            {
                this.Hide();
                var frmp = new FrmPrincipal();
                frmp.Show();

            }
        }
        private bool ValidateLogin(string nome, string senha)
        {
            bool UsuarioValido = false;
            int Uid = 0;
            using (var banco = new DBContext())
            {
                var usuario = banco.Alunos.FirstOrDefault(u => u.nome.ToLower().Equals(nome.ToLower()) && u.senha == senha);

                if (usuario is not null)
                    Uid = usuario.Id;
                Memoria.UsuarioID = Uid;
                UsuarioValido = true;

            }

            if (UsuarioValido = true)
            {

                return true;
            }
            else
            {
                var msg = new Guna.UI2.WinForms.Guna2MessageDialog();
                msg.Text = "Essa Conta nao existe!";
                msg.Caption = "Erro";
                msg.Icon = MessageDialogIcon.Error;
                msg.Show();
            }

            return false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var criarconta = new FrmAlunoCad();
            criarconta.ShowDialog();
        }
    }
}

