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



        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(TxtQuant.Text) > 1)
            {
                string opcoes = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                Random ran = new Random();
                string isbn = "";

                for (int i = 0; i < 13; i++)
                    isbn += opcoes[ran.Next(opcoes.Length)];

                TxtISBN.Text = isbn;
                InserirLivro();
            }
            else
            {
                var msg = new Guna.UI2.WinForms.Guna2MessageDialog();
                msg.Text = "Ocorreu um erro!";
                msg.Caption = "Erro!";
                msg.Icon = MessageDialogIcon.Information;
                msg.Show();

            }
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
                string gen = comboBox1.Text;
                string ISBN = TxtISBN.Text;

                var livroNovo = new livro()
                {
                    titulo = titulo,
                    autor = autor,
                    editora = editor,
                    ano_de_publicação = ano,
                    quantidade = quant,
                    ISBN = ISBN,
                    genero = gen,



                };
                banco.Livros.Add(livroNovo);
                banco.SaveChanges();
            }
            var msg = new Guna.UI2.WinForms.Guna2MessageDialog();
            msg.Text = "Livro salvo com sucesso!";
            msg.Caption = "Sucesso";
            msg.Icon = MessageDialogIcon.Information;
            msg.Show();
            this.Close();

        }

        private void TxtTitulo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
