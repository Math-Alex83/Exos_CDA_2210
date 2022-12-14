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
        private Dictionary<string, Roue> sesRoues;

        public Voiture()
        {
            string marque;
            string modele;
            string couleur;

            sesRoues = new Dictionary<string, Roue>();
            GetSesRoues().Add("rag", new Roue());
            GetSesRoues1().Add("rad", new Roue());
            GetSesRoues2().Add("rarg", new Roue());
            GetSesRoues3().Add("rard", new Roue());
            GetSesRoues4().Add("rds", new Roue());

        }

        private Dictionary<string, Roue> GetSesRoues4()
        {
            return sesRoues;
        }

        private Dictionary<string, Roue> GetSesRoues3()
        {
            return sesRoues;
        }

        private Dictionary<string, Roue> GetSesRoues2()
        {
            return sesRoues;
        }

        private Dictionary<string, Roue> GetSesRoues1()
        {
            return sesRoues;
        }

        private Dictionary<string, Roue> GetSesRoues()
        {
            return sesRoues;
        }

        public bool Demarrer()
        {           
            return sonMoteur.MoteurTourne();

        }
        public bool CouperContact()
        {
            if (moteurEnMarche)
            {
                moteurEnMarche = false;
                return true;
            }
            else
            {

            }
        }
        public bool Avancer()
        {
            return sonMoteur.EntraineLesRoues(sesRoues["rag"], sesRoues["rad"], sesRoues["rarg"], sesRoues["rard"]);
        }


    }
}
