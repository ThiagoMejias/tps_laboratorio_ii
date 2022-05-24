using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum tipo
    {
        vino, agua, cerveza, gaseosa
    }

    public class Bebida : Producto
    {

        protected int capacidad;
        protected tipo tipo;

        public Bebida(int id, float precio, string descripcion, int capacidad, tipo tipo, float cantidad)
            : base(id, precio, descripcion, cantidad)
        {
            this.capacidad = capacidad;
            this.tipo = tipo;

        }
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"Capacidad:{this.capacidad}");
            sb.AppendLine($"Tipo:{this.tipo}");
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

    }
}
