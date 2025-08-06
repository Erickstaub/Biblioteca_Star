using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmLogin
{
    public class livro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public string titulo { get; set; }
        public string autor { get; set; }
        public string editora { get; set; }
        public int ano_de_publicação { get; set; }
        public string generoID { get; set; }
        public int ISBN { get; set; }
        public int quantidade { get; set; }
    }
}
