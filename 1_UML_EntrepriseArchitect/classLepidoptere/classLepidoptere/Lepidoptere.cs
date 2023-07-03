using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classLepidoptere
{
     public class Lepidoptere
    {
        private StadeEvolution stadeCourant;

        public Lepidoptere()
        {
            this.stadeCourant = new Oeuf();
        }

        public string SeDeplacer()
        {
            return this.stadeCourant.SeDeplacer();
        }

        public void SeMetamorphoser()
        {
            this.stadeCourant = this.stadeCourant.SeMetamorphoser();
        }

        public override string ToString()
        {
            //return base.ToString();
            return " stadeCourant = " + this.stadeCourant.ToString();
        }
    }
}
