using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Exceptions
{
    public class EstaOnoEnlalista : Exception
    {
        public EstaOnoEnlalista()
        {
        }

        public EstaOnoEnlalista(string message) : base(message)
        {
        }

        public EstaOnoEnlalista(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EstaOnoEnlalista(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
