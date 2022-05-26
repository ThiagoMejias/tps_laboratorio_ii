using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comida : Producto
    {

        public Comida(int id, float precio, string descripcion, float cantidad) : base(id, precio, descripcion, cantidad)
        {

        }



    }
}
