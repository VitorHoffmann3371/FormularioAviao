using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AVIOES.RELATORIOS
{
    public class Funcoes
    {
        public static string diretorioPasta()
        {
            string pasta = @"c:\RELAVIOES";
            if (!Directory.Exists(pasta))
                Directory.CreateDirectory(pasta);
            return pasta;
        }
        
    }
}
