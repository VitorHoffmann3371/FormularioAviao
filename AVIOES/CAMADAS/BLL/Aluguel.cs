using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVIOES.CAMADAS.BLL
{
    public class Aluguel
    {
        public List<MODEL.Aluguel> Select()
        {
            DAL.Aluguel dalAluguel = new DAL.Aluguel();
            return dalAluguel.Select();
        }

        public void Insert(MODEL.Aluguel aluguel)
        {
            DAL.Aluguel dalAluguel = new DAL.Aluguel();
            dalAluguel.Insert(aluguel);
        }

        public void Update(MODEL.Aluguel aluguel)
        {
            DAL.Aluguel dalAluguel = new DAL.Aluguel();
            dalAluguel.Update(aluguel);
        }

        public void Delete(int idAluguel)
        {
            DAL.Aluguel dalAluguel = new DAL.Aluguel();
            dalAluguel.Delete(idAluguel);
        }
    }
}
