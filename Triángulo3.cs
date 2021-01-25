using System;

namespace Triangulo3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicio

            Console.WriteLine("Ingrese 'c' :");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese 'z':");
            double z = double.Parse(Console.ReadLine());

            //Proceso 

            double cgrados = c * (Math.PI / 180.0);

            double t = z / Math.Sin(cgrados);
            double y = t * Math.Cos(cgrados);
            double a = Math.Atan(y / z);

            y = Math.Round(y, 2);

            //Final

            double agrados = a * (180.0 / Math.PI);

            Console.WriteLine("a ="+ agrados);
            Console.WriteLine("y ="+ y);
            Console.WriteLine("t ="+ t);
        }

    }
}
