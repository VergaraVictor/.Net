using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private readonly string _estaEsMiCadena; //para variables privadas se coloca al inicio _nombre
        static void Main(string[] args)
        {

            //Camel case 
            // Se usa cuando en varibles locales y miebros privados
            var estoEsUnaVariable = "Camel";

            //Pascal case
            //Se usa cuando definimos tipos, metodos y clases
            var EstoEsUnaVariable = "Pascal";

        }

        //Metodo
        //Bien Buen ejemplo 
        public int SumaDosNumeros(int numeroUno, int numeroDos)
        {
            var resultado = numeroUno + numeroDos;

            return resultado;
        }

        //Mal ejemplo

        public int Sumar(int a, int b)
        {
            var c = a + b;

            return c;
        }


    }
}
