using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Expressions2
{
    public class Nombre : Expression
    {
        double valeur = 0;

        public override double Calculer() => valeur; //{return valeur;}

        public Nombre(double _valeur) {valeur = _valeur;}

        public new string ToString() => "valeur = " + valeur.ToString();
    }
}
