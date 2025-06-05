using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace IndWork
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Teste de conexão com o Banco de Dados IndWork.mdf
            string conexao = ConfigurationManager.ConnectionStrings["IndWork"]?.ConnectionString;

            if (string.IsNullOrEmpty(conexao))
            {
                MessageBox.Show("❌ String de conexão 'IndWork' não encontrada no App.config!");
                return;
            }

            try
            {
                using (var conn = new SqlConnection(conexao))
                {
                    conn.Open();
                    MessageBox.Show("Conexão com o banco realizada com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Erro ao conectar ao banco:\n" + ex.Message);
                return;
            }

            //Criação das tabelas no Banco de Dados
            InicializadorBanco.CriarTabelas();

            /// <summary>
            /// Ponto de entrada principal para o aplicativo.
            /// </summary>
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal());
        }
    }
}