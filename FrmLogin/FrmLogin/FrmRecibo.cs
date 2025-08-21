using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrmLogin;
using iTextSharp.testutils;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Document = iTextSharp.text.Document;

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
            using (var banco = new DBContext())
            {
                var multa = _aluguel.multa + 15;
                TxtData1.Text = _aluguel.dataEmprestimo;
                TxtData2.Text = _aluguel.dataDevolucao;
                TxtStatus.Text = _aluguel.status;
                TxtLivroId.Text = _aluguel.alunoID.ToString("0");
                TxtAlunoId.Text = _aluguel.livroID.ToString("0");
                TxtMulta.Text = _aluguel.multa.ToString("C2");
                TxtTotal.Text = (multa) + " R$";
                var nomealuno = banco.Alunos.FirstOrDefault(a => a.Id == int.Parse(TxtAlunoId.Text));
                TxtAluno.Text = nomealuno?.nome;
                var livro = banco.Livros.FirstOrDefault(l => l.Id == int.Parse(TxtLivroId.Text));
                TxtLivro.Text = livro?.titulo;

            }
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
         
            criarPDF();

        }

        private void criarPDF()
        {
        
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF Files|*.pdf";
                sfd.Title = "Salvar Recibo";
                sfd.FileName = $"Recibo_de_{TxtAluno.Text}-{TxtLivro.Text}.pdf";
                

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = sfd.FileName;

                    using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        Document doc = new Document(PageSize.A4);
                        PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                        doc.Open();

                        var titulo = new Paragraph("Recibo de Empréstimo")
                        {
                            Alignment = Element.ALIGN_CENTER
                        };
                        doc.Add(titulo);
                        doc.Add(new Paragraph(" "));
                        doc.Add(new Paragraph($"Aluno: {TxtAluno.Text}"));
                        doc.Add(new Paragraph($"Livro: {TxtLivro.Text}"));
                        doc.Add(new Paragraph($"Data do Empréstimo: {TxtData1.Text}"));
                        doc.Add(new Paragraph($"Data de Devolução: {TxtData2.Text}"));
                        doc.Add(new Paragraph($"Status: {TxtStatus.Text}"));
                        doc.Add(new Paragraph($"Multa: {TxtMulta.Text}"));
                        doc.Add(new Paragraph($"Total: {TxtTotal.Text}"));
                        doc.Close();
                        writer.Close();

                    }
                    Guna.UI2.WinForms.Guna2MessageDialog msg = new Guna.UI2.WinForms.Guna2MessageDialog();
                    msg.Text = "Recibo gerado com sucesso!";
                    msg.Caption = "Sucesso";
                    msg.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    msg.Show();
                   guna2Button2.Enabled = true;
                }
            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string pastaD = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string abrirPdf = Path.Combine(pastaD, $"Recibo_de_{TxtAluno.Text}-{TxtLivro.Text}.pdf");
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = abrirPdf,
                UseShellExecute = true
            });
        }
        
        }
    }

