using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2_BarnabeFaitSesCourses
{

    internal class Barnabe
    {
        public int sommeUserInput;
        public int sommeSuplementaire;
        public int nbrMagasin;
        public Barnabe()
        {
            sommeUserInput = 0;
            sommeSuplementaire = 1;
            nbrMagasin = 0;
            //
        }
        public void SaisieSomme()
        {
            Console.WriteLine("Indiquez la somme d'argent dont vous disposez.");
            sommeUserInput = int.Parse(Console.ReadLine());
        }

        public void barnabeShopping()
        {
            float sommFloat = (float)sommeUserInput;
            Console.WriteLine(sommeUserInput);
            do
            {
                sommFloat -= sommFloat / 2F + sommeSuplementaire;
                nbrMagasin++;
                Console.WriteLine(MathF.Round(sommFloat,2));
            }
            while (sommFloat / 2 > sommeSuplementaire);
            sommeUserInput = 0;
            Console.WriteLine(sommeUserInput);              
            nbrMagasin++;
            Console.WriteLine(nbrMagasin);
        }
    }

}
