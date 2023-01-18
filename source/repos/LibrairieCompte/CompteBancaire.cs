using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrairieCompte
{
    public class CompteBancaire
    {
        private string id_Compte;
        private string nom;
        private string prenom;
        private float solde;
        private float decouvertAutorise;

        public CompteBancaire(string _id_Compte, string _nom, string _prenom, float _solde, float _decouvertAutorise)
        {
            id_Compte = _id_Compte;
            nom = _nom;
            prenom = _prenom;
            solde = _solde;
            decouvertAutorise = _decouvertAutorise;
        }

        public bool Superieur(CompteBancaire autreCompte)
        {
            if (solde.CompareTo(autreCompte.solde) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Crediter(float montant)
        {
            throw new System.NotImplementedException();
        }

        public bool Debiter(float montant)
        {
            throw new System.NotImplementedException();
        }

        public bool Transferer(CompteBancaire CompteDestinataire, float montant)
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
