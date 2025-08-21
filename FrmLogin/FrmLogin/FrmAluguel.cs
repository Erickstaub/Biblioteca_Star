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
            guna2DataGridView1.BackgroundColor = Color.White;
            guna2DataGridView1.DefaultCellStyle.BackColor = Color.White;
            guna2DataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            guna2DataGridView1.EnableHeadersVisualStyles = false;
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
            guna2Button1.Enabled = true;
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _aluguel = guna2DataGridView1.Rows[e.RowIndex].DataBoundItem as emprestimo;
            string selec = guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if (_aluguel != null)
            {


                var usucad = new FrmRecibo(_aluguel);
                usucad.ShowDialog();
                _aluguel = null;


            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (_aluguel != null)
            {


                var usuca = new FrmAluguelCad(_aluguel);
                usuca.ShowDialog();
                _aluguel = null;


            }
        }
    }
}
