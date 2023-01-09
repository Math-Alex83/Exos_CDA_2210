using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrairieCompte
{
    /// <summary>
    /// Class compte bancaire
    /// </summary>
    public class CompteBancaire
    {
        private string id_Compte;
        private string nom;
        private string prenom;
        private double solde;
        private double decouvertAutorise;

        public double Solde { get => solde;  }
        public double DecouvertAutorise { get => decouvertAutorise; }
        public string Prenom { get => prenom; }
        public string Nom { get => nom; }
        public string Id_Compte { get => id_Compte; }
        /// <summary>
        /// Constructeur avec parametre 
        /// </summary>
        /// <param name="_id_Compte"></param>
        /// <param name="_nom"></param>
        /// <param name="_prenom"></param>
        /// <param name="_solde"></param>
        /// <param name="_decouvertAutorise"></param>
        public CompteBancaire(string _id_Compte, string _nom, string _prenom, double _solde, double _decouvertAutorise)
        {
            
            if (_decouvertAutorise > 0)
                throw new CreateAccountException("Impossible de créer un compte avec un découvert autorisé positif");

            id_Compte = _id_Compte;
            nom = _nom;
            prenom = _prenom;
            solde = _solde;
            decouvertAutorise = _decouvertAutorise;
        }

        /// <summary>
        /// compare le solde de deux comptes
        /// </summary>
        /// <param name="autreCompte"></param>
        /// <returns>boolean</returns>
        public bool Superieur(CompteBancaire autreCompte)
        {
            // Version Plus simple if (this.solde > autreCompte.solde)
            if (solde.CompareTo(autreCompte.solde) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Credite le compte actuel
        /// </summary>
        /// <param name="_montant"></param>
        /// <returns>boolean</returns>
        public bool Crediter(double _montant)
        {
            if (_montant>0)
            {
                this.solde += _montant;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Debite le compte actuel
        /// </summary>
        /// <param name="_montant"></param>
        /// <returns>boolean</returns>
        public bool Debiter(double _montant)
        {
            if ( _montant >= 0 && (this.solde - _montant) >= this.decouvertAutorise)
            {
                this.solde -= _montant;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Transfere d'un compte vers un autre compte
        /// </summary>
        /// <param name="CompteDestinataire"></param>
        /// <param name="_montant"></param>
        /// <returns>boolean</returns>
        public bool Transferer(CompteBancaire CompteDestinataire, double _montant)
        {
            if (Debiter(_montant))
            {                
                return CompteDestinataire.Crediter(_montant);
            }
            return false;


        }
        
        
        /// <summary>
        /// Affichage infos compte bancaire actuel
        /// </summary>
        /// <returns>String</returns>
        public override string ToString() { 

            return String.Format("id_compte : {0}, nom : {1}, prenom : {2}, solde: {3}, decouvertAutorise : {4}",
                        id_Compte, nom, prenom, solde, decouvertAutorise);
        }
        
    }
}
