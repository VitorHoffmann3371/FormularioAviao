using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVIOES.CAMADAS.BLL
{
    public class ItensAluguel
    {
        public List<MODEL.ItensAluguel> Select()
        {
            DAL.ItensAluguel dalItensAluguel = new DAL.ItensAluguel();
            return dalItensAluguel.Select();
        }

        public List<MODEL.ItensAluguel> SelectByAlug(int idAlug)
        {
            DAL.ItensAluguel dalItensAluguel = new DAL.ItensAluguel();
            return dalItensAluguel.SelectByAlug(idAlug);
        }

        public void Insert (MODEL.ItensAluguel item)
        {
            DAL.ItensAluguel dalItensAluguel = new DAL.ItensAluguel();
            dalItensAluguel.Insert(item);
        }

        public void Update(MODEL.ItensAluguel item)
        {
            DAL.ItensAluguel dalItensAluguel = new DAL.ItensAluguel();
            dalItensAluguel.Update(item);
        }

        public void Delete(int id)
        {
            DAL.ItensAluguel dalItensAluguel = new DAL.ItensAluguel();
            dalItensAluguel.Delete(id);
        }
    }
}
