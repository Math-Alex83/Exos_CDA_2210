using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPersonneDance
{
    /// <summary>
    /// Class Personne
    /// </summary>
    public abstract class Personne
    {
        private int age;
        /// <summary>
        /// Methode DanceDisco pour danser comme Travolta
        /// </summary>
        public void DancerDisco()
        {
            Console.WriteLine("Je suis john Travolta, wouhou!");
        }
        /// <summary>
        /// Methode Dance de Salon en abstract pas de code
        /// </summary>
        public abstract void DanserSalon();
       /// <summary>
       /// 
       /// </summary>
        public virtual void Marcher()
        {
            Console.WriteLine("");
        }
        
    }
    public class Homme : Personne
    {
        public void Mener()
        {
            Console.WriteLine("");
        }
        public override void DanserSalon()
        {
            Console.WriteLine("");
        }
    }
    public class Homme_Vieux
    {
        public virtual void Marcher()
        {
            Console.WriteLine("");
        }

    }
    public class Femme : Personne
    {
        public void Suivre()
        {
            Console.WriteLine("");
        }
        public override void DanserSalon()
        {
            Console.WriteLine("");
        }
    }
}
