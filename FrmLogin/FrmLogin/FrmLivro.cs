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
    public partial class FrmLivro : Form
    {
        livro? livroselec;
        public FrmLivro()
        {
            InitializeComponent();
        }

        private void FrmLivro_Load(object sender, EventArgs e)
        {
            BuscarLivro();
        }

        private void BuscarLivro()
        {
            using (var bd = new DBContext())
            {
                var livros = bd.Livros.AsQueryable();
                if (!string.IsNullOrEmpty(TxtPesquisa.Text))
                {
                    livros = livros.Where(c => c.titulo.Contains(TxtPesquisa.Text) ||
                                                c.autor.Contains(TxtPesquisa.Text)
                                                );
                }
                guna2DataGridView1.DataSource = livros.ToList();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var cadl = new FrmLivroCad();
            cadl.ShowDialog();
        }

        private void TxtPesquisa_TextChanged(object sender, EventArgs e)
        {
            BuscarLivro();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            livroselec = guna2DataGridView1.Rows[e.RowIndex].DataBoundItem as livro;

        }

        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            livroselec = guna2DataGridView1.Rows[e.RowIndex].DataBoundItem as livro;
            string selec = guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            int Lid = int.Parse((guna2DataGridView1.CurrentRow.Cells["id"].Value).ToString());
            if (livroselec != null)
            {

                Memoria.LivroID = Lid;
                var usucad = new FrmLivroInf(livroselec);
                usucad.ShowDialog();
                livroselec = null;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (livroselec != null)
            {
                var livcad = new FrmLivroCad(livroselec);
                livcad.Show();
                livroselec = null;
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            using (var bd = new DBContext())
            {
                if (livroselec != null)
                {
                    var confirmResult = MessageBox.Show("Tem certeza que deseja excluir este livro?",
                        "Confirmação de Exclusão",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (confirmResult == DialogResult.Yes)
                    {
                        bd.Livros.Remove(livroselec);
                        bd.SaveChanges();
                        BuscarLivro();
                        livroselec = null;
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum livro selecionado para exclusão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
