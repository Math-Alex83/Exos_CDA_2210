using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedLine.Cartes
{
    internal class PaquetQuestion : Paquet
    {
        public override bool AjouterCarteReponse(CarteReponse carte)
        {
            return false;
        }
    }
}
