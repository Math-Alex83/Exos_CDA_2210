using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Bouteille
    {
        private float contenantEnCl;
        private float contenuEnCl;
        private bool estOuverte;

        /*
        /// <summary>
        /// Constructeur par default
        /// </summary>
        public Bouteille() // constructeur par default
        {
            contenantEnCl = 100;
            contenuEnCl = 100;
            estOuverte = false;
        }
        */

        /*
        /// <summary>
        /// Constructeur avec dépendance (this)
        /// </summary>
        /// <param name="contenantEnCl"></param>
        /// <param name="contenuEnCl"></param>
        /// <param name="estOuverte"></param>
        public Bouteille(float contenantEnCl,float contenuEnCl,bool estOuverte)
        {
            this.contenantEnCl = contenantEnCl;
            this.contenuEnCl = contenuEnCl;
            this.estOuverte = estOuverte;
        }
        */
        /// <summary>
        /// constructeur classique
        /// </summary>
        /// <param name="_contenanceEnCl"></param>
        /// <param name="_contenuActuelEnCl"></param>
        /// <param name="_estOuverte"></param>
        public Bouteille(float _contenanceEnCl, float _contenuActuelEnCl, bool _estOuverte)
        {
            contenantEnCl = _contenanceEnCl;
            contenuEnCl = _contenuActuelEnCl;
            estOuverte = _estOuverte;
        }

        /// <summary>
        /// Constructeur par recopie (clonage)
        /// </summary>
        /// <param name="_bouteilleACopier"></param>
        public Bouteille (Bouteille _bouteilleACopier)
        {
            contenantEnCl = _bouteilleACopier.contenantEnCl;
            contenuEnCl = _bouteilleACopier.contenuEnCl;
            estOuverte = _bouteilleACopier.estOuverte;
        }

        /// <summary>
        /// Pour ouvrir la bouteille
        /// </summary>
        /// <returns></returns>
        public bool Ouvrir()
        {
            if (estOuverte == false) // Si bouteille est fermée
            {
                estOuverte = true; // tu me passe l'état à ouverte
                Console.WriteLine("La bouteille est ouverte.");
                return true; // l'action d'ouvrir la bouteille a réussit
            }
            else
            {
                Console.WriteLine("Echec de l'opération 'Ouvrir'.");
                return false; // Si la bouteille est déjà ouverte, tu retourne que l'action a échouée.
            }


        }

        /// <summary>
        /// Fermeture de la bouteille
        /// </summary>
        /// <returns></returns>
        public bool Fermer()
        {
            if (estOuverte == true)
            {
                estOuverte = false;
                Console.WriteLine("La bouteille est fermée.");
                return true;
            }
            else
            {
                Console.WriteLine("Echec de l'opération 'Fermer'.");
                return false;
            }
        }

        /// <summary>
        /// Pour vider une certaines quantités.Avec ouverture et fermeture.
        /// </summary>
        /// <param name="quantiteAViderEnCl"></param>
        /// <returns>boolean</returns>
        public bool Vider(float _quantiteAViderEnCl)
        {
            if (contenuEnCl >= _quantiteAViderEnCl && _quantiteAViderEnCl > 0)
            {
                if (estOuverte == true)
                {
                    contenuEnCl -=_quantiteAViderEnCl;
                    Console.WriteLine($"Il reste {contenuEnCl}Cl dans la bouteille.");
                    Fermer();
                    return true;
                }
                else
                {
                    Ouvrir();
                    contenuEnCl -=_quantiteAViderEnCl;
                    Console.WriteLine($"Il reste {contenuEnCl}Cl dans la bouteille.");
                    Fermer();
                    return true;
                }
            }
            else
            {
                Console.WriteLine("Echec de l'opération 'Vider'.");
                return false;
            }
        }
        /// <summary>
        /// Surcharge de Vider pour Vider le contenu total.
        /// </summary>
        /// <returns></returns>
        public bool Vider()
        {
            return Vider(this.contenuEnCl);
        }

        /// <summary>
        /// Pour vider la bouteille en entiere,Avec ouverture et fermeture.
        /// </summary>
        /// <returns></returns>
        public bool ViderTout()
        {
            if (contenuEnCl > 0.000F)
            {
                if (estOuverte == true)
                {
                    contenuEnCl = 0.000F;
                    Console.WriteLine($"La bouteille contient {contenuEnCl} à présent.");
                    Fermer();
                    return true;
                }
                else
                {
                    Ouvrir();
                    contenuEnCl = 0.000F;
                    Console.WriteLine($"La bouteille contient {contenuEnCl} à présent.");
                    Fermer();
                    return true;
                }
            }
            else
            {
                Console.WriteLine("Echec de l'opération 'ViderTout'.");
                return false;
            }
        }

        /// <summary>
        /// Pour Remplir une certaine quantité en Cl,Avec ouverture et fermeture.
        /// </summary>
        /// <param name="quantiteARemplirEnCl"></param>
        /// <returns></returns>
        public bool Remplir(float _quantiteARemplirEnCl)
        {
            float reste;
            if (contenuEnCl < contenantEnCl)
            {
                if (estOuverte == true)
                {
                    if ((contenuEnCl + _quantiteARemplirEnCl) > contenantEnCl)
                    {
                        contenuEnCl = contenuEnCl + _quantiteARemplirEnCl;
                        reste = (contenuEnCl + _quantiteARemplirEnCl) - contenantEnCl;
                        Console.WriteLine($"La bouteille contient {contenuEnCl}Cl à présent.");
                        Console.WriteLine($"il y a un surplus de {reste}Cl.");
                        Fermer();
                        return true;
                    }
                    else
                    {
                        contenuEnCl = contenuEnCl + _quantiteARemplirEnCl;
                        Console.WriteLine($"La bouteille contient {contenuEnCl}Cl à présent.");
                        Fermer();
                        return true;
                    }
                }
                else
                {
                    Ouvrir();
                    reste = contenantEnCl - (contenuEnCl + _quantiteARemplirEnCl);
                    contenuEnCl = contenuEnCl + _quantiteARemplirEnCl;
                    Console.WriteLine($"La bouteille contient {contenuEnCl}Cl à présent.");
                    Console.WriteLine($"il y a un surplus de {reste}Cl.");
                    Fermer();
                    return true;
                }
            }
            else
            {
                Console.WriteLine("Echec de l'opération 'Remplir'.");
                return false;
            }
        }

        /// <summary>
        /// Pour remplir toute la bouteille,Avec ouverture et fermeture.
        /// </summary>
        /// <returns></returns>
        public bool RemplirTout()
        {
            if (contenuEnCl < contenantEnCl)
            {
                if (estOuverte == true)
                {
                    contenuEnCl = contenantEnCl;
                    Console.WriteLine($"La bouteille contient : {contenuEnCl}Cl ");
                    Fermer();
                    return true;
                }
                else
                {
                    Ouvrir();
                    contenuEnCl = contenantEnCl;
                    Console.WriteLine($"La bouteille contient : {contenuEnCl}Cl ");
                    Fermer();
                    return true;
                }
            }
            else
            {
                Console.WriteLine("Echec de l'opération 'RemplirTout'.");
                return false;
            }
        }
    }
}
