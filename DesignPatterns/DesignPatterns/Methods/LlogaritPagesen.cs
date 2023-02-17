using DesignPatterns.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Methods
{
    public class LlogaritPagesen
    {
        protected List<LlogaritPagesenBaze> _llogaritPagesenBazes { get; set; }

        public LlogaritPagesen(List<LlogaritPagesenBaze> llogaritPagesenBazes)
        {
            _llogaritPagesenBazes = llogaritPagesenBazes;
        }

        public List<decimal> llogaritPagesen()
        {
            List<decimal> pagesat = new List<decimal>();

            foreach(var llogarit in _llogaritPagesenBazes)
            {
                decimal pagesa = 0;// _punonjesi.OretEPunes * _punonjesi.PagesaPerOre;
                pagesa = llogarit.llogaritPagen();
                pagesat.Add(pagesa);
            }
            return pagesat;
        }
    }
}
