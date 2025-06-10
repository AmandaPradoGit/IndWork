using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;

public class DatabaseConnection
{
    private string connectionString = "Server=localhost;Database=indwork;Uid=root;Pwd=;";
    private MySqlConnection connection;

    public DatabaseConnection()
    {
        connection = new MySqlConnection(connectionString);
    }

    public void OpenConnection()
    {
        try
        {
            connection.Open();
            Console.WriteLine("Conexão aberta com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao abrir conexão: " + ex.Message);
        }
    }

    public void CloseConnection()
    {
        try
        {
            connection.Close();
            Console.WriteLine("Conexão fechada!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao fechar conexão: " + ex.Message);
        }
    }

    public MySqlConnection GetConnection()
    {
        return connection;
    }
}
