using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classLepidoptere
{
    class Chrysalide : StadeEvolution
    {
        public override string SeDeplacer()
        {
            return "Ne se déplace pas.";
        }

        public override StadeEvolution SeMetamorphoser()
        {
            return new Papillon();
        }
    }
}
