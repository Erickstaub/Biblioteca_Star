using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrmLogin;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace BibliotecaStar
{
    public class DBContext : DbContext
    {
        public DBContext() : base()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conexao = "Server=localhost;Database=BibliotecaStar;User=root;Password=";
            optionsBuilder.UseMySql(conexao, ServerVersion.AutoDetect(conexao));
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<livro> Livros { get; set; }
        public DbSet<genero> Generos { get; set; }
        public DbSet<emprestimo> Emprestimos { get; set; }
        public DbSet<aluno> Alunos { get; set; }




    }
}

