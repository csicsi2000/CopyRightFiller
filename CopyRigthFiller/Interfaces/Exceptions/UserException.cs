using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Exceptions
{
    public class UserException : Exception
    {
        public UserException()
        {
        }

        public UserException(string message)
            : base(message)
        {
        }

        public UserException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
