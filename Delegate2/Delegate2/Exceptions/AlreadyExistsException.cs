using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate2.Exceptions
{
    internal class AlreadyExistsException:Exception
    {
        public AlreadyExistsException(string message):base(message)
        {
            Console.WriteLine();

        }
    }
}
