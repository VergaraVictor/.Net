using System;

namespace CursoCSharp_2_variables
 {
    class Program
    {
        static void Main(string[] args)
        {
            String mensajes = Console.ReadLine();

            string hola = null;

            int edad = default(int); //0
            int? altura = null; // al colocar ? despues del tipo de dato puede ser null que es declarla null
            bool verdadero = default(bool); //false

            edad = edad + 5;

            if(edad == null)
            {
                //hacer algo
            }

            DateTime? fecha = new DateTime();
            fecha = null;
            int? dia = fecha?.Day;

            Console.WriteLine(edad);
            Console.ReadLine();

            var peso = 85;

        }
    }
}