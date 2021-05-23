using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Patiserie.Librarie;

namespace Data
{
    public interface IStocareData
    {
        void AddProdus(Produse p);
        ArrayList GetInfoProduse();
        List<Produse> GetInfoProduseList();
        public Produse GetProdus(string nume);
        public Produse GetProdusId(int id);
        public bool UpdateProdus(string _id, string _pret);
    }
}
