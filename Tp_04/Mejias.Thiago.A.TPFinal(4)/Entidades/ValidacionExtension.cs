using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ValidacionExtension
    {
        /// <summary>
        /// Verifica que sea menor.
        /// </summary>
        /// <param name="fecha"></param>
        /// <returns>Retorna true si es menor o false si no.</returns>
        public static bool EsMenor(this DateTime fecha)
        {
            if (fecha.AddYears(18) > DateTime.Today)
            {
                return true;
            }
            return false;
        }


    }
}
