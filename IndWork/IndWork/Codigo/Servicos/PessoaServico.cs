using IndWork.Codigo.Dominio.Entidades;
using IndWork.Codigo.Infraestrutura.Auxiliares;
using IndWork.Codigo.Infraestrutura.Repositorios;
using System;

namespace IndWork.Codigo.Servicos
{
    public class PessoaServico : BaseServico<Pessoa>
    {
        public PessoaServico(PessoaRepositorio repositorioBase) : base(repositorioBase) { }

        public override void ValidaEntidade(Pessoa entidade)
        {
            if(string.IsNullOrEmpty(entidade.Nome))
                throw new ArgumentException("Nome não pode ser vazio.");

            if (entidade.DataNascimento == DateTime.MinValue)
                throw new ArgumentException("Data de nascimento inválida.");

            if (string.IsNullOrEmpty(entidade.Cpf) || !ValidadorCpf.CpfValido(entidade.Cpf))
                throw new ArgumentException("CPF inválido.");

            if (string.IsNullOrEmpty(entidade.Telefone))
                throw new ArgumentException("Telefone inválido.");

            if (string.IsNullOrEmpty(entidade.Email) || !ValidadorEmail.EmailValido(entidade.Email))
                throw new ArgumentException("Email inválido.");
        }
    }
}
