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

namespace Biblioteca
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            AcervoModel acervo = new AcervoModel();
            InitializeComponent();
            Model.AcervoModel model = new AcervoModel();
        }
    }
}
