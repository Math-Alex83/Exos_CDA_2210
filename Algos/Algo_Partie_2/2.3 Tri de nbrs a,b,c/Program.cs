// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Elle est où la bierre ?!");


        //Lire 3 nombres réel double précision a, b et c. Les écrire dans l'ordre croissant.

        List<double> numbers = new List<double>();
        string saisie;
        //Nombre max de saisie utilisateur
        int nbMax = 3;

        for (int i = 0; i<nbMax;i++)
        {
            ReccuperationDeSaisie("Entrer un " + (i+1) +"e nombres:");
        }

        // methode pour tri de tableau
        numbers.Sort();
       // numbers.Reverse();
        Console.Write("Le tableau trié dans l'ordre croissant\n");
        foreach (double number in numbers)
        {
            Console.Write(number + " ");
        }

        /// <summary>
        /// Sert a recuperer la saisie de l'utilisateur
        /// </summary>
        /// <param name="texte">Remplace "entrer un nombre" par le texte envoyé en paramettre</param>
        void ReccuperationDeSaisie(string texte)
        {
            string userInput;

            Console.Write(texte);
            userInput = Console.ReadLine();
            numbers.Add(Convert.ToDouble(userInput));
        }
    }
}

