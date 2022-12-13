using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoitureClass
{
    internal class Moteur
    {
        // private bool moteurAdemarrer; -> Correspond au retour de MettreLeContact
        private bool moteurTourne;
        private bool faitAvancerLesRoues;
        /// <summary>
        /// constructeur Moteur
        /// </summary>
        public Moteur()
        {
            moteurTourne = false;
            faitAvancerLesRoues = false;
        }
       
        /// <summary>
        /// methode pour faire tourner le moteur
        /// </summary>
        /// <returns>boolean</returns>
        public bool MettreLeContact() 
        {
            /*if (moteurAdemarrer == true)
            {
                return true;
            }
            else
            {
                return false;
            }*/
            if (!moteurTourne)
            {
                moteurTourne = true;
                return true;
            }
            return false;

        }

        /// <summary>
        /// methode pour faire avancer les roues
        /// </summary>
        /// <returns>boolean</returns>
        public bool FaitAvancerLesRoues(Roue r1, Roue r2, Roue r3, Roue r4)
        {
            if (faitAvancerLesRoues)
                return false;
            faitAvancerLesRoues = r1.RoueAvance() && r2.RoueAvance() && r3.RoueAvance() && r4.RoueAvance();
            return faitAvancerLesRoues;

        }

        public bool ArreterLesRoues(Roue r1, Roue r2, Roue r3, Roue r4)
        {
            if (!faitAvancerLesRoues)
                return false;
            faitAvancerLesRoues = !(r1.Stopper() && r2.Stopper() && r3.Stopper() && r4.Stopper());
            return faitAvancerLesRoues;
        }

        public bool Demarrer()
        {
            throw new NotImplementedException();
        }

    }
}
