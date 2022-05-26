using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Stock<T> where T : Producto
    {
        List<T> productos;
        public Stock()
        {
            this.productos = new List<T>();
        }

        public List<T> agregarProducto(T obj, float cantidad)
        {

            if (obj is not null)
            {
                obj.cantidad = cantidad;
                this.productos.Add(obj);
            }
            return this.productos;
        }

        public string MostrarProductos()
        {
            StringBuilder sb = new StringBuilder();

            foreach (T item in this.productos)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }


    }
}
