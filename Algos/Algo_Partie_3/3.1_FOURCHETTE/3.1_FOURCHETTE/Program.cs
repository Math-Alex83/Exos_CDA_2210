internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int userInput = 0;
        int highValue = 100;
        int lowValue = 0;
        int mysteryNumber;
        int numberOfTurns = 0;
        string replay = "y";
        do
        {
            Console.WriteLine("Welcome to the Forks game.\nYou will have to find the mystery number that is between 0 and 100 inclusive.\nGOOD GAME !");

            //CREATION DU NBR MYSTERE.
            Random rnd = new Random();
            mysteryNumber = rnd.Next(lowValue, highValue);
            Console.WriteLine(mysteryNumber);

            while (userInput != mysteryNumber)
            {
                do
                {
                    Console.WriteLine("Please enter a positive integer number between 0 and 100 included.");
                    userInput = int.Parse(Console.ReadLine());
                }
                while (!(userInput >= 0 && userInput <= 100));
                numberOfTurns++;

                Console.WriteLine(Comparaison());

            }
            Console.WriteLine("Voullez-vous rejouer ? yes/no ");
            replay = Console.ReadLine();

        }
        while (replay.Equals(replay, StringComparison.OrdinalIgnoreCase));

        //FONCTION
        string Comparaison()
        {
            string a="";
            if (userInput > mysteryNumber)
            {
                highValue = userInput;
                 a="Le nombre mystère est compris entre " + lowValue + " et " + highValue;
            }
            else if (userInput < mysteryNumber)
            {
                lowValue = userInput;
                a="Le nombre mystère est compris entre " + lowValue + " et " + highValue;
            }
            else if (userInput == mysteryNumber)
            {
                a="Bravo ! le nombre mystère est " + mysteryNumber + " Vous l'avez trouvé en " + numberOfTurns + " Tour(s)";
            }
            return a;
        }
    }
}
