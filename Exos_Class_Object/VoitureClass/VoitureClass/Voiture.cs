using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoitureClass
{
    public class Voiture
    {
        private Moteur sonMoteur;
        private Dictionary<string, Roue> mesRoues;

        public Voiture()
        {
            mesRoues = new Dictionary<string, Roue>();
            mesRoues.Add("rag",new Roue());
            mesRoues.Add("rad", new Roue());
            mesRoues.Add("rarg", new Roue());
            mesRoues.Add("rard", new Roue());
            mesRoues.Add("rds", new Roue());
        }

        public bool Demarrer()
        {
            return sonMoteur.Demarrer();
        }

        public bool Avancer()
        {
            return sonMoteur.FaitAvancerLesRoues(mesRoues["rag"], mesRoues["rad"], mesRoues["rarg"], mesRoues["rard"]);
        }


    }
}
