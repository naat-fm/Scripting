using System;

namespace Triangulo4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Ingrese z: ");
            double z = double.Parse(Console.ReadLine());

            Console.Write("Ingrese y: ");
            double y = double.Parse(Console.ReadLine());

            double a = Math.Atan(y / z);
            double agrad = a * (180.0 / Math.PI);
            double F = agrad + b;
            double Fgrad = F * (Math.PI / 180.0);
            double x = (Math.Tan(Fgrad) * z) - y;

            x = Math.Round(x, 2);

            Console.WriteLine("x =" + x);
        }
    }
}
