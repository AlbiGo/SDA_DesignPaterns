using DesignPatterns.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Methods
{
    public abstract class LlogaritPagesenBaze
    {
        public Punonjesi _punonjesi { get; set; }
        public LlogaritPagesenBaze(Punonjesi punonjesi)
        {
            _punonjesi = punonjesi;
        }
        public abstract decimal llogaritPagen();
    }
}
