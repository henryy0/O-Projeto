using System;
using System.Data.SqlClient;

namespace O_Projeto
{
    public class MensagemDAO
    {
        private string stringConexao;

        public MensagemDAO(string stringConexao)
        {
            this.stringConexao = stringConexao;
        }

        public bool EnviarMensagem(int idUsuario1, int idUsuario2, string mensagem)
        {
            using (SqlConnection conexao = new SqlConnection(stringConexao))
            {
                string sql = "INSERT INTO mensagem (id_chat_mensagem, id_usuario_mensagem, texto_mensagem, status_mensagem) " +
                             "VALUES ((SELECT TOP 1 ID_chat FROM Chat WHERE (id_usuario1_chat = @idUsuario1 AND id_usuario2_chat = @idUsuario2) OR (id_usuario1_chat = @idUsuario2 AND id_usuario2_chat = @idUsuario1)), @idUsuario1, @mensagem, 0)";

                using (SqlCommand cmd = new SqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@idUsuario1", idUsuario1);
                    cmd.Parameters.AddWithValue("@idUsuario2", idUsuario2);
                    cmd.Parameters.AddWithValue("@mensagem", mensagem);

                    conexao.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }

        public bool MarcarMensagemComoLida(int mensagemId)
        {
            using (SqlConnection conexao = new SqlConnection(stringConexao))
            {
                string sql = "UPDATE mensagem SET status_mensagem = 1 WHERE id_mensagem = @mensagemId";

                using (SqlCommand cmd = new SqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@mensagemId", mensagemId);

                    conexao.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }
    }
}
