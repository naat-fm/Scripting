using System;

namespace String_Arreglo_de_datos
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://youtu.be/iFAxloVL_5Y
            
            string frase = "";
            string palabra = "";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Ingrese la frase que quieras");
            Console.ForegroundColor = ConsoleColor.White;
            frase = Console.ReadLine().ToUpper();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Ingrese la palabra que desee encontrar");
            Console.ForegroundColor = ConsoleColor.White;
            palabra = Console.ReadLine().ToUpper();

            string[] palabras = frase.Split(" ");

            int contador = 0;
            for (int i = 0; i < palabras.Length; i++)
            {
                if (palabras[i] == palabra)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Palabra en posición:" + i);
                    Console.ForegroundColor = ConsoleColor.White;

                    contador++;
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Total de veces que apareción la palabra:" + contador);
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
