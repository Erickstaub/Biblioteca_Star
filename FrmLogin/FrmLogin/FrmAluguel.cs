using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrmLogin;

namespace BibliotecaStar
{
    public partial class FrmAluguel : Form
    {
        emprestimo? _aluguel;
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
                if (!string.IsNullOrEmpty(TxtPesquisa.Text))
                {
                    alugel = alugel.Where(c => c.dataDevolucao.Contains(TxtPesquisa.Text) ||
                                                c.status.Contains(TxtPesquisa.Text));

                    guna2DataGridView1.DataSource = alugel.ToList();
                }
                else { guna2DataGridView1.DataSource = alugel.ToList(); }
            }
        }

        private void TxtPesquisa_TextChanged(object sender, EventArgs e)
        {
            BuscarEmprestimos();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _aluguel = guna2DataGridView1.Rows[e.RowIndex].DataBoundItem as emprestimo;
            string selec = guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if (_aluguel != null)
            {


                var usucad = new FrmAluguelCad(_aluguel);
                 usucad.ShowDialog();
                _aluguel = null;


            }
        }
    }
}
