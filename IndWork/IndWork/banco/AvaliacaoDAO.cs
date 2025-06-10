using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndWork.dados;
using MySql.Data.MySqlClient;

namespace IndWork.banco
{
    public class AvaliacaoDAO
    {
        private string connectionString = "Server=localhost;Database=indwork;Uid=root;Pwd=;";

        public void InserirAvaliacao(Avaliacao avaliacao)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                var query = @"INSERT INTO avaliacao (PrestadorID, Nota, Comentario)
                      VALUES (@PrestadorID, @Nota, @Comentario)";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PrestadorID", avaliacao.PrestadorId);
                    cmd.Parameters.AddWithValue("@Nota", avaliacao.Nota);
                    cmd.Parameters.AddWithValue("@Comentario", avaliacao.Comentario);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public double ObterMediaAvaliacao(int prestadorId)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                var query = @"SELECT AVG(Nota) FROM avaliacao WHERE PrestadorID = @PrestadorID";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PrestadorID", prestadorId);
                    object result = cmd.ExecuteScalar();

                    // DEBUG
                    Console.WriteLine($"Valor do banco: {result}");

                    return result != null && result != DBNull.Value ? Convert.ToDouble(result) : 5.0;
                }
            }
        }


    }
}
