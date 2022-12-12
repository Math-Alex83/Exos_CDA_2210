using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoitureClass
{
     class Moteur
    {
        bool moteurTourne = false;

        public void _Moteur()
        {}

        public bool MoteurTourne() 
        {
            if (moteurTourne == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool FaitAvancerLesRoues()
        {

        }
    }
}
