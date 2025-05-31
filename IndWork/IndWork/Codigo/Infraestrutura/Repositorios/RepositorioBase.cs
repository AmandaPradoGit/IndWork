using IndWork.Codigo.Dominio.Entidades;
using IndWork.Codigo.Infraestrutura.Persistencia;
using System.Collections.Generic;
using System.Configuration;

namespace IndWork.Codigo.Infraestrutura.Repositorios
{
    public abstract class RepositorioBase<T> where T : EntidadeBase
    {
        public ContextoDeDados Conexao { get; }

        public RepositorioBase()
        {
            Conexao = new ContextoDeDados(ConfigurationManager.ConnectionStrings["IndWork"].ConnectionString);
        }

        public abstract T Adicionar(T entidade);

        public abstract T Atualizar(T entidade);

        public abstract T ObterPorId(int id);

        public abstract IEnumerable<T> ObterTodos();

        public abstract void Remover(int id);

    }
}
