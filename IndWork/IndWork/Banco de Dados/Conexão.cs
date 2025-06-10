using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndWork.Banco_de_Dados
{
    public class Conexao
        {
            private MySqlConnection con = null;
            private static Conexao instance = null;
            private string connString = "server=localhost;database=indwork;user=root;password=;SslMode=none";

            private Conexao()
            {
                try
                {
                    Console.WriteLine("Driver Carregado com sucesso!!!");
                }
                catch (Exception e)
                {
                    Console.WriteLine("O driver do MySQL não pode ser carregado!");
                    Console.WriteLine(e.Message);
                }
            }

            public static Conexao GetInstance()
            {
                if (instance == null)
                {
                    instance = new Conexao();
                }
                return instance;
            }

            public MySqlConnection GetConnection()
            {
                try
                {
                    if (con == null || con.State == System.Data.ConnectionState.Closed)
                    {
                        con = new MySqlConnection(connString);
                        con.Open();
                        Console.WriteLine("Conexão estabelecida");
                    }
                }
                catch (MySqlException e)
                {
                    Console.WriteLine("Erro ao conectar: " + e.Message);
                }
                return con;
            }

            public void Destroy()
            {
                try
                {
                    if (con != null && con.State == System.Data.ConnectionState.Open)
                    {
                        con.Close();
                        Console.WriteLine("Conexão fechada");
                    }
                }
                catch (MySqlException e)
                {
                    Console.WriteLine("Erro ao fechar conexão: " + e.Message);
                }
            }
        }
    }



