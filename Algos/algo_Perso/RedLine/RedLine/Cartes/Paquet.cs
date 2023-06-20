using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedLine.Cartes
{
    internal abstract class Paquet
    {
        List<Carte> sesCartes;

        public Paquet()
        {
            sesCartes = new();
        }

        public virtual bool AjouterCarteQuestion(CarteQuestion carte)
        {
            return AjouterCarte(carte);
        }

        public virtual bool AjouterCarteReponse(CarteReponse carte)
        {
            return AjouterCarte(carte);
        }

        private bool AjouterCarte(Carte c)
        {
            sesCartes.Add(c);
            return true;
        }
    }
}
