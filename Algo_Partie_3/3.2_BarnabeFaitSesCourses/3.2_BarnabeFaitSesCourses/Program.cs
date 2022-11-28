using _3._2_BarnabeFaitSesCourses;
using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
internal class Program
{
    private static void Main(string[] args)
    {
        Barnabe barnabe = new Barnabe();
        Console.WriteLine(barnabe.sommeUserInput);
        barnabe.SaisieSomme();
        barnabe.barnabeShopping();
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}