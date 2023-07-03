namespace classLepidoptere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lepidoptere monLepi = new Lepidoptere();

            //stade Oeuf
            Console.WriteLine(monLepi.SeDeplacer());
            Console.WriteLine(monLepi);
            monLepi.SeMetamorphoser();

            // stade chenille
            Console.WriteLine(monLepi.SeDeplacer());
            Console.WriteLine(monLepi);
            monLepi.SeMetamorphoser();

            // stade chrysalide
            Console.WriteLine(monLepi.SeDeplacer());
            Console.WriteLine(monLepi);
            monLepi.SeMetamorphoser();

            //stade papillon
            Console.WriteLine(monLepi.SeDeplacer());
            Console.WriteLine(monLepi);
            monLepi.SeMetamorphoser();

            // stade tjrs papillon
            Console.WriteLine(monLepi.SeDeplacer());
            Console.WriteLine(monLepi);
        }
    }
}