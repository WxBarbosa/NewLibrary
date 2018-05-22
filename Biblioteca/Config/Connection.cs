using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Biblioteca.DAO.Acervo;

namespace Biblioteca.Config
{
    class Connection 
    {
        /* ATTRIBUTES */
        public MySqlCommand command { get; set; }
        public MySqlConnection conexao { get; set; }
        private string HOST = "127.0.0.1"; //Server
        private string UID = "root"; // User
        private string DATABASE = "raidcall"; // Banco de dados 
        private string PASS = ""; // Senha
        private string PORT = ""; // Porta Se houver
        public string StringConexao = "Server={HOST};Database={DATABASE};Uid={UID};Password={PASS};";

        /* METHODS */

        /// <summary>
        /// Configura conexão
        /// </summary>
        /// <returns>conexao MYSQL</returns>
        public MySqlConnection Conecta()
        {
            conexao = new MySqlConnection(StringConexao);
            return conexao;
        }
    }
}
