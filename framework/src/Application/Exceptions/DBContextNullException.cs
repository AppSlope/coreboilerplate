using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBoilerplate.Application.Exceptions
{
    public class DBContextNullException : Exception
    {
        public DBContextNullException(string? message) : base(message)
        {
        }
    }
}
