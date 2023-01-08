using LibrairieCompte;

namespace ConsoleAppCompte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            CompteBancaire monCompte;
            CompteBancaire autreCompte;
            
            monCompte = new CompteBancaire("FR_lecompteAmoi","Akn","math",938.38f,-1500);
            autreCompte = new CompteBancaire("FR-leAlui", "Mr", "truc", 500.01f, -1500);

            bool resultat = monCompte.Superieur(autreCompte);
            bool resultat2 = monCompte.Crediter(200);
            bool resultat3 = monCompte.Debiter(2500);
            bool resultat4 = monCompte.Transferer(autreCompte, 500);
            Console.WriteLine(monCompte);
        }
    }
}