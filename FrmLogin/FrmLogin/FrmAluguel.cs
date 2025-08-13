using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaStar
{
    public partial class FrmAluguel : Form
    {
        public FrmAluguel()
        {
            InitializeComponent();
        }

        private void FrmAluguel_Load(object sender, EventArgs e)
        {
            BuscarEmprestimos();
        }

        private void BuscarEmprestimos()
        {
            using (var bd = new DBContext())
            {
                var alugel = bd.Emprestimos.AsQueryable();
               // if (!string.IsNullOrEmpty(TxtPesquisa.Text))
             //   {
                //    alugel = alugel.Where(c => c.dataEmprestimo.Contains(TxtPesquisa.Text) ||
                                                //c.status.Contains(TxtPesquisa.Text));

                    guna2DataGridView1.DataSource = alugel.ToList();
                //}
            }
        }
    }
}
