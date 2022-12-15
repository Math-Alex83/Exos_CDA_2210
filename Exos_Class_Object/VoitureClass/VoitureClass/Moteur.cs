using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoitureClass
{
    public class Moteur
    {
        private bool moteurEnMarche { get; set; }
        private bool roueEnMouvement;

        public bool MoteurEnMarche { get => moteurEnMarche; } //set => moteurEnMarche = value; }

        /// <summary>
        /// constructeur Moteur par défault
        /// </summary>
        public Moteur()
        {
            string typeDeCarburant = "Disel";
            string cylindree = "120 Cv";
            string typeDeTraction = "Traction Avant";
            moteurEnMarche = false;
        }
        /// <summary>
        /// Mise en route du moteur au démarrage
        /// </summary>
        /// <returns></returns>
        public bool MoteurTourne()
        {
            if (moteurEnMarche)
            {
                return false;
            }
            else
            {
                this.moteurEnMarche = true;
                return true;
            }
        }
        /// <summary>
        /// Mise à l'arret du moteur à la coupure du contact
        /// </summary>
        /// <returns></returns>
        public bool MoteurArret()
        {
            if (!moteurEnMarche)
            {
                return false;
            }
            else
            {
                moteurEnMarche = false;
                return true;
            }
        }
        /// <summary>
        /// Fait avancer les roues
        /// </summary>
        /// <param name="r1"></param>
        /// <param name="r2"></param>
        /// <param name="r3"></param>
        /// <param name="r4"></param>
        /// <returns></returns>
        public bool EntraineLesRoues(Roue r1, Roue r2, Roue r3, Roue r4)
        {
            if (moteurEnMarche)
            {
                roueEnMouvement = true;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
