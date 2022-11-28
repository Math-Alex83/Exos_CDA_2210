Console.WriteLine("J'ai trouvé du Mojito!");
// 1) exo 2.1 trier 3 valeur dans l'ordre croissant.
// 2) rajout perso, donner le choix à l'utilisateur entre coissant et décroissant.
double a;
double b;
double c;
string choice;
// ecrire " Veuillez saisir le premier nombre svp"
Console.WriteLine("Please enter the first number.");
// lire a
a = double.Parse(Console.ReadLine());

// ecrire " Veuillez saisir le 2ème nombre svp"
Console.WriteLine("Please enter the second number.");
// lire b
b = double.Parse(Console.ReadLine());

// ecrire "Veuillez saisir le 3ème nombre svp"
Console.WriteLine("Please, enter the third number.");
//lire c
c = double.Parse(Console.ReadLine());

Console.WriteLine("Do you want to sort in ascending or descending order?" +
    " \n write \"increasing\" or \"decreasing\" according to your choice.");
choice = Console.ReadLine();

if ((choice.Equals("croissant", StringComparison.OrdinalIgnoreCase))
 || (choice.Equals("increasing", StringComparison.OrdinalIgnoreCase)))
{

    //Si a<b et que b<c alors
    if (a < b && b < c)
    {
        // ecrire a<b<c
        Console.WriteLine("L'ordre croissant est:" + a + " < " + b + " < " + c);
    }
    // Si a<b et que b<c alors
    else if (a < c && c < b)
    {
        // ecrire a<c<b
        Console.WriteLine("L'ordre croissant est: " + a + " < " + c + " < " + b);
    }
    // Si b<a et que a<c alors
    else if (b < a && a < c)
    {
        // ecrire b<a<c
        Console.WriteLine("L'ordre croissant est: " + b + " < " + a + " < " + c);
    }
    // Si b<c et que c<a alors
    else if (b < c && c < a)
    {
        // ecrire b<c<a
        Console.WriteLine("L'ordre croissant est: " + b + " < " + c + " < " + a);
    }
    // Si c<a et que a<b alors
    else if (c < a && a < b)
    {
        // ecrire c<a<b
        Console.WriteLine("L'ordre croissant est: " + c + " < " + a + " < " + b);
    }
    // Si c<b et que b<a alors
    else if (c < b && b < a)
    {
        // ecrire c<b<a
        Console.WriteLine("L'ordre croissant est: " + c + " < " + b + " < " + a);
    }
}
else if ((choice.Equals("décroissant", StringComparison.OrdinalIgnoreCase))
 || (choice.Equals("decreasing", StringComparison.OrdinalIgnoreCase)))
{
    //Si a>b et que b>c alors
    if (a > b && b > c)
    {
        // ecrire a>b>c
        Console.WriteLine("L'ordre décroissant est:" + a + " > " + b + " > " + c);
    }
    // Si a>b et que b>c alors
    else if (a > c && c > b)
    {
        // ecrire a>c>b
        Console.WriteLine("L'ordre décroissant est: " + a + " > " + c + " > " + b);
    }
    // Si b>a et que a>c alors
    else if (b > a && a > c)
    {
        // ecrire b>a>c
        Console.WriteLine("L'ordre décroissant est: " + b + " > " + a + " > " + c);
    }
    // Si b>c et que c>a alors
    else if (b > c && c > a)
    {
        // ecrire b>c>a
        Console.WriteLine("L'ordre décroissant est: " + b + " > " + c + " > " + a);
    }
    // Si c>a et que a>b alors
    else if (c > a && a > b)
    {
        // ecrire c>a>b
        Console.WriteLine("L'ordre décroissant est: " + c + " > " + a + " > " + b);
    }
    // Si c>b et que b>a alors
    else if (c > b && b > a)
    {
        // ecrire c>b>a
        Console.WriteLine("L'ordre décroissant est: " + c + " > " + b + " > " + a);
    }
}
Console.WriteLine("\nLe Mojito est terminé, au-revoir! ^_^ ");