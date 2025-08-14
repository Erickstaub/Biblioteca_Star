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

namespace BibliotecaStar
{
    public partial class FrmAluguelCad : Form
    {
        emprestimo? _aluguel;
        public FrmAluguelCad(emprestimo emprestimo)
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

        private void LivroRenovado()
        {
            using (var banco = new DBContext())
            {
                string data1 = TxtData1.Text;
                string data2 = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy"); ;
                string status = comboBox1.Text;
                int idalu = int.Parse(TxtAlunoId.Text);
                int idliv = int.Parse(TxtLivroId.Text);
                emprestimo aluguel = banco.Emprestimos.First(x => x.Id == _aluguel.Id);
                aluguel.dataEmprestimo = data1;
                aluguel.dataDevolucao = data2;
                aluguel.status = status;
                aluguel.alunoID = idalu;
                aluguel.livroID = idliv;
                banco.Emprestimos.Update(aluguel);
                banco.SaveChanges();
            }
            var msg = new Guna.UI2.WinForms.Guna2MessageDialog();
            msg.Text = "Operação realizada com sucesso!";
            msg.Caption = "Sucesso";
            msg.Icon = MessageDialogIcon.Information;
            msg.Show();
            this.Close();
        }

        private void LivroPendente()
        {
            using (var banco = new DBContext())
            {
                string data1 = TxtData1.Text;
                string data2 = TxtData2.Text;
                string status = comboBox1.Text;
                int idalu = int.Parse(TxtAlunoId.Text);
                int idliv = int.Parse(TxtLivroId.Text);
                emprestimo aluguel = banco.Emprestimos.First(x => x.Id == _aluguel.Id);
                aluguel.dataEmprestimo = data1;
                aluguel.dataDevolucao = data2;
                aluguel.status = status;
                aluguel.alunoID = idalu;
                aluguel.livroID = idliv;
                banco.Emprestimos.Update(aluguel);
                banco.SaveChanges();
            }
            var msg = new Guna.UI2.WinForms.Guna2MessageDialog();
            msg.Text = "Operação realizada com sucesso!";
            msg.Caption = "Sucesso";
            msg.Icon = MessageDialogIcon.Information;
            msg.Show();
            this.Close();
        }

        private void LivroEntregue()
        {
            using (var banco = new DBContext())
            {
                string data1 = TxtData1.Text;
                string data2 = TxtData2.Text;
                string status = comboBox1.Text;
                int idalu = int.Parse(TxtAlunoId.Text);
                int idliv = int.Parse(TxtLivroId.Text);
                emprestimo aluguel = banco.Emprestimos.First(x => x.Id == _aluguel.Id);
                aluguel.dataEmprestimo = data1;
                aluguel.dataDevolucao = data2;
                aluguel.status = status;
                aluguel.alunoID = idalu;
                aluguel.livroID = idliv;
                banco.Emprestimos.Update(aluguel);
                banco.SaveChanges();
            }
            var msg = new Guna.UI2.WinForms.Guna2MessageDialog();
            msg.Text = "Operação realizada com sucesso!";
            msg.Caption = "Sucesso";
            msg.Icon = MessageDialogIcon.Information;
            msg.Show();
            this.Close();


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Renovado")
            {
                LivroRenovado();
            }
            else if (comboBox1.Text == "Pendente")
            {
                LivroPendente();
            }
            else if (comboBox1.Text == "Entregue")
            {
                LivroEntregue();
            }
            else
            {
                var msg = new Guna.UI2.WinForms.Guna2MessageDialog();
                msg.Text = "Selecione uma opção válida!";
                msg.Caption = "Erro";
                msg.Icon = MessageDialogIcon.Error;
                msg.Show();
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
    }
}
