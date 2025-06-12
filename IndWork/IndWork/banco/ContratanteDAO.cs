using MySql.Data.MySqlClient;
using System;
using IndWork.dados;
using System.Collections.Generic;
using System.Data.SqlClient;

public class CadastroDAO
{
    private string connectionString = "Server=localhost;Database=indwork;Uid=root;Pwd=;";

    public void AdicionarCadastro(Cadastro cadastro)
    {
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            string query = @"INSERT INTO contratante (nome, email, dataNascimento, telefone, cpf, bairro, numero, Rua, cep)
                             VALUES (@Nome, @Email, @DataNascimento, @Telefone, @CPF, @Bairro, @Numero, @Rua,  @CEP)";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@DataNascimento", cadastro.DataNascimento.ToString("yyyy-MM-dd HH:mm:ss"));

                cmd.Parameters.AddWithValue("@Nome", cadastro.Nome);
                cmd.Parameters.AddWithValue("@Email", cadastro.Email);
                cmd.Parameters.AddWithValue("@CPF", cadastro.CPF);
                cmd.Parameters.AddWithValue("@Telefone", cadastro.Telefone);
                cmd.Parameters.AddWithValue("@Rua", cadastro.Rua);
                cmd.Parameters.AddWithValue("@Bairro", cadastro.Bairro);
                cmd.Parameters.AddWithValue("@CEP", cadastro.CEP);
                cmd.Parameters.AddWithValue("@Numero", cadastro.Numero);

                cmd.ExecuteNonQuery();
                Console.WriteLine("Cadastro inserido com sucesso!");
            }
        }
    }

    public List<Contratante> PesquisarContratante(string nomePesquisa)
    {
        var listaContratantes = new List<Contratante>();

        using (var conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            var query = @"SELECT ID, Nome, Email, Telefone, DataNascimento, CPF, Bairro, Numero, Rua, CEP
                      FROM contratante
                      WHERE Nome LIKE @Nome";

            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Nome", $"%{nomePesquisa}%");

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["ID"]);
                        string nome = reader["Nome"].ToString();
                        string email = reader["Email"].ToString();
                        string telefone = reader["Telefone"].ToString();
                        DateTime dataNascimento = Convert.ToDateTime(reader["DataNascimento"]);
                        string cpf = reader["CPF"].ToString();
                        string bairro = reader["Bairro"].ToString();
                        string rua = reader["Rua"].ToString();
                        string cep = reader["CEP"].ToString();

                        int numero = 0;
                        int.TryParse(reader["Numero"].ToString(), out numero);


                        listaContratantes.Add(new Contratante(
                            id,
                            nome,
                            email,
                            cpf,
                            telefone,
                            rua,
                            bairro,
                            cep,
                            numero,
                            dataNascimento
                        ));

                    }
                }
            }
        }

        return listaContratantes;
    }

    public Contratante BuscarCadastro(int usuarioId)
    {
        Contratante contratante = null;

        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            string query = @"SELECT id, nome, email, dataNascimento, telefone, cpf, bairro, numero, Rua, cep
                         FROM contratante WHERE id = @id";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", usuarioId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        string nome = reader["Nome"].ToString();
                        string email = reader["Email"].ToString();
                        string telefone = reader["Telefone"].ToString();
                        DateTime dataNascimento = Convert.ToDateTime(reader["DataNascimento"]);
                        string cpf = reader["CPF"].ToString();
                        string bairro = reader["Bairro"].ToString();
                        string rua = reader["Rua"].ToString();
                        string cep = reader["CEP"].ToString();

                        int numero = 0;
                        int.TryParse(reader["Numero"].ToString(), out numero);
                    }
                }
            }
        }

        return contratante;
    }


    public bool AtualizarContratante(Contratante contratante)
    {
        using (var conn = new SqlConnection("sua_connection_string"))
        {
            string query = "UPDATE Contratantes SET Nome = @Nome, Telefone = @Telefone, Email = @Email, Rua = @Rua, Bairro = @Bairro, Numero = @Numero, CEP = @CEP WHERE Id = @Id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Nome", contratante.Nome);
            cmd.Parameters.AddWithValue("@Telefone", contratante.Telefone);
            cmd.Parameters.AddWithValue("@Email", contratante.Email);
            cmd.Parameters.AddWithValue("@Rua", contratante.Rua);
            cmd.Parameters.AddWithValue("@Bairro", contratante.Bairro);
            cmd.Parameters.AddWithValue("@Numero", contratante.Numero);
            cmd.Parameters.AddWithValue("@CEP", contratante.CEP);
            cmd.Parameters.AddWithValue("@Id", contratante.Id);

            conn.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            return rowsAffected > 0;
        }
    }

}
