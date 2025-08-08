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
using Guna.UI2.WinForms;
using MySqlConnector;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BibliotecaStar
{

    public partial class FrmLivroCad : Form
    {
        public FrmLivroCad()
        {
            InitializeComponent();
        }

        private void FrmLivroCad_Load(object sender, EventArgs e)
        {

            using (var bd = new DBContext())
            {
                //var genero = bd.Generos.Select(g => new { g.Id, g.tipo }).ToList();
               // ComboGenero.DataSource = genero;
                ComboGenero.DisplayMember = "tipo";
                ComboGenero.ValueMember = "Id";
                var CBG = (int)ComboGenero.SelectedValue;
            }

        }
        private void GeraISBN_Click(object sender, EventArgs e)
        {
            var chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var rnd = new Random();
            var isbnfake = new char[13];

            for (int i = 0; i < 13; i++)
                isbnfake[i] = chars[rnd.Next(chars.Length)];

            TxtISBN.Text = new string(isbnfake);
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            InserirLivro();
        }

        private void InserirLivro()
        {
            using (var banco = new DBContext())
            {
                string titulo = TxtTitulo.Text;
                string autor = TxtAutor.Text;
                string editor = TxtEditora.Text;
                int ano = int.Parse(TxtAno.Text);
                int quant = int.Parse(TxtQuant.Text);
                int gen = (int)ComboGenero.SelectedValue;
                string ISBN = TxtISBN.Text;

                var livroNovo = new livro()
                {
                    titulo = titulo,
                    autor = autor,
                    editora = editor,
                    ano_de_publicação = ano,
                    quantidade = quant,
                    ISBN = ISBN,
                    //generoID = gen,


                };
                banco.Livros.Add(livroNovo);
                banco.SaveChanges();
            }
            MessageBox.Show("Livro salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        
    }
}
