using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo1_Expression
{
    internal class Addition
    {
        public double Add<T>(T x, T y)
        {
            dynamic a = x;
            dynamic b = y;
            return a + b;
        }
    }
}
