using System;

namespace CursoCSharp_6_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numero = 8;
            
            //Como quedaria con un switch

            switch (numero)
            {
                case 1: Console.Write("Es un uno");
                    break;
                case 5:
                    Console.Write("Es un cinco");
                    break;
                case 7:
                    Console.Write("Es un siete");
                    break;
                case 15:
                    Console.Write("Es un 15");
                    break;
                default: Console.Write("No coincide con nada");
                    break;
            };

            //Como quedaria con un if

            if(numero == 1)
            {
                Console.Write("Es un uno");
            }
            else
            {
                if (numero == 5)
                {
                    Console.Write("Es un cinco");
                }
                else
                {
                    if (numero == 7)
                    {
                        Console.Write("Es un siete");
                    }
                    else
                    {
                        if (numero == 15)
                        {
                            Console.Write("Es un 15");
                        }
                        else
                        {
                            Console.Write("No coincide con nada");
                        }
                    }

                }
            }
        }
    }
}