using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryExoPoint
{
    public class ClassPoint
    {
        internal double x_Abscisse;
        internal double y_Ordonnee;


        // 1) Se construire soit sans information ( point 0,0), ou avec une valeur pour chaque coordonnées.

        /// <summary>
        /// Constructeur à l'origine soit point en position (0 ,0).
        /// </summary>
        public ClassPoint() : this(0, 0)
        {
            //x_Abscisse = 0;
            //y_Ordonnee = 0;
        }

        /// <summary>
        /// Constructeur par defaut avec saisie de valeurs
        /// </summary>
        /// <param name="_XAbscisse"></param>
        /// <param name="_YOrdonnee"></param>
        public ClassPoint(double _XAbscisse, double _YOrdonnee)
        {
            this.x_Abscisse = _XAbscisse;
            this.y_Ordonnee = _YOrdonnee;
        }

        // Constructeur par recopie.

        /// <summary>
        /// Constructeur par recopie d'un constructeur avec parametre.
        /// </summary>
        /// <param name="copiePoint"></param>
        public ClassPoint(ClassPoint copiePoint) : this(copiePoint.x_Abscisse,copiePoint.y_Ordonnee) { }
       

        // 2) Indiquer sa position ( abscisse et ordonnée ).​

        /// <summary>
        /// accesseur Abscisse 
        /// </summary>
        public double X_Abscisse
        {
            get => x_Abscisse;
            set
            {
            }
        }

        /// <summary>
        /// Accesseur Ordonnée
        /// </summary>
        public double Y_Ordonnee
        {
            get => y_Ordonnee;
            set
            {
            }
        }

        // 3) Se déplacer en modifiant abscisse et ordonnée.​

        /// <summary>
        /// Méthode pour déplacer un point.
        /// </summary>
        /// <param name="_Abscisse"></param>
        /// <param name="_Ordonnee"></param>
        public void DeplacerPoint(double _Abscisse, double _Ordonnee)
        {
            this.x_Abscisse = _Abscisse;
            this.y_Ordonnee = _Ordonnee;

        }

        // 4) Renvoyer une représentation textuelle en indiquant les valeurs de ses coordonnées.

        /// <summary>
        /// Affichage 
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            return String.Format(base.ToString() + " Abscisse : {0}, Ordonnée : {1}", X_Abscisse, Y_Ordonnee);
        }

        // 5) Construire un point symétrique par rapport à l'axe des ordonnées.​

        public ClassPoint SymetrieOrdonnee()
        {
            // return new ClassPoint(-x_Abscisse, y_Ordonnee);
            if (x_Abscisse>=0)
            {
                return new ClassPoint( -x_Abscisse,y_Ordonnee);
            }
            else
            {
                return  new ClassPoint(Math.Abs(x_Abscisse),y_Ordonnee);
            }
        }


        // 6) Construire un point symétrique par rapport à l'axe des abscisses.​

        public ClassPoint SymetrieAbscisse()
        {
            //return new ClassPoint(y_Ordonnee, -y_Ordonnee);
            if (y_Ordonnee >= 0)
            {
                return new ClassPoint(x_Abscisse, -y_Ordonnee);
            }
            else
            {
                return new ClassPoint(x_Abscisse, Math.Abs(y_Ordonnee));
            }
        }

        // 7) Construire un point symétrique par rapport à l'origine.​

        public ClassPoint SymetrieOrigine()
        {
            //x_Abscisse = -x_Abscisse;
            //y_Ordonnee = -y_Ordonnee;

            //return new ClassPoint(x_Abscisse, y_Ordonnee);

            return SymetrieAbscisse().SymetrieOrdonnee();
        }

        // 8) Permuter ses coordonnées ( symétrie par rapport à la bissectrice des axes Ox,Oy )​

        public void Permuter()
        {
            double temp;

            temp = x_Abscisse;
            x_Abscisse = y_Ordonnee;
            y_Ordonnee = temp;
        }


        // CA C'EST INTERDIT !!!!...........pour l'instant......^^
        /*
        public (string, double, double) AfficheValeur(double _XAbscisse, double _YOrdonnee)
        {
            // return "l'abscisse : "+ this.x_Abscisse+" et l'ordonnée : " + this.y_Ordonnee+ " soit : ";
            return ("Position en abscisse : {0}, Position en Ordonnée {1}", _XAbscisse, _YOrdonnee);
        }
        */
    }
}
