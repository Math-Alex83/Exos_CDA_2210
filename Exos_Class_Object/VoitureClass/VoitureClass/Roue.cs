using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoitureClass
{
    internal class Roue
    {
        bool roueEnMouvement;

        public Roue()
        {
            roueEnMouvement = false;
            
        }

        public bool RoueAvance()
        {
            roueEnMouvement = true;
            return true;
        }

        public bool RoueStop()
        {
            roueEnMouvement = false;
            return true;
        }
    }
}
