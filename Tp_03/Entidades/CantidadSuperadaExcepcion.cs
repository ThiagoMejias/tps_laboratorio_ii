using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepcion
{
    public class CantidadSuperadaExcepcion : Exception
    {
        public CantidadSuperadaExcepcion()
        {
        }

        public CantidadSuperadaExcepcion(string message) : base(message)
        {
        }

        public CantidadSuperadaExcepcion(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CantidadSuperadaExcepcion(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
