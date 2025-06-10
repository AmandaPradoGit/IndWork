using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
// using MySql.Data.MySqlClient; // Descomente isso quando for usar MySQL

namespace IndWork.Codigo.Infraestrutura.Persistencia
{
    public class ContextoDeDados : IDisposable
    {
        // Conexão com SQL Server
        private readonly SqlConnection _conexao;

        // Quando for usar MySQL, comente a linha acima e descomente abaixo:
        // private readonly MySqlConnection _conexao;

        public ContextoDeDados(string connectionString)
        {
            _conexao = new SqlConnection(connectionString);
            // _conexao = new MySqlConnection(connectionString); // Para MySQL futuramente
        }

        /// <summary>
        /// Garante que a conexão com o banco de dados está aberta.
        /// </summary>
        private void GarantirConexaoAberta()
        {
            if (_conexao.State != ConnectionState.Open)
                _conexao.Open();
        }

        /// <summary>
        /// Executa um comando que retorna o número de linhas afetadas (INSERT/UPDATE/DELETE).
        /// </summary>
        public int ExecutaComando(string sql, params SqlParameter[] parameters)
        {
            GarantirConexaoAberta();
            using (var cmd = new SqlCommand(sql, _conexao))
            // using (var cmd = new MySqlCommand(sql, _conexao)) // Para MySQL futuramente
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Executa um comando que retorna um único valor escalar.
        /// </summary>
        public T ExecuteScalar<T>(string sql, params SqlParameter[] parameters)
        {
            GarantirConexaoAberta();
            using (var cmd = new SqlCommand(sql, _conexao))
            // using (var cmd = new MySqlCommand(sql, _conexao)) // Para MySQL futuramente
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);
                return (T)cmd.ExecuteScalar();
            }
        }

        /// <summary>
        /// Executa uma leitura linha por linha com mapeamento.
        /// </summary>
        public IEnumerable<T> ExecutaLeitura<T>(string sql, Func<IDataRecord, T> map, params SqlParameter[] parameters)
        {
            GarantirConexaoAberta();
            using (var cmd = new SqlCommand(sql, _conexao))
            // using (var cmd = new MySqlCommand(sql, _conexao)) // Para MySQL futuramente
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        yield return map(rdr);
                    }
                }
            }
        }

        /// <summary>
        /// Executa uma consulta e retorna um DataTable.
        /// </summary>
        public DataTable ObterTabela(string sql, params SqlParameter[] parameters)
        {
            GarantirConexaoAberta();
            using (var cmd = new SqlCommand(sql, _conexao))
            // using (var cmd = new MySqlCommand(sql, _conexao)) // Para MySQL futuramente
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                var dt = new DataTable();
                using (var adapter = new SqlDataAdapter(cmd))
                // using (var adapter = new MySqlDataAdapter(cmd)) // Para MySQL futuramente
                {
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        /// <summary>
        /// Fecha a conexão e libera recursos.
        /// </summary>
        public void Dispose()
        {
            if (_conexao.State != ConnectionState.Closed)
                _conexao.Close();
            _conexao.Dispose();
        }
    }
}

