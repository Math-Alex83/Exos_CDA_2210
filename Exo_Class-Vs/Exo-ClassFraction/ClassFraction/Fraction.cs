namespace ClassFraction
{
    public class Fraction
    {
        private int numerateur;
        private int denominateur;

        public int Denominateur { get => denominateur; }
        //set => denominateur = value; }
        public int Numerateur { get => numerateur; }
        //set => numerateur = value; }

        /// <summary>
        /// Constructeur avec paramètres.
        /// </summary>
        /// <param name="_numerateur"></param>
        /// <param name="_denominateur"></param>
        public Fraction(int _numerateur, int _denominateur)
        {
            this.numerateur = _numerateur;
            this.denominateur = _denominateur;
            
        }

        /// <summary>
        /// Constructeur par défault.
        /// </summary>
        public Fraction() : this(0, 1) { }

        /// <summary>
        /// Contructeur avec numérateur en paramètre.
        /// </summary>
        /// <param name="_numerateur"></param>
        public Fraction(int _numerateur)
        {
            numerateur = _numerateur;
            denominateur = 1;
        }

        /// <summary>
        /// Constructeur par recopie.
        /// </summary>
        /// <param name="_fraction"></param>
        public Fraction(Fraction _fraction) : 
            this(_fraction.numerateur, _fraction.denominateur) 
         { }
        
        /// <summary>
        /// Affichage 
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return string.Format(base.ToString() + " {0} / {1}", Numerateur, Denominateur);
        }

        // numérateur & dénominateur (int) resultat (double)! 

        // 1) « 0 » pour la fraction 0/1.

        public string NumerateurNull(int _numerateur)
        {
            if (_numerateur==0)
            {
                return string.Format(base.ToString() + " {0} ", Numerateur);
            }
            else
            {
                return string.Format(base.ToString() + " {0} / {1}", Numerateur, Denominateur);

            }
        }
    }
}