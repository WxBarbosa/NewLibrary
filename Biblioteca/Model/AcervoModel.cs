using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Config;
using Biblioteca.DAO.Acervo;
using Biblioteca.DAO;

namespace Biblioteca.Model
{
    class AcervoModel
    {
        public Livro livro { get; set; }
        public Artigo artigo { get; set; }
        public TCC tcc { get; set; }
        public Connection conn { get; set; }
    }
}
