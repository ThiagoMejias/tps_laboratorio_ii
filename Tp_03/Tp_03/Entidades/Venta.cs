using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public class Venta
    {

        public Stock<Producto> productos;
        float total;

        public Venta()
        {
            this.productos = new Stock<Producto>();
        }







    }

}
