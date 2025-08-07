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
    public partial class FrmLivro : Form
    {
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
                                                c.autor.Contains(TxtPesquisa.Text));
                }
                guna2DataGridView1.DataSource = livros.ToList();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var cadl = new FrmLivroCad();
            cadl.ShowDialog(); 
        }
    }
}
