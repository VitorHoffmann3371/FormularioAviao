using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVIOES.CAMADAS.BLL
{
    public class Avioes
    {
        public List<MODEL.Avioes> Select()
        {
            DAL.Avioes dalAviao = new DAL.Avioes();
            return dalAviao.Select();
        }

        public List<MODEL.Avioes> SelectByID(int id)
        {
            DAL.Avioes dalAviao = new DAL.Avioes();
            return dalAviao.SelectByID(id);
        }

        public List<MODEL.Avioes> SelectByModelo(string modelo)
        {
            DAL.Avioes dalAviao = new DAL.Avioes();
            return dalAviao.SelectByModelo(modelo);
        }

        public MODEL.Avioes SelectByModeloNew(string modelo)
        {
            DAL.Avioes dalAvi = new DAL.Avioes();
            return dalAvi.SelectByModeloNew(modelo);
        }

        public void Insert(MODEL.Avioes aviao)
        {
            DAL.Avioes dalAviao = new DAL.Avioes();
            dalAviao.Insert(aviao);
        }

        public void Update(MODEL.Avioes aviao)
        {
            DAL.Avioes dalAviao = new DAL.Avioes();
            dalAviao.Update(aviao);
        }

        public void Delete(int idAviao)
        {
            DAL.Avioes dalAviao = new DAL.Avioes();
            dalAviao.Delete(idAviao);
        }

        public void Alugar(MODEL.Avioes aviao)
        {

        }

        public void Devolver(MODEL.Avioes aviao)
        {

        }
    }
}
