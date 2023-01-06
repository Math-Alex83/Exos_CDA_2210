using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedLine.Cartes
{
    internal abstract class Carte
    {
        protected string texte;

        public Carte(string _texte)
        {
            texte = _texte;
        }

        public abstract bool PlacerDans(Paquet p);

    }
}
