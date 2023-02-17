using DesignPatterns.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Methods
{
    public class LlogaritPagesenDrejor : LlogaritPagesenBaze
    {
        private readonly int bonus = 4;
        public LlogaritPagesenDrejor(Punonjesi _punonjesi)
         : base(_punonjesi)
        {

        }
        public override decimal llogaritPagen() => _punonjesi.PagesaPerOre * _punonjesi.OretEPunes * bonus;
    }
}
