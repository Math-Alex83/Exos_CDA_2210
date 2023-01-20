using ClassFraction;
namespace ConsoleFraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // « 12/7 » pour la fraction 12/7
            Fraction f1 = new Fraction(12, 7);
            Console.WriteLine(f1.ToString());       // OK

            // « 0 » pour la fraction 0/1
            Fraction f2 = new Fraction();
            Console.WriteLine(f2.ToString());       // 

            // « 9 » pour la fraction 9/1
            Fraction f3 = new Fraction(9);
            Console.WriteLine(f3.ToString());       //

        }
    }
}