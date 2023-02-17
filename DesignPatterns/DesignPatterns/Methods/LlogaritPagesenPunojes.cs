using DesignPatterns.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Methods
{
    public class LlogaritPagesenPunojes : LlogaritPagesenBaze
    {
        public LlogaritPagesenPunojes(Punonjesi _punonjesi)
           : base(_punonjesi)
        {

        }
        public override decimal llogaritPagen() => _punonjesi.PagesaPerOre * _punonjesi.OretEPunes;
    }
}
