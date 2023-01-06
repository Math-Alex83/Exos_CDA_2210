using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedLine.Cartes
{
    internal class CarteReponse : Carte
    {
        public CarteReponse(string _texte) : base(_texte)
        {
        }

        public override bool PlacerDans(Paquet p)
        {
            return p.AjouterCarteReponse(this);
        }
    }
}
