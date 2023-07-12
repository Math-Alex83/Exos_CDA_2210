using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression
{
    internal class Calculer
    {
        static double Additionner(double _valeurG, double _valeurD)
        {
            double resultat = _valeurG + _valeurD;
            return resultat;
        }

        static double Soustraire(double _valeurG, double _valeurD)
        {
            double resultat = _valeurG - _valeurD;
            return resultat;
        }
    }
}
