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
        protected int contadorTinto;
        protected int contadorBlanco;
        protected int contadorRosado;
        protected int contadorEspumante;
        public string Nombre { get => this.nombre; set => nombre = value; }
        public int ContadorTinto { get => contadorTinto; }
        public int ContadorBlanco { get => contadorBlanco; }
        public int ContadorRosado { get => contadorRosado; }
        public int ContadorEspumante { get => contadorEspumante; }
        public Vinoteca(string nombre)
        {
            this.nombre = nombre;
            this.clientes = new Listado<Cliente>();
            this.cajas = new Listado<CajaDeVino>();
        }

        /// <summary>
        /// lista la cantidad por tipo de vino
        /// </summary>
        /// <returns>Retorna una cadena con la cantidad de cada tipo</returns>
        public string ListarPorTipo()
        {
            contadorBlanco = 0;
            contadorTinto = 0;
            contadorRosado = 0;
            contadorEspumante = 0;
            StringBuilder sb = new StringBuilder();

            foreach (CajaDeVino item in cajas.lista)
            {


                switch (item.tipo)
                {
                    case CajaDeVino.Tipo.tinto:
                        this.contadorTinto++;
                        break;
                    case CajaDeVino.Tipo.blanco:
                        this.contadorBlanco++;
                        break;
                    case CajaDeVino.Tipo.rosado:
                        this.contadorRosado++;
                        break;
                    case CajaDeVino.Tipo.espumante:
                        this.contadorEspumante++;
                        break;
                }

            }
            sb.AppendLine($"Cantidad de cajas Tinto:{contadorTinto}");
            sb.AppendLine($"Cantidad de cajas Blanco:{contadorBlanco}");
            sb.AppendLine($"Cantidad de cajas Rosado:{contadorRosado}");
            sb.AppendLine($"Cantidad de cajas Espumantes:{contadorEspumante}");

            return sb.ToString();

        }
        /// <summary>
        /// Elimina una caja de vino segun el tipo que se pase
        /// </summary>
        /// <param name="tipo">Enum del tipo de caja de vino a borrar</param>
        public void eliminarPorTipo(CajaDeVino.Tipo tipo)
        {
            foreach (CajaDeVino item in cajas.lista)
            {
                if (item.tipo == tipo)
                {
                    cajas.lista.Remove(item);
                    break;
                }
            }
        }
        /// <summary>
        /// Busca cliente por nombre
        /// </summary>
        /// <param name="nombre">nombre de cliente a buscar</param>
        /// <returns></returns>
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
        /// <summary>
        /// verifica si existe cliente con el dni que se pase
        /// </summary>
        /// <param name="dni">Dni del cliente a saber si existe</param>
        /// <returns>true si existe, false si no</returns>
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
        /// <summary>
        /// Busca el cliente que se pase por dni
        /// </summary>
        /// <param name="dni">dni del cliente a buscar</param>
        /// <returns>retorna el cliente si lo encontro o lanza una excepcion si no lo encuetra</returns>
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

