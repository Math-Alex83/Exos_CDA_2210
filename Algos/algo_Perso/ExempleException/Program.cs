namespace ExempleException

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            int[] testException = new int [5];
            Fractions f = null;
            try
            {
                f = new Fractions(72);
            }
            catch(DivideByZeroException divideE)
            {
                Console.WriteLine("La création de la fractions a échoué : " + divideE.Message);
            }
            
            finally
            {
                try
                {
                    testException[6] += 1;
                }
                catch (IndexOutOfRangeException ie)
                {
                    Console.WriteLine("L'index du tableau n'existe pas : " + ie.Message);
                }
                Console.WriteLine("Coucou");
            }
            Console.WriteLine("UwU");
        }
    }
}