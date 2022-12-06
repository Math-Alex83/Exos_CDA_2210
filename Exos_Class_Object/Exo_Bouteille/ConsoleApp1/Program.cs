namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Hello, World!");

             Bouteille bouteilleDeChampagne;
            // Bouteille bouteilleDEau;
             Bouteille bouteilleDeChampagneCopie;


             bouteilleDeChampagne = new Bouteille(150,150,false);
             bouteilleDeChampagne = new Bouteille(bouteilleDeChampagne);
             bouteilleDeChampagneCopie = new Bouteille(bouteilleDeChampagne);


             bool aReussiAOuvrir = bouteilleDeChampagne.Ouvrir();

             bool aReussiAFermer = bouteilleDeChampagne.Fermer();

             bool aReussiAVider = bouteilleDeChampagne.Vider(100.00F);

             bool aREussiAViderTout = bouteilleDeChampagne.Vider();

             bool aReussiARemplir = bouteilleDeChampagne.Remplir(50.00F);

            // bool aReussiARemplirTout = bouteilleDeChampagne.RemplirTout();*/

            Bouteille bt = new Bouteille(150,150,false);


            bool rt = bt.Fermer(); // false
            bt.Vider(20);
            bool rt2 = bt.Vider(160); // false
            bool rt3 = bt.RemplirTout(); // false
            bool rt4 = bt.Ouvrir();
            bool rt5 = bt.Ouvrir();


        }
    }
}