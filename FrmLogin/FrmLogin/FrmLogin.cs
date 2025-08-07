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
            
            var frmp = new FrmPrincipal();
            frmp.Show();
           
        }
    }
}
