// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Où est mon Mojito ! ");



float totalDeCarteAuDepart = 0;
float nbrCard = 2;
float resteCartes;
float nbrEtage = 0;
float comptCard = 0;

Console.WriteLine("Ce programme détermine le nombre détage que vous pourrez faire !! \n" +
    "Merci d'indiquer le nombre de cartes que vous possèdez.");

totalDeCarteAuDepart = float.Parse(Console.ReadLine());

if (totalDeCarteAuDepart == 2)
{

    Console.WriteLine("Vous pouvez faire 1 tante dans le jardin.");

}
else if (totalDeCarteAuDepart >= 2)
{
    resteCartes = totalDeCarteAuDepart;

    if (resteCartes > 0)
    {
        for (nbrCard = 2; nbrCard <= resteCartes + 3; nbrCard += 3)
        { 
            comptCard += nbrCard;
            resteCartes = (totalDeCarteAuDepart - comptCard);
            nbrEtage++;
        }

        Console.WriteLine("Votre château de carte peut faire " + nbrEtage + " étages.\n" + "il vous reste " + resteCartes);

    }
    /*
      do
    {
        resteCartes = totalDeCarteAuDepart;

        Console.WriteLine("Votre château de carte peut faire " + nbrEtage + nbrEtage  " étages.\n" + "il vous reste " + resteCartes);

    } while (resteCartes > 0); */

}
else
{
    Console.WriteLine("Vous faites souvent un château de carte avec moins de 2 cartes ?? aller oust!! ");
}