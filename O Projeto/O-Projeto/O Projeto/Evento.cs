using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace O_Projeto
{
    public partial class Evento : Form
    {
        string stringConexao = "Data Source=localhost;Initial Catalog=t18_estoque;User ID=sa;Password=123456";
        public Evento()
        {
            InitializeComponent();
        }

        private void Evento_Load(object sender, EventArgs e)
        {

        }
    }
}
