namespace ExercicesNombreCommun
{
    /* Recherche des diviseurs d'un nombre
            * 
            * Pour trouver tous les diviseurs d'un nbr,
            * on peuarcourt tous les nbrs inferieurs et on teste
            * si le reste = zero.
            * 
            * DECLARATION DES VARIABLES
            *  entier input
            *  entier inputConvert
            *  entier i
            *  liste entier[] diviseurs
            *  
            * TRAITEMENT
            * ecrire ("Programme de listage des diviseurs d'un nbr entier")
            * ecrire ("Veuillez saisir un nombre entier")
            * Faire
            *     lire (input)
            *     
            * Tant que (convertirEnEntier(input) imposssible
            * 
            * inputConvert=converrtirEnEntier(input)
            * Pour (i de 1 à inputConvertir//2, i++)
            *      Si inputConvert%i==0:
            *          ajouter i à diviseurs
            * AFFICHAGE
            * ecrire("Les diviseurs de input sont "i(diviseurs)")
            */
    public class Program
    {
        static void Main(string[] args)
        {
            int inputConvert;
            List<int> diviseurs = new List<int>();
            Console.WriteLine("Recherche des diviseurs d'un nbr");

            inputConvert = ReccupDeSaisie();

            diviseurs = TrouverLesDiviseurs(inputConvert);

            foreach (int i in diviseurs)
            {
                Console.WriteLine($"Les diviseurs sont : {i}");
            }
        }
        /// <summary>
        /// Retourne les diviseurs d'un nbr donné.
        /// </summary>
        /// <param TrouverLesDiviseurs="_input"></param>
        /// <returns></returns>
        public static List<int> TrouverLesDiviseurs(int _input)
        {
            int limit = _input / 2;
            _input = Math.Abs(_input);

            List<int> diviseurs = new List<int>();
            for (int i = 2; i <= limit; i++)
            {
                if (_input % i == 0)
                {
                    diviseurs.Add(i);
                }
            }
            return diviseurs;
        }
        /// <summary>
        /// Retourne une saisie utilisateur string convertie en int.
        /// </summary>
        /// <returns>la saisie utilisateur sous forme d'entier (int)</returns>
        public static int ReccupDeSaisie()
        {
            string _input;
            int _inputConvert;
            do
            {
                Console.WriteLine("Veuillez saisir un nbr entier svp");
                _input = Console.ReadLine();
            }
            while (!int.TryParse(_input, out _inputConvert));

            return _inputConvert;
        }
    }
}