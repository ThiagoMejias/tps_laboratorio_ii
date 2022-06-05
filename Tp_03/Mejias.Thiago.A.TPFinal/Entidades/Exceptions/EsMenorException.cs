using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Exceptions
{
    public class EsMenorException : Exception
    {
        public EsMenorException()
        {
        }

        public EsMenorException(string message) : base(message)
        {
        }

        public EsMenorException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EsMenorException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
