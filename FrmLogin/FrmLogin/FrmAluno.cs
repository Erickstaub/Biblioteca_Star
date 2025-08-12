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

    public partial class FrmAluno : Form
    {
        aluno? alunoselec;
        public FrmAluno()
        {
            InitializeComponent();
        }

        private void FrmAluno_Load(object sender, EventArgs e)
        {
            BuscarAluno();

        }
        private void BuscarAluno()
        {
            using (var bd = new DBContext())
            {
                var alunos = bd.Alunos.AsQueryable();
                if (!string.IsNullOrEmpty(TxtPesquisa.Text))
                {
                    alunos = alunos.Where(c => c.nome.Contains(TxtPesquisa.Text) ||
                                                c.turma.Contains(TxtPesquisa.Text));

                }
                guna2DataGridView1.DataSource = alunos.ToList();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var frmaluno = new FrmAlunoCad();
            frmaluno.ShowDialog();
        }

        private void TxtPesquisa_TextChanged(object sender, EventArgs e)
        {
            BuscarAluno();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                alunoselec = guna2DataGridView1.Rows[e.RowIndex].DataBoundItem as aluno;
              //  btnEditar.Enabled = true;
                //btnExcluir.Enabled = true;
                string selec = guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                
            }
        }
    }
}
