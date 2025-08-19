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
    public partial class FrmRecibo : Form
    {
        emprestimo? _aluguel;
        public FrmRecibo(emprestimo emprestimo)
        {
            _aluguel = emprestimo;
            InitializeComponent();
            CarregaDados();
        }

        private void CarregaDados()
        {
            TxtData1.Text = _aluguel.dataEmprestimo;
            TxtData2.Text = _aluguel.dataDevolucao;
            TxtStatus.Text = _aluguel.status;
            TxtLivroId.Text = _aluguel.alunoID.ToString("0");
            TxtAlunoId.Text = _aluguel.livroID.ToString("0");
            
        }

        public FrmRecibo()
        {
            InitializeComponent();
        }


        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
