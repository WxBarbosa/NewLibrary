using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DAO
{
    class Users
    {
        public string codigo { get; set; }
        public int tipoUser { get; set; }
        public string username { get; set; }
        public string senha { get; set; }
        public string nome { get; set; }
        public DateTime dataNascimento { get; set; }
        public DateTime dataCadastrado { get; set; }
        public string telefone { get; set; }
    }
}
