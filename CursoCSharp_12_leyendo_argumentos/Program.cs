using System;
using System.Collections.Generic;

namespace CursoCSharp_12_leyendo_argumentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hay " + args.Length + " elementos");

            foreach (var argumentos in args) 
            {
                Console.WriteLine(argumentos);
            }
        }
    }
}
