using System;

namespace Triangulo6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese w: ");
            double w = double.Parse(Console.ReadLine());

            Console.Write("Ingrese d: ");
            double d = double.Parse(Console.ReadLine());

            Console.Write("Ingrese x: ");
            double x = double.Parse(Console.ReadLine());

            //proceso

            double drad = d * (Math.PI / 180.0);

            double F = (Math.PI) - (Math.PI / 2) - drad;
            double y = Math.Sin(F) * w - x;

            y = Math.Round(y, 2);

            Console.WriteLine("y=" + y);
        }
    }
}
