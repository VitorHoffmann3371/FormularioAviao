using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVIOES.RELATORIOS
{
    public class RelatorioGeral
    {
        public static void relAviao()
        {
            CAMADAS.BLL.Avioes bllAviao = new CAMADAS.BLL.Avioes();
            List<CAMADAS.MODEL.Avioes> lstAviao = new List<CAMADAS.MODEL.Avioes>();
            lstAviao = bllAviao.Select().OrderBy(o =>o.ano).ToList();

            string pasta = Funcoes.diretorioPasta();
            string arquivo = pasta + @"\RelatorioAvioes.html";
            StreamWriter sw = new StreamWriter(arquivo);
            using (sw)
            {
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine("<meta http-equiv = 'Content-Type' content='text/html; charset=utf-8'/>");
                sw.WriteLine("<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css' integrity='sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk' crossorigin='anonymous'>");
                sw.WriteLine("</head>");
                sw.WriteLine("<body>");
                sw.WriteLine("<h1> <center>Relatório de Aviões <center> </h1>");
                sw.WriteLine("<hr align='left' border:'5px' />");
                sw.WriteLine("</br>");
                sw.WriteLine("<table class='table table - dark'>");
                sw.WriteLine("<tr align='right'>");
                sw.WriteLine("<th align='right' width='40px'>");
                sw.WriteLine("ID");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='right' width='250px'>");
                sw.WriteLine("MODELO");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='right' width='300px'>");
                sw.WriteLine("FABRICANTE");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='right' width='200px'>");
                sw.WriteLine("ANO");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='right' width='150px'>");
                sw.WriteLine("COR");
                sw.WriteLine("</th>");
                sw.WriteLine("<tr>");

                int cont = 0;
                foreach (CAMADAS.MODEL.Avioes aviao in lstAviao)
                {
                    sw.WriteLine("<tr>");
                    sw.WriteLine("<td align='right' width='40px'>");
                    sw.WriteLine(aviao.id);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='right' width='250px'>");
                    sw.WriteLine(aviao.modelo);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='right' width='300px'>");
                    sw.WriteLine(aviao.fabricante);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='right' width='200px'>");
                    sw.WriteLine(aviao.ano);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='right' width='150px'>");
                    sw.WriteLine(aviao.cor);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<tr>");
                    cont++;
                }
                sw.WriteLine("</table>");
                sw.WriteLine("<hr align='left' border:'5px' />");
                sw.WriteLine("<h3>Modelos disponiveis: {0}", cont);
                sw.WriteLine("");
                sw.WriteLine("");
                sw.WriteLine("");
                sw.WriteLine("</body>");
                sw.WriteLine("</html>");

            }
            System.Diagnostics.Process.Start(arquivo);
        }

        public static void relCliente()
        {
            CAMADAS.BLL.Clientes bllCliente = new CAMADAS.BLL.Clientes();
            List<CAMADAS.MODEL.Clientes> lstCliente = new List<CAMADAS.MODEL.Clientes>();
            lstCliente = bllCliente.Select().OrderBy(o => o.nome).ToList();

            string pasta = Funcoes.diretorioPasta();
            string arquivo = pasta + @"\RelatorioClientes.html";
            StreamWriter sw = new StreamWriter(arquivo);
            using (sw)
            {
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine("<meta http-equiv = 'Content-Type' content='text/html; charset=utf-8'/>");
                sw.WriteLine("<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css' integrity='sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk' crossorigin='anonymous'>");
                sw.WriteLine("</head>");
                sw.WriteLine("<body>");
                sw.WriteLine("<h1> <center>Relatório de Clientes <center> </h1>");
                sw.WriteLine("<hr align='left' border:'5px' />");
                sw.WriteLine("</br>");
                sw.WriteLine("<table class='table table - dark'>");
                sw.WriteLine("<tr align='right'>");
                sw.WriteLine("<th align='right' width='40px'>");
                sw.WriteLine("ID");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='right' width='250px'>");
                sw.WriteLine("NOME");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='right' width='150px'>");
                sw.WriteLine("CPF");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='right' width='150px'>");
                sw.WriteLine("RG");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='right' width='150px'>");
                sw.WriteLine("ENDERECO");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='right' width='150px'>");
                sw.WriteLine("CIDADE");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='right' width='150px'>");
                sw.WriteLine("UF");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='right' width='150px'>");
                sw.WriteLine("TELEFONE");
                sw.WriteLine("</th>");
                sw.WriteLine("<tr>");

                int cont = 0;
                foreach (CAMADAS.MODEL.Clientes cliente in lstCliente)
                {
                    sw.WriteLine("<tr>");
                    sw.WriteLine("<td align='right' width='40px'>");
                    sw.WriteLine(cliente.id);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='right' width='250px'>");
                    sw.WriteLine(cliente.nome);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='right' width='300px'>");
                    sw.WriteLine(cliente.cpf);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='right' width='200px'>");
                    sw.WriteLine(cliente.rg);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='right' width='150px'>");
                    sw.WriteLine(cliente.endereco);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='right' width='250px'>");
                    sw.WriteLine(cliente.cidade);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='right' width='250px'>");
                    sw.WriteLine(cliente.uf);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='right' width='250px'>");
                    sw.WriteLine(cliente.telefone);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<tr>");
                    cont++;
                }
                sw.WriteLine("</table>");
                sw.WriteLine("<hr align='left' border:'5px' />");
                sw.WriteLine("<h3>Numero de Clientes: {0}", cont);
                sw.WriteLine("");
                sw.WriteLine("");
                sw.WriteLine("");
                sw.WriteLine("</body>");
                sw.WriteLine("</html>");

            }
            System.Diagnostics.Process.Start(arquivo);
        }

    }
}
