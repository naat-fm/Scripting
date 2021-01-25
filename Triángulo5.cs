using System;

namespace Triangulo5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese d: ");
            double d = double.Parse(Console.ReadLine());

            Console.Write("Ingrese b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Ingrese y: ");
            double y = double.Parse(Console.ReadLine());

            //proceso

            double dRad = d * (Math.PI / 180.0);
            double bRad = b * (Math.PI / 180.0);

            double e = (Math.PI) - (dRad) - (bRad);
            double c = (Math.PI) - (e);
            double z = Math.Tan(c) * y;

            z = Math.Round(z, 2);

            Console.WriteLine("z = " + z);
        }
    }
}
