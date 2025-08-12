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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BibliotecaStar
{
    public partial class FrmAlunoCad : Form
    {
        public FrmAlunoCad()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            InserirAluno();
        }
        private void InserirAluno()
        {
            using (var banco = new DBContext())
            {
                string nome = TxtNome.Text;
                string senha = TxtSenha.Text;
                string email = TxtEmail.Text;
                int idade = int.Parse(TxtIdade.Text);
                string turma = TxtTurma.Text;
               

                var alunonovo = new aluno()
                {
                    nome = nome,
                    senha = senha,
                    email = email,
                    idade = idade,
                    turma = turma



                };
                banco.Alunos.Add(alunonovo);
                banco.SaveChanges();
            }
            var msg = new Guna.UI2.WinForms.Guna2MessageDialog();
            msg.Text = "Aluno cadrastado com sucesso!";
            msg.Caption = "Sucesso";
            msg.Icon = MessageDialogIcon.Information;
            msg.Show();
            this.Close();

        }
    }
}
