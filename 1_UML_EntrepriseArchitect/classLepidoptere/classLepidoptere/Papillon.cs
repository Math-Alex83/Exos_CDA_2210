using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classLepidoptere
{
    class Papillon : StadeEvolution
    {
        public Papillon() 
        {}

        public override string SeDeplacer()
        {
            return "Je vole.";
        }

        public override StadeEvolution SeMetamorphoser()
        {
            return this;
        }
    }
}
