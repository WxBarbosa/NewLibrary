using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Model;
using Biblioteca.DAO.Acervo;
using Biblioteca.DAO.User;

namespace Biblioteca.View
{
    public partial class frmHome : Form
    {
        Livro livro;
        AcervoModel acervoModel;
        string user;

        public frmHome(string user)
        {
            // Mostra mensagem de Welcome
            this.user = user;
            // Cria um livro Obj
            livro = new Livro();
            // Cria um AcervoModel Obj
            acervoModel = new AcervoModel();
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // Povoa a DataGrid com dados do Banco
            dgvAcervo.DataSource = acervoModel.SelectLivro(livro);
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, "+this.user+"!";
        }
    }
}
