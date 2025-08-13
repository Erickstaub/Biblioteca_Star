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
    public partial class FrmAluguelCad : Form
    {
       emprestimo? _aluguel;
        public FrmAluguelCad(emprestimo emprestimo)
        {
            _aluguel = emprestimo;

            InitializeComponent();
        }
    }
}
