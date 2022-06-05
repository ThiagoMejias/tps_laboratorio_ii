using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Exceptions
{
    public class EstaVacioException : Exception
    {
        public EstaVacioException()
        {
        }

        public EstaVacioException(string message) : base(message)
        {
        }

        public EstaVacioException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EstaVacioException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
