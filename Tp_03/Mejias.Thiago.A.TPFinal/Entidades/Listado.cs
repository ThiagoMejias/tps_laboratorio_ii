using System;
using System.Collections.Generic;
using Entidades.Exceptions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Listado<T>
    {
        public List<T> lista;

        public Listado()
        {
            this.lista = new List<T>();
        }

        public int Cantidad { get { return lista.Count(); } }

        public bool add(T obj)
        {
            bool retorno = false;
            if (obj is not null)
            {
                if (!EstaEnLaLista(this.lista, obj))
                {
                    this.lista.Add(obj);
                    retorno = true;
                }
                else
                {
                    throw new EstaOnoEnlalista("Ya se encuentra en la lista!");
                }

            }
            return retorno;
        }
        public bool Remove(T obj)
        {
            bool retorno = false;
            if (obj is not null)
            {
                if (this.EstaEnLaLista(this.lista, obj))
                {
                    this.lista.Remove(obj);
                    return true;
                }
                else
                {
                    throw new EstaOnoEnlalista("No se encuentra en la lista");

                }
            }
            return retorno;

        }
        public bool EstaEnLaLista(List<T> l, T obj)
        {
            if (l is not null && obj is not null)
            {
                foreach (T item in l)
                {
                    if (item.Equals(obj))
                    {
                        return true;
                    }
                }

            }
            return false;
        }

        public string Listar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("");
            foreach (T item in this.lista)
            {

                sb.Append(item.ToString());
            }
            return sb.ToString();
        }


    }
}
