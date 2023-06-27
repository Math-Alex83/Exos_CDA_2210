using ExercicesNombreCommun;

internal class App
{
   
    private static void Main(string[] args)
    {
        int userInput;
        userInput = Program.ReccupDeSaisie();

        List<int> diviseurs = Program.TrouverLesDiviseurs(userInput);
        if (diviseurs.Count == 0)
        {
            Console.WriteLine("Premier !");
        }
        else
        {
            Console.WriteLine("Pas premier !");
        }

        /*EQUIVALENT 
        ceci est un ternaire...
        */
       // Console.WriteLine(Program.TrouverLesDiviseurs(Program.ReccupDeSaisie()).Count == 0 ? "Premier" : "Pas premier");
    }
}