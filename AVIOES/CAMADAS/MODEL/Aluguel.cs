using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVIOES.CAMADAS.MODEL
{
    public class Aluguel
    {
        public int id { get; set; }
        public int clienteID { get; set; }
        public string nome { get; set; }
        public DateTime data { get; set; }
    }
}
