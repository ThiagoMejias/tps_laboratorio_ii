using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Exceptions
{
    public class NumeroInvalidoException : Exception
    {
        public NumeroInvalidoException()
        {
        }

        public NumeroInvalidoException(string message) : base(message)
        {
        }

        public NumeroInvalidoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NumeroInvalidoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
