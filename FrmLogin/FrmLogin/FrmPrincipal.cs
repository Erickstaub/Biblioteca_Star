using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaStar;

namespace FrmLogin
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            var frml = new FrmLogin();
            frml.Show();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            var frma = new FrmLivro();
            frma.Show();
        }

        private void BtnAluno_Click(object sender, EventArgs e)
        {
            var frmaluno = new FrmAluno();
            frmaluno.ShowDialog();
        }

        private void BtnEmpre_Click(object sender, EventArgs e)
        {
            var frmemprestimo = new FrmAluguel();
            frmemprestimo.ShowDialog();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
