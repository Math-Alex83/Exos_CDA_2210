using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedLine.Cartes
{
    internal class CarteQuestion : Carte
    {
        public CarteQuestion(string _texte) : base(_texte)
        {
        }

        public override bool PlacerDans(Paquet p)
        {
            return p.AjouterCarteQuestion(this);
        }
    }
}
