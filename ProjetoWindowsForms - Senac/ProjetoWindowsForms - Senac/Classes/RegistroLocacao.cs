using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoWindowsForms___Senac.Classes
{
    public class RegistroLocacao
    {
        public int LocacaoID { get; set; }
        public string NomeJogo { get; set; }
        public string Cliente { get; set; }
        public DateTime DataLocacao { get; set; }
        public DateTime DataEntrega { get; set; }
        public string Status { get; set; }
    }
}
