using System;

namespace entidades
{
    public static class Calculadora
    {
        private static char ValidarOperador(char operador)
        {
            char retorno = '+';
            if (operador == '/' || operador == '*' || operador == '-')
            {
                retorno = operador;
            }
            return retorno;
        }
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
