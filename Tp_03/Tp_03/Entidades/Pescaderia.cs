using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pescaderia
    {
        public List<Producto> productos;

        public Pescaderia()
        {
            this.productos = new List<Producto>();
            hardcode();
        }

        private void hardcode()
        {
            Comida rabas = new Comida(1, 1341, "Rabas", 550);
            Comida salmon = new Comida(2, 9482, "Salmon", 650);
            Comida trucha = new Comida(3, 569, "trucha", 887);
            Bebida coca = new Bebida(4, 105, "Coca", 330, tipo.gaseosa, 55);
            Bebida vino = new Bebida(5, 550, "Vino", 750, tipo.vino, 6);
            Comida truchas = new Comida(3, 569, "truchas", 657);
            this.Agregar(rabas, rabas.cantidad);
            this.Agregar(rabas, 233);
            this.Agregar(salmon, salmon.cantidad);
            this.Agregar(trucha, trucha.cantidad);
            this.Agregar(trucha, 233);
            this.Agregar(coca, coca.cantidad);
            this.Agregar(vino, vino.cantidad);
            this.Agregar(vino, 3);
            this.Agregar(truchas, 241);
            this.Agregar(truchas, 241);

        }

        public Producto BuscarProductoPorId(int id)
        {
            foreach (Producto item in this.productos)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        public bool Agregar(Producto pr, float cantidad)
        {
            bool ret = false;
            if (this is not null && pr is not null)
            {
                if (this != pr)
                {
                    this.productos.Add(pr);
                    pr.cantidad = cantidad;
                }
                else
                {
                    pr.cantidad += cantidad;
                }
                ret = true;
            }
            return ret;
        }

        public static bool operator ==(Pescaderia p, Producto pr)
        {
            bool ret = false; ;
            if (p is not null && pr is not null)
            {
                foreach (Producto producto in p.productos)
                {
                    if (pr == producto)
                    {
                        ret = true;
                    }
                }
            }
            return ret;
        }
        public static bool operator !=(Pescaderia p, Producto pr)
        {
            return !(p == pr);
        }




    }
}
