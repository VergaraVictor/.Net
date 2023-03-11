using System;

namespace CursoCSharp_1
{ 
    class Program
    {
        static void Main(string[] args)
        {
            // 0 a 255
            byte v1 = 200;
            Console.WriteLine("Valor almacenado en la variable de tipo byte" + v1);

            // -128 a 127
            sbyte v2 = -100;
            Console.WriteLine("Valor almacenado en la variable de tipo sbyte:" + v2);

            //-32768 a 32767
            short v3 = 30000;
            Console.WriteLine("Valor almacenado en la variable de tipo short:" + v3);

            //0 a 65535
            ushort v4 = 60000;
            Console.WriteLine("Valor almacenado en la variable de tipo ushort:" + v4);

            //-2147483648 a 2147483647
            int v5 = -2000000000;
            Console.WriteLine("Valor almacendado en la variable de tipo int:" + v5);

            //0 a 4294967295
            uint v6 = 2000000000;
            Console.WriteLine("Valor almacenado en la variable de tipo uint:" + v6);

            //-9223372036854775808 a 9223372036854775807
            long v7 = -1000000000000000000;
            Console.WriteLine("Valor almacenamiento en la variable de tipo long:" + v7);

            //0, 18446744073709551615
            ulong v8 = 1000000000000000000;
            Console.WriteLine("Valor almacenado en la variable de tipo ulong:" + v8);
            Console.ReadKey();

            Console.WriteLine("Bytes reservados para el tipo byte:" + sizeof(byte));
            Console.WriteLine("Bytes reservados para el tipo sbyte:" + sizeof(sbyte));
            Console.WriteLine("Bytes reservados para el tipo short:" + sizeof(short));









        }
    }
}
