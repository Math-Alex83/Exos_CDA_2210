using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoitureClass
{
    public class Roue
    {
        private bool roueEnMouvement { get; set; }

        public Roue()
        {
            roueEnMouvement = false;

        }
        /// <summary>
        /// Fait avancer les roues à la demande EntraineLesRoues
        /// </summary>
        /// <returns></returns>
        public bool RoueAvance()
        {
            roueEnMouvement = true;
            return true;
        }
        /// <summary>
        /// Arret les roues à la demande Freiner
        /// </summary>
        /// <returns></returns>
        public bool RoueArret()
        {
            roueEnMouvement = false;
            return true;
        }
    }
}
