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
                TxtAno.Text = _livros.ano_de_publicação.ToString("F2");


            }
        }
        public FrmLivroInf()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var msg = new Guna.UI2.WinForms.Guna2MessageDialog();
            msg.Text = "Operação realizada com sucesso!";
            msg.Caption = "Sucesso";
            msg.Icon = MessageDialogIcon.Information;
            msg.Show();
        }
    }
}
