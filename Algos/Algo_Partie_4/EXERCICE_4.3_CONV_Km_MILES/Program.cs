// See https://aka.ms/new-console-template for more information
Console.WriteLine("C'est parti mon kiki !!!");

/*
L'utilisateur saisit une valeur en kilomètres comprise entre 0.01 et 1 000 000. Si la valeur est hors limite, l'utilisateur est invité à 
saisir une nouvelle valeur. Si la valeur est égale à "q", le programme se termine et se ferme. 
Formule km vers mi : 1 miles = 1.609 kilomètres
Le programme affiche le résultat de la conversion sous forme de nombre réel double précision.
*/

/*
 * PSEUDO CODE *
 * 
string userInput;
double userInputConvert;
double miles;

Console.WriteLine("Convertissons des kilometres en Miles.");
Console.WriteLine("La valeur à convertir doit être comprise entre 0,01 km et 1 000 000 de kms.Quand vous voudrez sortir de l'application pressez la touche q");

do
{
    Console.WriteLine("Veuillez saisir une distance à convertir svp.");
    userInput = (Console.ReadLine());


   if (userInput.Equals("q"))
    {
        Console.WriteLine("Au revoir !!");
        Environment.Exit(0); //pour sortir du programme
    }
}
while (!double.TryParse(userInput,out userInputConvert) || userInputConvert < 0.01 || userInputConvert > 1000000);



       miles = userInputConvert / 1.609;



Console.WriteLine("La distance " + userInput + " km convertie en miles est de " + miles + " miles");
Console.ReadLine();*/



//v2 plusieurs conversions possibles
string userInput;
double userInputConvert = 0;
double miles;
string getOut = "q";



Console.WriteLine("Convertissons des kilometres en Miles.");
Console.WriteLine("La valeur à convertir doit être comprise entre 0,01 km et 1 000 000 de kms.Quand vous voudrez sortir de l'application pressez la touche q");




do
{
    Console.WriteLine("Veuillez saisir une distance à convertir svp.");
    userInput = (Console.ReadLine());



    if (double.TryParse(userInput, out userInputConvert) && userInputConvert >= 0.01 && userInputConvert < 1000000)
    {
        miles = userInputConvert / 1.609;
        Console.WriteLine("La distance " + userInput + " km convertie en miles est de " + miles + " miles");
    }



}
while (!userInput.Equals(getOut));
Console.WriteLine("Au revoir !!");
Environment.Exit(0); //pour sortir du programme



Console.ReadLine();