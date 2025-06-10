using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndWork.dados
{
    public class Avaliacao
    {
        public int Id { get; set; }
        public int PrestadorId { get; set; }
        public int Nota { get; set; }
        public string Comentario { get; set; }
        public DateTime DataAvaliacao { get; set; }
    }

}
