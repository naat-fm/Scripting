using System;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese el valor de x: ");

            double x = double.Parse(Console.ReadLine());

            int n = 100;

            double total = 0;

            for (int i = 0; i < n; i++)
            {
                total += (Math.Pow(x, i) / Factorial(i));
            }
            Console.WriteLine("el valor de 'e' es : " + total);
        }
        static double Factorial(double valor)
        {
            if (valor <= 1) return 1;
            else
            {
                return valor * Factorial(valor - 1);
            }
        }
    }
}
