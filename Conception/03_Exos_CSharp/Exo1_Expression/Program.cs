using Exo1_Expression;
using static Exo1_Expression.Calculer;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Saisir un nombre à additionner");

        //double a = Convert.ToDouble(Console.ReadLine());
        //double b = Convert.ToDouble(Console.ReadLine());
        //Addition Obj = new Addition();
        //double somme = Obj.Add<double>(a, b);
        //Console.WriteLine(a+" + "+b+" = "+somme);

        var addition = new Calculer();

        List<double> numbers = new List<double> { 2, 5, 8 };
        double sum = addition.Additionner(numbers);
        Console.WriteLine(sum);

        List<double> numbers2 = new List<double> { 2, 5, 8 };
        double difference = addition.Soustraire(numbers2);
        Console.WriteLine(difference);
    }
}