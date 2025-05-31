using IndWork.Codigo.Dominio.Entidades.Enums;

namespace IndWork.Codigo.Dominio.Entidades
{
    public class Prestador : EntidadeBase
    {
        public Pessoa Pessoa { get; set; }

        public Categoria CategoriasServico { get; set; }
    }
}
