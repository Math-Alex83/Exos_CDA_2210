using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibli_Addition
{
    public class Addition
    {
        List<int> mesNbs;


        /// <summary>
        /// Constructeur par default Avec List
        /// </summary>
        public Addition()
        {
            mesNbs = new List<int> { };
        }

        public void Add(int nb)
        {
             mesNbs.Add(nb);

        }

        /// <summary>
        /// Méthode pour Calculer les données saisie par l'utilisateur
        /// </summary>
        /// <returns></returns>
        public int Calculer()
        {
            int resultat=0;
            foreach (int nb in mesNbs)
            {
                resultat += nb;
            }
            return resultat;
        }
        

        /// <summary>
        /// Méthode pour vider la Liste
        /// </summary>
        public void Vider()
        {
            mesNbs.Clear();

        }
    }
}
