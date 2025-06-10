using MySql.Data.MySqlClient;
using System;
using IndWork.dados;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;


namespace IndWork.banco
{
    public class PrestadorDAO
    {
        private string connectionString = "Server=localhost;Database=indwork;Uid=root;Pwd=;";
        public void AdicionarPrestador(Prestador prestador)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO prestador (Nome, Email, Telefone, DataNascimento, CPF, Bairro, Numero, Rua, CEP, ServicoPrestado) VALUES (@Nome, @Email, @Telefone, @DataNascimento, @CPF, @Bairro, @Numero, @Rua, @CEP, @ServicoPrestado)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", prestador.Nome);
                    cmd.Parameters.AddWithValue("@Email", prestador.Email);
                    cmd.Parameters.AddWithValue("@Telefone", prestador.Telefone);
                    cmd.Parameters.AddWithValue("@DataNascimento", prestador.DataNascimento.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@CPF", prestador.CPF);
                    cmd.Parameters.AddWithValue("@Bairro", prestador.Bairro);
                    cmd.Parameters.AddWithValue("@Numero", prestador.Numero);
                    cmd.Parameters.AddWithValue("@Rua", prestador.Rua);
                    cmd.Parameters.AddWithValue("@CEP", prestador.CEP);
                    cmd.Parameters.AddWithValue("@ServicoPrestado", (int)prestador.Servico);



                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Prestador cadastrado com sucesso!");
                }
            }
        }

        public List<Prestador> PesquisarPrestador(string nomePesquisa)
        {
            var listaPrestadores = new List<Prestador>();

            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var query = @"SELECT ID, Nome, Email, Telefone, DataNascimento, CPF, Bairro, Numero, Rua, CEP, ServicoPrestado 
                      FROM prestador 
                      WHERE Nome LIKE @Nome";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", $"%{nomePesquisa}%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["ID"]);
                            string nome = reader["Nome"].ToString();
                            string email = reader["Email"].ToString();
                            string telefone = reader["Telefone"].ToString();
                            DateTime dataNascimento = Convert.ToDateTime(reader["DataNascimento"]);
                            string cpf = reader["CPF"].ToString();
                            string bairro = reader["Bairro"].ToString();
                            string rua = reader["Rua"].ToString();
                            string cep = reader["CEP"].ToString();

                            int numero = 0;
                            int.TryParse(reader["Numero"].ToString(), out numero);

                            EnumServicos servico;
                            if (!Enum.TryParse(reader["ServicoPrestado"].ToString(), true, out servico))
                            {
                                servico = EnumServicos.AssistenciaTecnica; // valor padrão
                            }

                            listaPrestadores.Add(new Prestador(
                                id,
                                nome,
                                email,
                                cpf,
                                telefone,
                                rua,
                                bairro,
                                cep,
                                numero,
                                dataNascimento,
                                servico
                            ));

                        }
                    }
                }
            }

            return listaPrestadores;
        }


        public List<Prestador> PesquisarPorServico(string nomeServico)
        {
            var listaPrestadores = new List<Prestador>();

            EnumServicos? servicoEncontrado = ObterServicoPorNomeParcial(nomeServico);
            if (servicoEncontrado == null)
                return listaPrestadores; 

            int servicoInt = (int)servicoEncontrado;

            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                var query = @"SELECT ID, Nome, Email, Telefone, DataNascimento, CPF, Bairro, Numero, Rua, CEP, ServicoPrestado 
                      FROM prestador 
                      WHERE ServicoPrestado = @ServicoPrestado";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ServicoPrestado", servicoInt);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["ID"]);
                            string nome = reader["Nome"].ToString();
                            string email = reader["Email"].ToString();
                            string telefone = reader["Telefone"].ToString();
                            DateTime dataNascimento = Convert.ToDateTime(reader["DataNascimento"]);
                            string cpf = reader["CPF"].ToString();
                            string bairro = reader["Bairro"].ToString();
                            string rua = reader["Rua"].ToString();
                            string cep = reader["CEP"].ToString();
                            int numero = 0;
                            int.TryParse(reader["Numero"].ToString(), out numero);
                            EnumServicos servico = (EnumServicos)Convert.ToInt32(reader["ServicoPrestado"]);

                            listaPrestadores.Add(new Prestador(
                                id,
                                nome,
                                email,
                                cpf,
                                telefone,
                                rua,
                                bairro,
                                cep,
                                numero,
                                dataNascimento,
                                servico
                            ));
                        }
                    }
                }
            }

            return listaPrestadores;
        }


        private EnumServicos? ObterServicoPorNomeParcial(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                return null;

            string nomeBusca = RemoverAcentos(nome).ToLower().Trim();

            foreach (EnumServicos servico in Enum.GetValues(typeof(EnumServicos)))
            {
                string nomeEnum = RemoverAcentos(servico.ToString()).ToLower().Trim();

                nomeEnum = System.Text.RegularExpressions.Regex.Replace(nomeEnum, "(?<!^)([A-Z])", " $1").ToLower().Trim();

                if (nomeEnum.Contains(nomeBusca))
                {
                    return servico;
                }
            }

            return null;
        }



        public static string RemoverAcentos(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                return texto;

            var normalized = texto.Normalize(System.Text.NormalizationForm.FormD);
            var sb = new System.Text.StringBuilder();

            foreach (var c in normalized)
            {
                if (System.Globalization.CharUnicodeInfo.GetUnicodeCategory(c) != System.Globalization.UnicodeCategory.NonSpacingMark)
                    sb.Append(c);
            }

            return sb.ToString().Normalize(System.Text.NormalizationForm.FormC);
        }



    }
}
