using System;

namespace entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida que el char recibido sea + - / o *, en caso contrario retornara +.
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>retorna el operador que corresponda</returns>
        private static char ValidarOperador(char operador)
        {
            char retorno = '+';
            if (operador == '/' || operador == '*' || operador == '-')
            {
                retorno = operador;
            }
            return retorno;
        }
        /// <summary>
        /// valida y realiza la operacion entre ambos numeros
        /// </summary>
        /// <param name="numeroUno">Primer numero</param>
        /// <param name="numeroDos">Segundo numero</param>
        /// <param name="operador">Operador</param>
        /// <returns> retorna el resultado</returns>

        public static double Operar(Operando numeroUno, Operando numeroDos, char operador)
        {
            double resultadoDeOperacion = 0;

            switch (ValidarOperador(operador))
            {
                case '+':
                    resultadoDeOperacion = numeroDos + numeroUno;
                    break;
                case '/':
                    resultadoDeOperacion = numeroUno / numeroDos;
                    break;
                case '-':
                    resultadoDeOperacion = numeroUno - numeroDos;
                    break;
                case '*':
                    resultadoDeOperacion = numeroDos * numeroUno;
                    break;

            }
            return resultadoDeOperacion;

        }
    }
}
