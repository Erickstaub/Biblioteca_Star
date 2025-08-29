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
        livro? livroselec;
        public FrmLivroCad()
        {
            InitializeComponent();
        }

        public FrmLivroCad(livro livroselect)
        {
            livroselec = livroselect;
            InitializeComponent();
            CarregarDados();
        }

        private void CarregarDados()
        {
            using (var banco = new DBContext())
            {
                if (livroselec != null)
                {
                    TxtTitulo.Text = livroselec.titulo;
                    TxtAutor.Text = livroselec.autor;
                    TxtEditora.Text = livroselec.editora;
                    TxtAno.Text = livroselec.ano_de_publicação.ToString("0");
                    TxtQuant.Text = livroselec.quantidade.ToString("0");
                    comboBox1.Text = livroselec.genero;
                    TxtISBN.Text = livroselec.ISBN;
                }
            }
        }

        private void BuscarLivro()
        {
            using (var bd = new DBContext())
            {
                var livros = bd.Livros.AsQueryable();

                guna2DataGridView1.DataSource = livros.ToList();
            }
        }
        private void FrmLivroCad_Load(object sender, EventArgs e)
        {



        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Genero")
            {
                var msg = new Guna.UI2.WinForms.Guna2MessageDialog();
                msg.Text = "Selecione um genero!";
                msg.Caption = "Erro!";
                msg.Icon = MessageDialogIcon.Error;
                msg.Show();
                return;
            }
            if (string.IsNullOrWhiteSpace(TxtTitulo.Text) || string.IsNullOrWhiteSpace(TxtAutor.Text) || string.IsNullOrWhiteSpace(TxtEditora.Text) || string.IsNullOrWhiteSpace(TxtAno.Text) || string.IsNullOrWhiteSpace(TxtQuant.Text) || string.IsNullOrWhiteSpace(comboBox1.Text) || int.Parse(TxtQuant.Text) < 1)
            {
                var msg = new Guna.UI2.WinForms.Guna2MessageDialog();
                msg.Text = "Preencha todos os campos corretamente!";
                msg.Caption = "Erro!";
                msg.Icon = MessageDialogIcon.Error;
                msg.Show();
                return;
            }
            else
            {
                if (livroselec != null)
                {
                    EditarLivro();

                }
                else
                {
                    string opcoes = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    Random ran = new Random();
                    string isbn = "";
                    for (int i = 0; i < 13; i++)
                        isbn += opcoes[ran.Next(opcoes.Length)];
                    TxtISBN.Text = isbn;
                    InserirLivro();


                }
            }
        }

        private void EditarLivro()
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
                livro livroEditado = banco.Livros.First(x => x.Id == livroselec.Id);
                livroEditado.titulo = titulo;
                livroEditado.autor = autor;
                livroEditado.editora = editor;
                livroEditado.ano_de_publicação = ano;
                livroEditado.quantidade = quant;
                livroEditado.ISBN = ISBN;
                livroEditado.genero = gen;
                banco.Livros.Update(livroEditado);
                banco.SaveChanges();
                var msg = new Guna.UI2.WinForms.Guna2MessageDialog();
                msg.Text = "Editado Com sucesso!";
                msg.Caption = "Sucesso!";
                msg.Icon = MessageDialogIcon.Information;
                msg.Show();
                this.Close();

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

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
