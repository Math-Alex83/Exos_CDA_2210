using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedLine.Cartes
{
    internal class PaquetReponse : Paquet
    {
        public override bool AjouterCarteQuestion(CarteQuestion carte)
        {
            return false;
        }
    }
}
