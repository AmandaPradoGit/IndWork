using IndWork.Codigo.Dominio.Entidades;
using IndWork.Codigo.Infraestrutura.Auxiliares;
using IndWork.Codigo.Infraestrutura.Repositorios;
using System;

namespace IndWork.Codigo.Servicos
{
    public class PrestadorServico : BaseServico<Prestador>
    {
        public PrestadorServico(PrestadorRepositorio repositorioBase) : base(repositorioBase) { }

        public override void ValidaEntidade(Prestador entidade)
        {
            if (entidade.Pessoa == null)
                throw new ArgumentException("Os dados da pessoa são obrigatórios.");

            if (string.IsNullOrEmpty(entidade.Pessoa.Nome))
                throw new ArgumentException("Nome não pode ser vazio.");

            if (entidade.Pessoa.DataNascimento == DateTime.MinValue)
                throw new ArgumentException("Data de nascimento inválida.");

            if (string.IsNullOrEmpty(entidade.Pessoa.Cpf) || !ValidadorCpf.CpfValido(entidade.Pessoa.Cpf))
                throw new ArgumentException("CPF inválido.");

            if (string.IsNullOrEmpty(entidade.Pessoa.Telefone))
                throw new ArgumentException("Telefone inválido.");

            if (string.IsNullOrEmpty(entidade.Pessoa.Email) || !ValidadorEmail.EmailValido(entidade.Pessoa.Email))
                throw new ArgumentException("Email inválido.");

            if ((int)entidade.CategoriasServico == 0)
                throw new ArgumentException("É necessário selecionar pelo menos uma categoria de serviço.");
        }
    }
}


