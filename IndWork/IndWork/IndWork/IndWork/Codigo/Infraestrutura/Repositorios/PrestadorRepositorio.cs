using IndWork.Codigo.Dominio.Entidades;
using IndWork.Codigo.Dominio.Entidades.Enums;
using IndWork.Codigo.Infraestrutura.ScriptsSql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace IndWork.Codigo.Infraestrutura.Repositorios
{
    public class PrestadorRepositorio : RepositorioBase<Prestador>
    {
        public override Prestador Adicionar(Prestador entidade)
        {
            string insertQuery = GerenciarScripts.ObtemScriptInserirPrestador();

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@PessoaId", entidade.Pessoa.Id),
                new SqlParameter("@CategoriaServico", entidade.CategoriasServico) // ou (int)entidade.CategoriasServico
            };

            int id = Conexao.ExecutaComando(insertQuery, parametros);
            entidade.Id = id;

            return entidade;
        }

        public override Prestador Atualizar(Prestador entidade)
        {
            string updateQuery = GerenciarScripts.ObtemScriptAtualizarPrestador();

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Id", entidade.Id),
                new SqlParameter("@PessoaId", entidade.Pessoa.Id),
                new SqlParameter("@CategoriaServico", entidade.CategoriasServico) // ou (int)entidade.CategoriasServico
            };

            return Conexao.ExecuteScalar<Prestador>(updateQuery, parametros);
        }

        public override Prestador ObterPorId(int id)
        {
            string selectQuery = GerenciarScripts.ObtemScriptObterPrestadorPorId();

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Id", id)
            };

            return Conexao.ExecutaLeitura<Prestador>(selectQuery, reader =>
            {
                return new Prestador
                {
                    Id = (int)reader["Id"],
                    Pessoa = new Pessoa
                    {
                        Id = (int)reader["PessoaId"],
                        Nome = reader["Nome"].ToString(),
                        DataNascimento = (DateTime)reader["DataNascimento"],
                        Cpf = reader["Cpf"].ToString(),
                        Telefone = reader["Telefone"].ToString(),
                        Email = reader["Email"].ToString(),
                        Endereco = reader["Endereco"].ToString(),
                        Numero = reader["Numero"].ToString(),
                        Bairro = reader["Bairro"].ToString(),
                        Cep = reader["Cep"].ToString()
                    },
                    CategoriasServico = (Categoria)(int)reader["CategoriaServico"] // Verificar
                };                ;
            }, parametros).FirstOrDefault();
        }

        public override IEnumerable<Prestador> ObterTodos()
        {
            string selectQuery = GerenciarScripts.ObtemScriptListarPrestadores();

            return Conexao.ExecutaLeitura<Prestador>(selectQuery, reader =>
            {
                return new Prestador
                {
                    Id = (int)reader["Id"],
                    Pessoa = new Pessoa
                    {
                        Id = (int)reader["PessoaId"],
                        Nome = reader["Nome"].ToString(),
                        DataNascimento = (DateTime)reader["DataNascimento"],
                        Cpf = reader["Cpf"].ToString(),
                        Telefone = reader["Telefone"].ToString(),
                        Email = reader["Email"].ToString(),
                        Endereco = reader["Endereco"].ToString(),
                        Numero = reader["Numero"].ToString(),
                        Bairro = reader["Bairro"].ToString(),
                        Cep = reader["Cep"].ToString()
                    },
                    CategoriasServico = (Categoria)(int)reader["CategoriaServico"] // Verificar
                };
            });
        }

        public override void Remover(int id)
        {
            string deleteQuery = GerenciarScripts.ObtemScriptRemoverPrestador();

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Id", id)
            };

            Conexao.ExecutaComando(deleteQuery, parametros);
        }
    }
}
