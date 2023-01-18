using ClassLibraryExoPoint;
using System.Drawing;

namespace ConsolApp_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            double _XAbscisse;
            double _YOrdonnee;


            //ClassPoint point = new ClassPoint();        // ok

            //Console.WriteLine("Veuillez saisir une valeur pour la position de l'Abscisse (x) svp.");
            //_XAbscisse = Convert.ToDouble(Console.ReadLine());
            
            //Console.WriteLine("Veuillez saisir une valeur pour la position de l'Ordonnée (y) svp.");
            //_YOrdonnee = Convert.ToDouble(Console.ReadLine());
            ClassPoint point = new ClassPoint(5, -8); // ok
            Console.WriteLine(point.ToString());
            //point.DeplacerPoint(-6, 3); // ok
            // point= point.SymetrieOrdonnee(); // ok
            // point = point.SymetrieOrigine();  // ok
            point.Permuter();  // ok
            Console.WriteLine(point.ToString()); // ok


            //point.SymetrieOrdonnee();
            //Console.WriteLine(point.ToString());
            

        }

    }
}