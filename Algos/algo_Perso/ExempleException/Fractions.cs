using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleException
{
    internal class Fractions
    {
        int numerateur;
        int denominateur;
        /// <summary>
        /// Constructeur qui prend uniquement uniquement un numérateur
        /// </summary>
        /// <param name="_numerateur">Le numérateur de la fraction</param>
        /// <remarks><see cref="Fractions(int,int)"/></remarks>
        public Fractions(int _numerateur) : this(_numerateur, 1)
        {
            
        }
        public Fractions(int _numerateur, int _denominateur)
        {
            if(_denominateur == 0)
            {
                throw new DivideByZeroException("Le denominateur n'est pas valide, il ne doit pas être égale à zero");
            }
            this.numerateur = _numerateur;
            this.denominateur = _denominateur;
        }
    }
}
