using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnhNH.Utilities.Exceptions
{
    public class AnhNHException:Exception
    {
        public AnhNHException()
        {

        }
        public AnhNHException(string message) : base(message) { }
        public AnhNHException(string message, Exception inner):base(message, inner) { }
    }
}
