/* DEMANDE D'INFO */
Console.WriteLine("Bonjour, veuillez entrer le nombre de cartes");
int nbCartes = int.Parse(Console.ReadLine());
if (nbCartes < 2)
{
    Console.WriteLine("Pas de chateau pour toi !");
} else
{
    int nbEtages = 1;
    nbCartes -= 2;
   /*
    * FORMULE DU TRAITEMENT
    * 
    *U0 = 2
    *Un + 1 = Un + 3
    *Un = U0 + 3n (3n
    *
    */


    while (nbCartes >= (2+3*nbEtages)) 
    {
        // IL RETIRE (2 + 3 * nbEtage) c'est le décompte.
        
        nbCartes -= (2 + 3 * nbEtages);

        // Ajoute 1 étage.
        nbEtages++;
    }
    Console.WriteLine("Vous avez fait " + nbEtages + (nbCartes > 0 ? " et il vous reste " + nbCartes + " cartes" : " tout rond !"));

}