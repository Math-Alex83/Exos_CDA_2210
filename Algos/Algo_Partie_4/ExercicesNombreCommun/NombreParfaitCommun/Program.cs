internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * VARIABLE :
         *  Entier nbrAtrouver
         *  Liste<entier> listeDiviseur
         *  entier nbrParfaitTrouver "iterration de la boucle tant que"
         *  entier sommeDiviseur
         *  entier nbrCourant = 0
         *  
         * TRAITEMENT :
         *  Ecrire "Bonjour, vous êtes sur le programme qui vous affiche une certaine quantité de nombre parfaits"
         *  Ecrire "Combien de nombre parfait souhaitez-vous connaître ? (réponse en dessous de 4 attendu)"
         *  nbrAtrouver <-- ReccupDeSaisie()
         *   Tant que nbrParfaitTrouver est < à nbrAtrouver
         *      result <-- 1
         *      listeDiviseur <-- TrouveDiviseur(nbrParfaitTrouver)
         *      pour chaque entier dans listeDiviseur Faire
         *      sommeDiviseur <-- sommeDiviseur + diviseurCourant //(variable de la boucle foreach)
         *  Fin pour chaque
         *
         *  Si sommeDiviseur est egale à nbrCourant
         *    nbrParfaitTrouver <-- nbrParfaitTrouver +1
         *  Fin si 
         * nbrCourant <-- nbrCourant +1
         *  Fin tant que
         *
         *AFFICHAGE :
         *
         *FONCTION :
         *ReccupDeSaisie() : entier
         *TrouverLesDiviseurs(int) : List<int>
         *
         *
         ********************************DEBUT CODE EXO NOMBRE PARFAIT*****************************************************
         */

        int nombreAtrouver = 0;
        List<int> listeDiviseur;
        int nbrParfaitATrouver = 0;
        int sommeDiviseur;
        int nbrCourant = 2;

        Console.WriteLine("Saisir un nombre entier svp");

        nombreAtrouver = ExercicesNombreCommun.Program.ReccupDeSaisie();
        while (nbrParfaitATrouver < nombreAtrouver)
        {
            sommeDiviseur = 1;
            listeDiviseur = ExercicesNombreCommun.Program.TrouverLesDiviseurs(nbrCourant);

            foreach (int diviseurCourant in listeDiviseur)
            {
                sommeDiviseur = sommeDiviseur + diviseurCourant;
            }
            if (sommeDiviseur == nbrCourant)
            {
                ++nbrParfaitATrouver;
                Console.WriteLine(nbrCourant + " est un nombre parfait.");
            }
            ++nbrCourant;
        }
    }
}