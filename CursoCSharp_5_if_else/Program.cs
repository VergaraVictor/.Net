using System;

namespace CursoCSharp_5_if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IF Else

            bool bandera = true;

            if(bandera)
            {
                //si bandera = true
            }
            else
            {
                //si bandera = false
            }

            int suma = 12 + 8;

            if(suma <= 30)
            {
                //suma es menor o igual a 30
            }
            else
            {
                //suma es mayor que 30
            }

            if(suma.GetType() == typeof(int))
            {
               //Si suma es un entero
            }

            // Seguiria la ejecución


            var multiplicacion = 20;
            if (suma == 20 && bandera)
            {

                if(suma > 30)
                {

                }
                else
                {
                    if(bandera)
                    {

                    }
                }

            }

        }
    }
}
