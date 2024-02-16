using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace O_Projeto
{
    public partial class UserControlDays : UserControl
    {
        public static string static_day;
        private SqlConnection conexao = new SqlConnection("Data Source=localhost;Initial Catalog=sistemaDeGerenciamento;User ID=sa;Password=123456");
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }

        public void days(int numday)
        {
            lbdays.Text = numday + "";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lbdays.Text;
            Evento eventForm = new Evento();
            timer1.Start(); 
            eventForm.Show();

           
        }

        private void displayEvent()
        {
            try
            {
                conexao.Open();
                string sql = "SELECT Event FROM Calendario WHERE Date = @Date";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@Date", static_day + "/" + Calendario.static_month + "/" + Calendario.static_year);

                SqlDataReader leitura = cmd.ExecuteReader();
                if (leitura.Read())
                {
                    lbEvent.Text = leitura["Event"].ToString();
                }

                leitura.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvent();
        }
    }
}
