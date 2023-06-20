// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

try
{
    string saisie;
    double nbr1;
    double nbr2; 

    Console.WriteLine("Donner nbr1\n");
    saisie = Console.ReadLine();
    nbr1 = Convert.ToDouble(saisie);

    Console.WriteLine("Donner nbr2");
    saisie = Console.ReadLine();
    nbr2 = Convert.ToDouble(saisie);

    //double moyenne = ((nbr1 + nbr2) / 2);

    //Console.Write("\n"+moyenne);
    Console.Write(((nbr1 + nbr2) / 2)); //Les 2 fonctionnent.
   
}
catch
{
    Console.WriteLine("Erreur de saisie ! ");
    Console.ReadLine();
}