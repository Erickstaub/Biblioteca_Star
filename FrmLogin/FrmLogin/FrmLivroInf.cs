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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BibliotecaStar
{
    public partial class FrmLivroInf : Form
    {
        livro? _livros;
        public FrmLivroInf(livro cardapioItem)
        {
            _livros = cardapioItem;
            InitializeComponent();
            CarregarDados();
        }

        private void CarregarDados()
        {
            if (_livros != null)
            {
                TxtTitulo.Text = _livros.titulo;
                TxtAutor.Text = _livros.autor;
                TxtEditora.Text = _livros.editora;
                TxtAno.Text = _livros.ano_de_publicação.ToString("0");
                TxtGenero.Text = _livros.genero;


            }
        }
        public FrmLivroInf()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AlugarLivro();
            var msg = new Guna.UI2.WinForms.Guna2MessageDialog();
            msg.Text = "Operação realizada com sucesso! Mais informações na aba de Alugueis";
            msg.Caption = "Sucesso";
            msg.Icon = MessageDialogIcon.Information;
            msg.Show();
        }

        private void AlugarLivro()
        {
            using (var banco = new DBContext())
            {
                string data_retirada = DateTime.Now.ToString("dd/MM/yyyy");
                string data_devolucao = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
                string status = "Alugado";
                int aluno_id = 1;

                var livroalugado = new emprestimo()
                {
                    dataEmprestimo = data_retirada,
                    dataDevolucao = data_devolucao,
                    status = status,
                };
            }
        }
    }
}
