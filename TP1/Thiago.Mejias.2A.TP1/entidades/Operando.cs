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
        public Operando(double numero)
        {
            this.numero = numero;
        }
        public Operando() : this(0)
        {

        }
        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }

        private double ValidarOperando(string valor)
        {
            double retorno;

            if (!Double.TryParse(valor, out retorno))
            {
                retorno = 0;
            }
            return retorno;
        }

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
