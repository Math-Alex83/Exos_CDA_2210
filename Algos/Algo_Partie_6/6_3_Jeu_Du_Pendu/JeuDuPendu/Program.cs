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
        /*
        char[] tab1 = { 'a', 'b' };
        char[] tab2 = { 'a', 'b' };
        char[] tab3 = { 'a', 'c' };
        Console.WriteLine(tab1 == tab2 ? "oui" : "non");
        Console.WriteLine(tab1 == tab3 ? "oui" : "non");
        */

        string user1Input = "";
        char user2Input;
        char[] tabMot;
        char[] tabMotCacher;
        int erreurs = 6;
        bool lettreTrouver = false;
        bool tabEstEgal = false;

        // DEMANDE ET RECUPERATION
        Console.WriteLine("Veuillez saisir un mot d'au moins 5 lettres svp.");
        user1Input = Console.ReadLine();

        // conversion de la saisie string en tab char
        tabMot = user1Input.ToCharArray();

        // ATTENTION (=) avec les tableaux, copie la refference du tableau PAS juste les valeurs
        // Donc toutes modifs impactes AUSSI le tableau d'origine!! 
        //tabMotCacher = tabMot;

        // .Clone(); crée un new tableau avec les valeur DANS tabMotCacher et possède donc une reference qui lui est propre.
        tabMotCacher = (char[])tabMot.Clone();


        //test pour voire si il modiffit le tabMot
        //tabMotCacher[0] = 'N'; 

        // DANS LE TABLEAU DE CHAR,JE REMLACE LES CARACTERES SAUF LA PREMIERE ET LA DERNIERE
        for (int i = 1; i < tabMotCacher.Length - 1; i++)
        {
            tabMotCacher[i] = '_';
        }

        //AFFICHAGE DU tabMotCacher (facultatif) pour voir la modif
        AffichageDuTableau(tabMotCacher);


        // DEBUT DE PARTIE JOUEUR 2
        Console.WriteLine("Pressez une touche et appelez le joueur 2 svp");
        //Console.ReadKey();
        Console.Clear();


        // Boucle d'opperation pour un tour de jeu
        do
        {
            Console.WriteLine($"Joueur 2 entrer une lettre, vous avez droit à {erreurs} erreur(s) pour trouver le mots. GOOD LUCK ");
            AffichageDuTableau(tabMotCacher);

            //RECUPERATION DE LA SAISIE JOUEUR 2
            user2Input = Console.ReadLine()[0];
            Console.WriteLine(user2Input);

            // initialisation de i ici, cause parté de variable. 
            int i;
            // réinitialisation du boolean 'lettreTrouvée' à false.
            lettreTrouver = false;
            // Boucle for, parcourt le tabMot (sauf la première et la dernieère lettre qui est dja affichée) *
            // * pour trouver la correspondance avec la saisie du char par le joueur.
            for (i = 1; i < tabMot.Length - 1; i++)
            {
                if (tabMot[i] == user2Input)
                {
                    // Si correspondance, remplace le caractère et passe le boolean 'lettreTrouver' à true.
                    tabMotCacher[i] = user2Input;
                    lettreTrouver = true;

                    if (CompareTableau(tabMot,tabMotCacher))
                    {
                        // Compare si la taille et les valeurs des tableaux sont identiquent.
                        //Si oui passe le boolean 'tabEstEgal' à true, le jeux se termine = VICTOIRE!
                        tabEstEgal = true;
                    }
                    else
                    {
                        tabEstEgal = false;
                    }
                }
            }
            if (lettreTrouver == true)
            {
                Console.WriteLine($"Bravo, vous avez trouvé lettre '{user2Input}' du mot caché, continuez, vous avez encore {erreurs} chance(s) !");
                Console.WriteLine(tabMotCacher);
            }
            else
            {
                erreurs--;
                Console.WriteLine($"Oups! la lettre {user2Input} ne se trouve pas dans le mot caché, " +
                $"continuer il vous reste {erreurs} erreur(s)");

            }
        }
        // teste la condition de sortie, SI vie==0 ET sort SI le tabMotCacher du joueur correspond au tab de refférence.
        while (erreurs < 0 || CompareTableau(tabMot,tabMotCacher) == false);

//************************************** SORTIE DE BOUCLE ******************************************************************************************

        if (tabEstEgal == true)
        {
            Console.WriteLine($"FELICITATIONS !! Vous avez trouvé le mot caché {tabMot.Length}");
        }
        else if (erreurs < 0 && tabMotCacher != tabMot)
        {
            Console.WriteLine("BRAVO !! Non, je rigole.... Trop nul dudulle! ");
        }
    }
    /// <summary>
    /// Affichage d'un tableau
    /// </summary>
    /// <param AffichageDuTableau="_tabMot"></param>
    static void AffichageDuTableau(char[] _tabMot)
    {

        foreach (int i in _tabMot)
        {
            Console.Write((char)i); // char sinon affiche le code aski
        }
        Console.WriteLine();//pour passer à la ligne
    }

    /// <summary>
    /// Comparare 2 tableaux de char
    /// </summary>
    /// <param name="_tab1"></param>
    /// <param name="_tab2"></param>
    /// <returns></returns>
    static bool CompareTableau(char[] _tab1, char[] _tab2)
    {
        Boolean isEqual;
        
        isEqual = _tab1.SequenceEqual(_tab2);

        if (isEqual)
        {
            Console.WriteLine("Les tableaux sont egaux.");
        }
        else
        {
            Console.WriteLine("Les tableaux ne sont pas egaux.");
        }
        return isEqual;
    }
}