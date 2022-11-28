using System.Drawing;
using System.Globalization;
internal class Program
{
    /*
     *VARIABLES
     *
     *  list<string> grocery
     *  list<float> prices
     *  string userInput
     *  string [] splitUserInput
     *  float tempPrice
     *  
     *  FAIRE
     *      Ecrire "Veuillez saisir un nom de légume suivit de son prix au kg \n
     *      le tout séparé par un espace (ex:"carottes 2.99" )"
     *      Ecrire "Lorsque vous avez fini, vous pouvez taper "go" 
     *      pour afficher la liste et connaître le moins cher."
     *      
     *      Lire userInput
     *      userInput <-- userInput.ToLowerCaser()
     *      SI (userInput == "go")
     *          splitUserInput <-- userInput.split(" ")
     *              SI (splitUser.Length==2) 
     *                  ALORS
     *                      ESSAYER
     *                          tempPrice <-- Convertir(splitUser[1]
     *                          grocery [] <-- splitUser[0]
     *                          prices[] <-- prixTemporaire
     *                      ATTRAPER    
     *                          Ecrire"La saisie du prix de ",userInput[0]," est incorrect." 
     *          
     *                  SINON
     *                      Ecrire "saisie incorrecte, veuillez saisir deux valeurs séparées par un espace"
     *              FIN SI
     *      FIN SI   
     *  TANT QUE (userInput != "go")
     *  
     *  TRAITEMENT
     *      
     */




    private static void Main(string[] args)
    {
        Console.WriteLine("Hello,les Légumes!");

        List<string> grocery = new List<string>();
        List<float> prices = new List<float>();
        string userInput;
        string[] splitUserInput;
        float tempPrice;
        Console.WriteLine("Veuillez saisir un nom de légume suivit de son prix au kg le tout séparé par un espace(ex: carottes 2.99)");
        Console.WriteLine("Lorsque vous avez fini, vous pouvez taper go pour afficher la liste et connaître le moins cher.");

        userInput = Console.ReadLine();
        userInput = userInput.ToLower();

        if (userInput != "go")
        {
            splitUserInput = userInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);
          /*tempPrice < --Convertir(splitUser[1]
            grocery[] < --splitUser[0]
            prices[] < --prixTemporaire*/

            if (splitUserInput.Length == 2)
            {
                try
                {   // System.Globalization.CultureInfo.InvariantCulture = accepter point et virgule pour les nbrs décimaux.
                    tempPrice = Math.Abs(float.Parse(
                    splitUserInput[1],
                    NumberStyles.Any,
                    CultureInfo.InvariantCulture));

                    grocery.Add(splitUserInput[0]);

                    prices.Add(tempPrice);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Le prix de "+ splitUserInput[0] + " est incorrect.");
                    Console.WriteLine(ex.Message);

                }
            }
            else
            {
                Console.WriteLine("Saisie incorrecte, veuillez entrer deux valeurs séparées par un espace");

            }
        }
        while (userInput != "go"); // ou While (!userInput.Equals("go"));

        Affichage(grocery,prices);



    } // Fin Main
    /// <summary>
    /// Affichage des Listes _grocery and _price
    /// </summary>
    /// <param name="_grocery"></param>
    /// <param name="_prices"></param>
    static void Affichage(List<string> _grocery, List<float> _prices)
    {
        if (_grocery.Count != _prices.Count)
        {
            return;
        }
        for(int i = 0; i< _grocery.Count; i++)
        {
            Console.WriteLine(_grocery[i] + " coûte " + _prices[i] + "Euro(s)");
        }
    }


} // Fin Classe