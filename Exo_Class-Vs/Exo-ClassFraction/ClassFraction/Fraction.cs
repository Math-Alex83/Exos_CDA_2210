namespace ClassFraction
{
    public class Fraction
    {
        public int numerateur;
        public int denominateur;

        public Fraction(int _numerateur, int _denominateur)
        {
            numerateur = _numerateur;
            denominateur = _denominateur;
            
        }

        public Fraction()
        {
            throw new System.NotImplementedException();
        }

        public Fraction(int _numerateur)
        {
            throw new System.NotImplementedException();
        }

        public Fraction(Fraction _fraction)
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return string.Format(base.ToString() + " {0} / {1}", numerateur, denominateur);
        }
    }
}