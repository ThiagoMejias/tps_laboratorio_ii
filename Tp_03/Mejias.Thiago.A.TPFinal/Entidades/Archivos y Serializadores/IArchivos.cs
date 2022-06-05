using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Archivos
{
    public interface IArchivos<T>
    {
        T Leer(string nombreArchivo);
        void Escribir(T elemento, string nombreArchivo);
    }
}
