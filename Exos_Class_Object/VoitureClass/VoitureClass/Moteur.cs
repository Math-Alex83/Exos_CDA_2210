using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoitureClass
{
    public class Moteur
    {
        private bool moteurAdemarrer;
        private bool moteurTourne;
        private bool faitAvancerLesRoues;
        /// <summary>
        /// constructeur Moteur
        /// </summary>
        public Moteur()
        {}
       
        /// <summary>
        /// methode pour faire tourner le moteur
        /// </summary>
        /// <returns>boolean</returns>
        public bool MoteurTourne() 
        {
            /*if (moteurAdemarrer == true)
            {
                return true;
            }
            else
            {
                return false;
            }*/
            if (!moteurAdemarrer)
            {
                moteurAdemarrer = true;
                return true;
            }
            return false;

        }
        /// <summary>
        /// methode pour faire avancer les roues
        /// </summary>
        /// <returns>boolean</returns>
        public bool FaitAvancerLesRoues()
        {
            if (faitAvancerLesRoues==true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
