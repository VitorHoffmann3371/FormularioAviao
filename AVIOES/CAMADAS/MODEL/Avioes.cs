using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVIOES.CAMADAS.MODEL
{
    public class Avioes
    {
        public int id { get; set; }
        public string modelo { get; set; }
        public string fabricante { get; set; }
        public int ano { get; set; }
        public string cor { get; set; }
    }
}
