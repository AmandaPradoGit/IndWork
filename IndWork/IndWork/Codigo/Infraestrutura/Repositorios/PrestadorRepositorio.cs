using IndWork.Codigo.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndWork.Codigo.Infraestrutura.Repositorios
{
    public class PrestadorRepositorio : RepositorioBase<Prestador>
    {
        public override Prestador Adicionar(Prestador entidade)
        {
            throw new NotImplementedException();
        }

        public override Prestador Atualizar(Prestador entidade)
        {
            throw new NotImplementedException();
        }

        public override Prestador ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Prestador> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public override void Remover(int id)
        {
            throw new NotImplementedException();
        }
    }
}
