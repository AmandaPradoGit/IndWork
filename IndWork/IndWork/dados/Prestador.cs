using System;

namespace IndWork.dados
{
    public class Prestador : Cadastro
    {
        public EnumServicos Servico { get; set; }

        public Prestador(int id, string nome, string email, string cpf, string telefone, string rua, string bairro, string cep, int numero, DateTime dataNascimento, EnumServicos servico)
            : base(id, nome, email, cpf, telefone, rua, bairro, cep, numero, dataNascimento)
        {
            Servico = servico;
        }
    }
}