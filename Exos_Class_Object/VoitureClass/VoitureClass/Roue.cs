using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoitureClass
{
    internal class Roue
    {
        bool roule;

        public Roue()
        {
            roule = false;
            
        }

        public bool RoueAvance()
        {
            roule = true;
            return true;
        }

        public bool Stopper()
        {
            roule = false;
            return true;
        }




    }
}
