using System;
/* Intruccion de interaciónes una de ella do do ejecuta un instruccion o bloques de instrucciones,
* se evalua despues de cada ejecución del bucle con lo que se ejecuta una o varias veces.
*/
namespace CursoCSharp_7_do
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*do
            *{
            *    // Instrucciones
            *} while (true); //Mientras se cumpla unas condiciones
            */

            int numero = 0;

            do
            {
                Console.Write(numero);
                numero++; //esto es igual a colocar a numero = numero + 1;

                if (numero ==5)
                {
                    return;
                }
            }
            while (numero < 10); 

        }
    }
}
