using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DAO
{
    class Alugueis
    { 
        public string aluCodigo { get; set; }
        public string aluFuncionarioCodigo { get; set; }
        public string aluClienteCodigo { get; set; }
        public string aluLivCodigo { get; set; }
        public string aluExeCodigo { get; set; }
        public DateTime aluDataEmprestimo { get; set; }
        public DateTime aluDataDevolucao { get; set; }
    }
}
