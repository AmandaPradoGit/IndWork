using System;
using System.Configuration;
using System.Data.SqlClient;

public static class InicializadorBanco
{
    public static void CriarTabelas()
    {
        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["IndWork"].ConnectionString))
        {
            conn.Open();

            string sqlPessoas = @"
                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Pessoas' AND xtype='U')
                BEGIN
                    CREATE TABLE Pessoas (
                        Id INT PRIMARY KEY IDENTITY(1,1),
                        Nome NVARCHAR(100) NOT NULL,
                        DataNascimento DATE NOT NULL,
                        Cpf NVARCHAR(14) NOT NULL,
                        Telefone NVARCHAR(20),
                        Email NVARCHAR(100),
                        Endereco NVARCHAR(100),
                        Numero NVARCHAR(10),
                        Bairro NVARCHAR(50),
                        Cep NVARCHAR(10)
                    );
                END
            ";

            using (SqlCommand cmd1 = new SqlCommand(sqlPessoas, conn))
            {
                cmd1.ExecuteNonQuery();
            }

            string sqlPrestadores = @"
                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Prestadores' AND xtype='U')
                BEGIN
                    CREATE TABLE Prestadores (
                        Id INT PRIMARY KEY IDENTITY(1,1),
                        PessoaId INT NOT NULL,
                        CategoriasServico INT NOT NULL,
                        FOREIGN KEY (PessoaId) REFERENCES Pessoas(Id)
                    );
                END
            ";

            using (SqlCommand cmd2 = new SqlCommand(sqlPrestadores, conn))
            {
                cmd2.ExecuteNonQuery();
            }
        }
    }
}
