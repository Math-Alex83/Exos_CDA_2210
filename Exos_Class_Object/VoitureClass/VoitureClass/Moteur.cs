using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoitureClass
{
    internal class Moteur
    {
        private bool moteurEnMarche;
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
        internal bool MoteurTourne()
        {
            if (moteurEnMarche)
            {
                return false;
            }
            else
            {
                moteurEnMarche = true;
                return true;
            }
        }
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
