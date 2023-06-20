using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleException.Exceptions
{
    internal class DivideByZeroException : Exception
    {
        public DivideByZeroException(string? message) : base(message)
        {

        }
    }
}
