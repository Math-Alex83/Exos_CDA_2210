internal class Program
{
    private static void Main(string[] args)
    {
        /*
            L'algorithme lit un mot proposé par un premier joueur.
            Ce mot a une longueur minimum de 5 caractères(à contrôler).
            L'algorithme affiche ensuite le mot où toutes les lettres sauf la première et la dernière sont remplacées par un tiret. 
            Un deuxième joueur propose des lettres une à une.
            Chaque fois que la lettre proposée se trouve dans le mot, l'algorithme remplace les tirets qui remplaçaient cette lettre et
            réaffiche le mot.
            Le second joueur a droit à un maximum de 6 erreurs pour retrouver toutes les lettres.
        */

        string user1Input;
        char user2Input;

        char[] tabMot;
        char[] tabMotCacher;
        int erreurs = 6;

        // DEMANDE ET RECUPERATION
        Console.WriteLine("Veuillez saisir un mot d'au moins 5 lettres svp.");
        user1Input = Console.ReadLine();

        // conversion dsaisie string en tab char
        tabMot = user1Input.ToCharArray();
        tabMotCacher = tabMot;

        // DANS LE TABLEAU DE CHAR,JE REMLACE LES CARACTERES SAUF LA PREMIERE ET LA DERNIERE
        for (int i=1; i < tabMotCacher.Length-1; i++)
        {
            tabMotCacher[i] = '_';
        }

        //AFFICHAGE DU tabMotCacher (facultatif) pour voir la modif
        AffichageDuTableau(tabMotCacher);

        Console.WriteLine("Pressez une touche et appelez le joueur 2 svp");
        Console.ReadKey();
        Console.Clear();

        // DEBUT DE PARTIE JOUEUR 2

        // Boucle d'opperation pour un tour de jeu
        do
        {
            Console.WriteLine($"Joueur 2 entrer une lettre, vous avez droit à {erreurs} erreurs pour trouver le mots. GOOD LUCK ");
            AffichageDuTableau(tabMotCacher);

            //RECUPERATION DE LA SAISIE JOUEUR 2
            user2Input = Console.ReadLine()[0];
            Console.WriteLine(user2Input);

            for (int i = 1; i < tabMotCacher.Length - 1; i++)
            {
                if ((char)tabMot[i] == user2Input)
                {
                    tabMotCacher[i] = user2Input;
                }
                else
                {
                    erreurs--;
                    Console.WriteLine((char)tabMot[i]);
                }
            }


        }
        while (erreurs > 0 || tabMotCacher == tabMot);



    }
    static void AffichageDuTableau(char[] _tabMot)
    {
        foreach (int i in _tabMot)
        {
            Console.Write((char)i); // char sinon affiche le code aski
        }
        Console.WriteLine();//pour passer à la ligne
    }
    /* void wordToFind()
     {
         do
         {
             Console.WriteLine("Joueur 1 veuillez-saisir un mot de 5 lettres minimum svp.");
             user1Input = Console.ReadLine();
         }
         while (user1Input.Length < 5);
         {
            // convertie l'entrée string du 1er joueur en tableau de char
             tabMot = user1Input.ToCharArray();
    
             tabMotCacher = tabMot; 
         }

    // transformation des lettres à trouver par des tirets à partir de la 2eme lettres 
    jusqu'à l'avant dernière du tableau.

         for (int i = 1; i < tabMotCacher.Length - 1; i++) 
         {
             tabMotCacher[i] = '_';
         }
     }//Sert à entrer un mot et le scinder en caracteres et cacher les lettres à trouver
    */
}