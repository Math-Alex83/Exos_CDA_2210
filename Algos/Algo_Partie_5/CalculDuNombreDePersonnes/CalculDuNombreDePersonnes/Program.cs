using System.Collections.Generic;

internal class Program
{
    private const int AGE = 20;
    private static void Main(string[] args)
    {
        List<int> valeur = new List<int>();
        string userInput;
        int compteur = 0;
        string userInput2;
        string quitte = "q";
        
        
        Console.WriteLine("nous allons comptabiliser le nombres de personne non jeune, veuillez saisir au moins 20 valeurs.");

        do
        {
            Console.WriteLine("Entrer l'age de la personne ou taper 'q' pour lancer le programme puis faire ok.");

            userInput = Console.ReadLine();

            if (!userInput.Equals(quitte))
            {

                userInput2 = userInput;

                // try catch :
                //Pour controle de saisie, si il leve une exception,
                //il affiche le message d'erreur et redemande sans faire d'action ni bloquer le prog.

                try
                {
                    valeur.Add(int.Parse(userInput2));
                    compteur++;
                    Console.WriteLine("Vous avez entré l'age de " + compteur + " personne(s).");
                } catch
                {
                    Console.WriteLine("erreur de saisie");
                }               
            }
            else
            {
                int[] tab = valeur.ToArray();
                foreach (int i in tab)
                {
                    Console.Write(i);
                }
                // faire foreach ( Si (valeur<age) Alors Remove cellule.)(mieux à faire)

                // Methode qui cherche toutes les valeurs dans la Liste inferieur à l'age --> (private const int AGE = 20;)
                AffichageTableauVieux(valeur);
            }
        }
        while (!userInput.Equals(quitte));
    }
    static int[] StringToArray(string valeurs)
    {
        string[] arrayString = valeurs.Split(" ");
        int[] arrayToReturn = new int[arrayString.Length];

        for (int i = 0; i < arrayString.Length; i++)
        {
            arrayToReturn[i] = int.Parse(arrayString[i]);
        }

        return arrayToReturn;
    }

    static void AffichageTableau(int[] tableauAffiche)
    {
        foreach (int i in tableauAffiche)
        {
            Console.WriteLine(i);
        }

    }

    static void AffichageTableauVieux(List<int> tableauAffiche)
    {
        int[] listeParcourue = tableauAffiche.FindAll(x => x > AGE).ToArray();
       
        foreach (int i in listeParcourue )
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("Il y a : "+listeParcourue.Length+" personnes de plus de "+ AGE);
    }
}