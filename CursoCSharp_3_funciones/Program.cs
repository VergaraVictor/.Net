using System;

namespace CursoCSharp_3_funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string saludo = Saludo("Pedro","Lopez");
        }
        
        public static string Saludo(string nombre, string apellidos)
        {
            return "Mi nombre es: " + nombre + " " + apellidos;
        }
    }
}