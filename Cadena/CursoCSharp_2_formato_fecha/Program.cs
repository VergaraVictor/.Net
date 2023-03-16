using System;

namespace CursoCSharp_2_formato_fecha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = new DateTime();
            fecha =DateTime.Now;
            Console.WriteLine("ToLocalTime: " + fecha.ToLocalTime());
            Console.WriteLine("ToLongDateString: " + fecha.ToLongDateString());
            Console.WriteLine("ToLongTimeString: " + fecha.ToLongTimeString());
            Console.WriteLine("ToOADate: " + fecha.ToOADate());
            Console.WriteLine("ToShortDateStrind: " + fecha.ToShortDateString());
            Console.WriteLine("ToShortTimeString: " + fecha.ToShortTimeString());
            Console.WriteLine("ToString: " + fecha.ToString());
            Console.WriteLine("ToUniversalTime: " + fecha.ToUniversalTime());
            Console.ReadLine();


            string fechaString = String.Format("La fecha de hoy es: {0:dd/MM/yyyy hh:mm:ss}", DateTime.Now);
            Console.WriteLine(fechaStringfechaString);
            Console.ReadLine()

        }
    }
}
