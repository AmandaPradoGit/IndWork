using IndWork.Codigo.Dominio.Entidades;
using IndWork.Codigo.Infraestrutura.Repositorios;
using System.Collections.Generic;

namespace IndWork.Codigo.Servicos
{
    public abstract class BaseServico<T> where T : EntidadeBase
    {
        protected readonly RepositorioBase<T> _repositorioBase;

        public BaseServico(RepositorioBase<T> repositorioBase)
        {
            _repositorioBase = repositorioBase;
        }

        public abstract void ValidaEntidade(T entidade);

        public T Inserir(T entidade)
        {
            ValidaEntidade(entidade);
            return _repositorioBase.Adicionar(entidade);            
        }

        public T Atualizar(T entidade)
        {
            ValidaEntidade(entidade);
            return _repositorioBase.Atualizar(entidade);
        }

        public T ObterPorId(int id)
        {
            return _repositorioBase.ObterPorId(id);
        }

        public IEnumerable<T> ObterTodos()
        {
            return _repositorioBase.ObterTodos();
        }

        public void Remover(int id)
        {
            _repositorioBase.Remover(id);
        }
    }
}
