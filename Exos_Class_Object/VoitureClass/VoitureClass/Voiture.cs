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
        private Roue sesRoues;
        private Dictionary<string, Roue> dicRoues;//{ get; }

        public Voiture()
        {
            string marque;
            string modele;
            string couleur;
            dicRoues = new Dictionary<string, Roue>();


            dicRoues.Add("rag", new Roue());
            dicRoues.Add("rad", new Roue());
            dicRoues.Add("rarg", new Roue());
            dicRoues.Add("rard", new Roue());
            dicRoues.Add("rds", new Roue());

        }
        /// <summary>
        /// Pour démarrer le moteur
        /// </summary>
        /// <returns></returns>
        public bool Demarrer()
        {
            return sonMoteur.MoteurTourne();

        }
        /// <summary>
        /// Pour couper le moteur
        /// </summary>
        /// <returns></returns>
        public bool CouperContact()
        {
            return sonMoteur.MoteurArret();
        }
        /// <summary>
        /// Pour faire avancer les roues
        /// </summary>
        /// <returns></returns>
        public bool Avancer()
        {
            return sonMoteur.EntraineLesRoues(dicRoues["rag"], dicRoues["rad"], dicRoues["rarg"], dicRoues["rard"]);
        }
        /// <summary>
        /// Pour arreter les roues
        /// </summary>
        /// <returns></returns>
        public bool Freiner()
        {
            return sesRoues.RoueArret();
        }

    }
}
