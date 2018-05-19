using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.DAO.Acervo;
using Biblioteca.DAO;

namespace Biblioteca.DAO.Acervo
{
    class Acervo
    {
        public string autorCodigo { get; set; }
        public string autorNome { get; set; }
        public string autorSobrenome { get; set; }
        public string assuntoCodigo { get; set; }
        public string assuntoNome { get; set; }
        public string titulo { get; set; }
        public int exemplarQtd { get; set; }
        public int exemplarCodigo { get; set; }
    }
}
