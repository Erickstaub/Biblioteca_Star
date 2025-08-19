using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmLogin
{
    public class emprestimo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public string dataEmprestimo { get; set; }
        public string dataDevolucao { get; set; }
        public string status { get; set; }
        public int alunoID { get; set; }
        public int livroID { get; set; }
        public int multa { get; set; }
    }
}
