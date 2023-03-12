using System;

//Es una instrucion de interaccion, un bucle white se evalua antes de la instrucción; puede ser que no ingrese nunca

namespace CursoCSharp_8_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;

            while (numero < 10)
            {
                Console.WriteLine(numero);
                numero++;
            }
        }
    }
}
