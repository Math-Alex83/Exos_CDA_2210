using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo1_Expression
{
    public class Calculer
    {
        public double Additionner(List<double> numbers)
        {
            double sum = 0;
            foreach (double number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public double Soustraire(List<double> numbers)
        {
            double difference = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                difference -= numbers[i];
            }
            return difference;
        }
    }
}
