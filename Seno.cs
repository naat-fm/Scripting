using System;

namespace Seno
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://www.youtube.com/watch?v=Ucy78NbEzpI
            
            Console.WriteLine("Ingrese el valor de X: ");

            double x = double.Parse(Console.ReadLine());
            Sin(x);
        }

        static void Sin(double x)
        {
            double total = 0;
            int n = 100;

            for (int i = 0; i < n; i++)
            {
                total += ((Math.Pow(-1, i)) / Factorial((2 * i) + 1)) * (Math.Pow(x, (2 * i) + 1));
            }

            Console.WriteLine("El valor de sin es:" + total);

        }

        static double Factorial(double valor)
        {
            if (valor <= 1) return 1;
            return valor * Factorial(valor - 1);
        }


    }
}
