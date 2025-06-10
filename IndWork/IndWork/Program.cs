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
           
            /// <summary>
            /// Ponto de entrada principal para o aplicativo.
            /// </summary>
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal());
        }
    }
}