/* 
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace IndWork.Codigo.Infraestrutura.Persistencia
{
    public class ContextoDeDados : IDisposable
    {
        private readonly SqlConnection _conexao;

        public ContextoDeDados(string connectionString)
        {
            _conexao = new SqlConnection(connectionString);
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
        /// Executa um comando que retorna o numero de linhas afetadas (INSERT/UPDATE/DELETE).
        /// </summary>
        public int ExecutaComando(string sql, params SqlParameter[] parameters)
        {
            GarantirConexaoAberta();
            using (var cmd = new SqlCommand(sql, _conexao))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Executa um comando que retorna um único registro.
        /// </summary>
        public T ExecuteScalar<T>(string sql, params SqlParameter[] parameters)
        {
            GarantirConexaoAberta();
            using (var cmd = new SqlCommand(sql, _conexao))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);
                return (T)cmd.ExecuteScalar();
            }
        }

        /// <summary>
        /// Executa uma query e mapeia cada linha usando uma função passada por parâmetro.
        /// </summary>
        public IEnumerable<T> ExecutaLeitura<T>(string sql, Func<IDataRecord, T> map, params SqlParameter[] parameters)
        {
            GarantirConexaoAberta();
            using (var cmd = new SqlCommand(sql, _conexao))
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
        /// Executa uma query e retorna um DataTable.
        /// </summary>
        public DataTable ObterTabela(string sql, params SqlParameter[] parameters)
        {
            GarantirConexaoAberta();
            using (var cmd = new SqlCommand(sql, _conexao))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                var dt = new DataTable();
                using (var adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        /// <summary>
        /// Fecha conexão e descarta o objeto.
        /// </summary>
        public void Dispose()
        {
            if (_conexao.State != ConnectionState.Closed)
                _conexao.Close();
            _conexao.Dispose();
        }
    }
}
*/