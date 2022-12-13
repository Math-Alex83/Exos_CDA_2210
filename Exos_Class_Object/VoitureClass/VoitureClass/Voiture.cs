using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoitureClass
{
    public class Voiture
    {
        bool avance;
        bool estArretee;
        bool monMoteur;
        /// <summary>
        /// Constructeur par défault de la classe Voiture
        /// </summary>
        public Voiture()
        {
        }

        public bool Demarrer()
        {
            return (monMoteur)? false : true && (monMoteur=true);
        }





    }
}
