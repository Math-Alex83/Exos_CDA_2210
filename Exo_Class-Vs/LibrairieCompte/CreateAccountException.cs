using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrairieCompte
{
    public class CreateAccountException : Exception
    {
        public CreateAccountException(string? message) : base(message)
        {
        }
    }
}
