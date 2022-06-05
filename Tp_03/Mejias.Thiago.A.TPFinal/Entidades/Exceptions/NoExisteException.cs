using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Exceptions
{
    public class NoExisteException : Exception
    {
        public NoExisteException()
        {
        }

        public NoExisteException(string message) : base(message)
        {
        }

        public NoExisteException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoExisteException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
