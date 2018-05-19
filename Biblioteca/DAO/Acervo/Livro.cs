using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DAO.Acervo
{
    class Livro : Acervo
    {
        public string codigo { get; set; }
        public DateTime dataPublicacao { get; set; }
        public DateTime localPublicacao { get; set; }
        public int editora { get; set; }
    }
}
