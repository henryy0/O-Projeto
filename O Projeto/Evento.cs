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
        string stringConexao = "Data Source=localhost;Initial Catalog=sistemaDeGerenciamento;User ID=sa;Password=123456";
        public Evento()
        {
            InitializeComponent();
        }

        private void Evento_Load(object sender, EventArgs e)
        {
            txtDate.Text = UserControlDays.static_day + "/" + Calendario.static_month + "/" + Calendario.static_year;

        }

        private void Save_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                string sql = "INSERT INTO Calendario (Date, Event) VALUES (@Date, @Event)";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@Date", txtDate.Text);
                cmd.Parameters.AddWithValue("@Event", txtEvent.Text);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Salvo");
        }
    }
}
