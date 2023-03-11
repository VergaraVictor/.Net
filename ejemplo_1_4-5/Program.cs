using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduce tu nombre:");

        string nombre = Console.ReadLine();

        Console.WriteLine("Hola " + nombre);

        Console.ReadKey();

        Console.WriteLine("Introduce tu nombre2:");

        string nombre2 = Console.ReadLine();

        Console.WriteLine("Introduce tu ciudad:");

        string ciudad = Console.ReadLine();

        Console.WriteLine("Hola " + nombre + " bienvenido a " + ciudad);

        Console.ReadKey();


    }
}
