using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classLepidoptere
{
     class Oeuf : StadeEvolution
    {
        public Oeuf() 
        { }
        public override string SeDeplacer()
        {
            return "Reste sur place";
        }
        public override StadeEvolution SeMetamorphoser()
        {
            return new Chenille();
        }
    }
}
