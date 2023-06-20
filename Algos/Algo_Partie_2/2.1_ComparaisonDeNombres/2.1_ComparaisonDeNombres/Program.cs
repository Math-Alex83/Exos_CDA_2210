// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int userInput;
int ageMini=0;
int ageMax=18;
int immortel = 120;

Console.WriteLine("Nous allons vous dire si vous êtes majeur ou non.\nVeuillez entrer votre âge s'il vous plaît.");
userInput = int.Parse(Console.ReadLine());

if(userInput >= ageMax && userInput < immortel)
{
    Console.WriteLine("Vous êtes majeur.");
}
else if (userInput >= ageMini && userInput < ageMax)
{
    Console.WriteLine("Vous êtes mineur.");
}
else if(userInput > immortel)
{
    Console.WriteLine("WHAT !!!! Oo");
}
else
{
    Console.WriteLine("Vous n'êtes pas née!!");
}