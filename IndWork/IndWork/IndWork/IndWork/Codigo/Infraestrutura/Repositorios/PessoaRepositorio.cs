using IndWork.Codigo.Dominio.Entidades;
using IndWork.Codigo.Infraestrutura.ScriptsSql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace IndWork.Codigo.Infraestrutura.Repositorios
{
    public class PessoaRepositorio : RepositorioBase<Pessoa>
    {
        public override Pessoa Adicionar(Pessoa entidade)
        {
            string insertQuery = GerenciarScripts.ObtemScriptInserirPessoa();

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Nome", entidade.Nome),
                new SqlParameter("@DataNascimento", entidade.DataNascimento),
                new SqlParameter("@Cpf", entidade.Cpf),
                new SqlParameter("@Telefone", entidade.Telefone),
                new SqlParameter("@Email", entidade.Email),
                new SqlParameter("@Endereco", entidade.Endereco),
                new SqlParameter("@Numero", entidade.Numero),
                new SqlParameter("@Bairro", entidade.Bairro),
                new SqlParameter("@Cep", entidade.Cep)
            };

            int id = Conexao.ExecutaComando(insertQuery, parametros);

            entidade.Id = id;
            return entidade;
        }

        public override Pessoa Atualizar(Pessoa entidade)
        {
            string updateQuery = GerenciarScripts.ObtemScriptAtualizarPessoa();

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Id", entidade.Id),
                new SqlParameter("@Nome", entidade.Nome),
                new SqlParameter("@DataNascimento", entidade.DataNascimento),
                new SqlParameter("@Cpf", entidade.Cpf),
                new SqlParameter("@Telefone", entidade.Telefone),
                new SqlParameter("@Email", entidade.Email),
                new SqlParameter("@Endereco", entidade.Endereco),
                new SqlParameter("@Numero", entidade.Numero),
                new SqlParameter("@Bairro", entidade.Bairro),
                new SqlParameter("@Cep", entidade.Cep)
            };

            return Conexao.ExecuteScalar<Pessoa>(updateQuery, parametros);
        }

        public override Pessoa ObterPorId(int id)
        {
            string selectQuery = GerenciarScripts.ObtemScriptObterPessoaPorId();

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Id", id)
            };

            return Conexao.ExecutaLeitura<Pessoa>(selectQuery, reader =>
            {
                return new Pessoa
                {
                    Id = id,
                    Nome = reader["Nome"].ToString(),
                    DataNascimento = (DateTime)reader["DataNascimento"],
                    Cpf = reader["Cpf"].ToString(),
                    Telefone = reader["Telefone"].ToString(),
                    Email = reader["Email"].ToString(),
                    Endereco = reader["Endereco"].ToString(),
                    Numero = reader["Numero"].ToString(),
                    Bairro = reader["Bairro"].ToString(),
                    Cep = reader["Cep"].ToString()
                };
            }, parametros).FirstOrDefault();
        }

        public override IEnumerable<Pessoa> ObterTodos()
        {
            string selectQuery = GerenciarScripts.ObtemScriptListarPessoas();

            return Conexao.ExecutaLeitura<Pessoa>(selectQuery, reader =>
            {
                return new Pessoa
                {
                    Id = (int)reader["Id"],
                    Nome = reader["Nome"].ToString(),
                    DataNascimento = (DateTime)reader["DataNascimento"],
                    Cpf = reader["Cpf"].ToString(),
                    Telefone = reader["Telefone"].ToString(),
                    Email = reader["Email"].ToString(),
                    Endereco = reader["Endereco"].ToString(),
                    Numero = reader["Numero"].ToString(),
                    Bairro = reader["Bairro"].ToString(),
                    Cep = reader["Cep"].ToString()
                };
            });
        }

        public override void Remover(int id)
        {
            string deleteQuery = GerenciarScripts.ObtemScriptRemoverPessoa();

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Id", id)
            };

            Conexao.ExecutaComando(deleteQuery, parametros);
        }
        public int ObterUltimoId()
        {
            string query = "SELECT MAX(Id) FROM Pessoas";
            return Conexao.ExecuteScalar<int>(query);
        }

    }
}
