using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        protected int id;
        protected float precio;
        public string descripcion;
        public float cantidad;

        public float Precio { get => precio; }
        public int Id { get => id; }

        protected Producto(int id, float precio, string descripcion, float cantidad)
        {
            this.id = id;
            this.precio = precio;
            this.descripcion = descripcion;
            this.cantidad = cantidad;
        }
        private string Mostrar()
        {
            return $"Producto: {this.descripcion} \n"
                + $"Precio: {this.precio} \n" +
                $"Id: {this.id}\n";
        }
        public static bool operator ==(Producto p1, Producto p2)
        {
            return p1 is not null && p2 is not null && p1.id == p2.id;
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Mostrar());
            return sb.ToString();
        }
    }
}
