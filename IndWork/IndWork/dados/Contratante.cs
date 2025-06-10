using IndWork.banco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndWork.dados
{
    public class Contratante : Cadastro
    {
        public Contratante(int id, string nome, string email, string cpf, string telefone, string rua, string bairro, string cep, int numero, DateTime dataNascimento)
            : base(id, nome, email, cpf, telefone, rua, bairro, cep, numero, dataNascimento)
        {
        }
    }
}