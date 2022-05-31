using System;
using System.Collections.Generic;
using System.Linq;
using Entidades.Exceptions;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vinoteca
    {
        protected string nombre;
        public Listado<Cliente> clientes;
        public Listado<CajaDeVino> cajas;
        public string Nombre { get => this.nombre; set => nombre = value; }
        public Vinoteca(string nombre)
        {
            this.nombre = nombre;
            this.clientes = new Listado<Cliente>();
            this.cajas = new Listado<CajaDeVino>();
        }

        public Cliente buscarCliente(string nombre)
        {
            foreach (Cliente item in clientes.lista)
            {
                if (item.NombreCompleto.ToLower() == nombre.ToLower())
                {
                    return item;
                }
            }
            throw new NoExisteException("No existe el cliente con ese dni!");
        }
        public bool existeCliente(int dni)
        {
            bool retorno = false;
            foreach (Cliente item in this.clientes.lista)
            {

                if (item.Dni == dni)
                {
                    retorno = true;
                    break;
                }

            }

            return retorno;

        }
        public Cliente buscarCliente(int dni)
        {
            foreach (Cliente item in clientes.lista)
            {
                if (item.Dni == dni)
                {
                    return item;
                }
            }
            throw new NoExisteException("No existe el cliente con ese dni!");

        }


    }
}
