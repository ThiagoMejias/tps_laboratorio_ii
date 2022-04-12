using System;
using entidades;
namespace consolaDePrueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Operando numeroUno = new Operando();
            Operando numeroDos = new Operando();
            numeroUno.Numero = "asd82";
            numeroDos.Numero = "4546";
            Console.WriteLine(numeroUno.Numero);
            Console.WriteLine(numeroDos.Numero);


        }
    }
}
