using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndWork.dados
{
    
        public class Cadastro
        {
            public int Id { get; private set; }
            public string Nome { get;  set; }
            public string Email { get; set; }
            public string CPF { get; set; }
            public string Telefone { get; set; }
            public string Rua { get; set; }
            public string Bairro { get; set; }
            public string CEP { get; set; }
            public int Numero { get; set; }
            public DateTime DataNascimento { get; set; }

            public Cadastro(int id, string nome, string email, string cpf, string telefone, string rua, string bairro, string cep, int numero, DateTime dataNascimento)
            {
                Id = id;
                Nome = nome;
                Email = email;
                CPF = cpf;
                Telefone = telefone;
                Rua = rua;
                Bairro = bairro;
                CEP = cep;
                Numero = numero;
                DataNascimento = dataNascimento;

            }
        }

    }

