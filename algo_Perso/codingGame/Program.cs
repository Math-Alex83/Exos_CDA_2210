using System.Collections.Specialized;

internal class Program
{
    private static void Main(string[] args)
    {
        int size;

        size = Convert.ToInt32(Console.ReadLine());

        uint[] a = new uint[size / 16];
        uint[] b = new uint[size / 16];

        //Console.WriteLine("{0:X8}", 86);

        for (int i = 0; i < size / 16; i++)
        {
            a[i] = Convert.ToUInt32(Console.ReadLine(), 16);
        }

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                b[(i + j) / 32] ^= ((a[i / 32] >> (i % 32)) & (a[j / 32 + size / 32] >> (j % 32)) & 1) << ((i + j) % 32);
            }
        }

        for (int i = 0; i < size / 16; i++)
        {
            if (i > 0)
            {
                Console.Write(' ');
            }
            Console.Write("{0:X8}", b[i]);
        }

        Console.WriteLine();
    }
}