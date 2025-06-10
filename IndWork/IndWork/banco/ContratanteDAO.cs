using MySql.Data.MySqlClient;
using System;
using IndWork.dados;

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
}
