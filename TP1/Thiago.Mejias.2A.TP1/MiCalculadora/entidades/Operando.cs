using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Operando
    {
        private double numero;
        public string Numero
        {
            get
            {
                return this.numero.ToString();
            }
            set
            {
                this.numero = ValidarOperando(value);
            }
        }
        /// <summary>
        /// inicializa un objeto de tipo Operando con el valor pasado por parametro
        /// </summary>
        /// <param name="numero">recibe entero para inicializar</param>
        public Operando(double numero)
        {
            this.numero = numero;
        }
        /// <summary>
        /// inicializa un objeto de tipo Operando en 0
        /// </summary>
        public Operando() : this(0)
        {

        }
        /// <summary>
        /// inicializa un objeto de tipo Operando con el valor pasado por parametro
        /// </summary>
        /// <param name="strNumero">string para inicializar</param>
        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }

        /// <summary>
        /// comprueba que el valor recibido sea numérico.
        /// </summary>
        /// <param name="valor">valor a validar</param>
        /// <returns> retorna el valor en formato double. Caso contrario, retornará 0.</returns>
        private double ValidarOperando(string valor)
        {
            double retorno;

            if (!Double.TryParse(valor, out retorno))
            {
                retorno = 0;
            }
            return retorno;
        }
        /// <summary>
        /// comprueba si el valor recibido es o no binario.
        /// </summary>
        /// <param name="cadena">valor a validar</param>
        /// <returns>retorna true si se pudo o false si no</returns>

        private bool EsBinario(string cadena)
        {
            int cantidadDeCaracteres = cadena.Length;
            bool retorno = true;
            for (int i = 0; i < cantidadDeCaracteres; i++)
            {
                if (cadena[i] != '0' && cadena[i] != '1')
                {
                    retorno = false;
                    break;
                }
            }
            return retorno;
        }

        /// <summary>
        /// trasnforma si se puede el valor recibido de binario a decimal
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>retorna el valor transformado o "valor invalido"</returns>

        public string BinarioDecimal(string valor)
        {
            string retorno = "Valor invalido";
            if (EsBinario(valor))
            {
                int numeroConvertido = 0;
                char[] cadenaDadaVuelta = valor.ToArray();
                Array.Reverse(cadenaDadaVuelta);

                for (int i = 0; i < valor.Length; i++)
                {
                    if (cadenaDadaVuelta[i] == '1')
                    {
                        numeroConvertido += (int)(Math.Pow(2, i));

                    }
                }
                if (numeroConvertido > 0)
                {
                    retorno = numeroConvertido.ToString();
                }
            }
            return retorno;

        }
        /// <summary>
        /// transforma si se puede de decimal a binario.
        /// </summary>
        /// <param name="valorstr"></param>
        /// <returns>true si se puede o "valor invalido" si no</returns>
        public string DecimalABinario(string valorstr)
        {
            string retorno = "";
            int valor;
            int resto;
            if (int.TryParse(valorstr, out valor) && valor > 0)
            {
                while (valor > 0)
                {
                    resto = valor % 2;
                    valor = valor / 2;
                    retorno = resto.ToString() + retorno;
                }
            }
            else
            {
                retorno = "Valor invalido";
            }


            return retorno;
        }
        /// <summary>
        /// transforma si se puede de decimal a binario.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns> true si se puede o "valor invalido" si no</returns>
        public string DecimalABinario(double numero)
        {
            return DecimalABinario(numero.ToString());
        }

        public static double operator +(Operando uno, Operando dos)
        {
            return uno.numero + dos.numero;

        }
        public static double operator -(Operando uno, Operando dos)
        {
            return uno.numero - dos.numero;
        }

        public static double operator /(Operando uno, Operando dos)
        {
            if (dos.numero == 0)
            {
                return double.MinValue;
            }
            return uno.numero / dos.numero;
        }
        public static double operator *(Operando uno, Operando dos)
        {
            return uno.numero * dos.numero;
        }



    }
}
