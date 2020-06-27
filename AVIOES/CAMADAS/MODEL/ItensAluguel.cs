using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVIOES.CAMADAS.MODEL
{
    public class ItensAluguel
    {       
        public int id { get; set; }
        public int aluguelID { get; set; }
        public int aviaoID { get; set; }
        public string modelo { get; set; }
        public DateTime validade { get; set; }
    }
}
