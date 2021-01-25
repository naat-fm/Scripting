using System;

namespace Triangulo7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese w: ");
            double w = double.Parse(Console.ReadLine());

            Console.Write("Ingrese t: ");
            double t = double.Parse(Console.ReadLine());

            Console.Write("Ingrese c: ");
            double c = double.Parse(Console.ReadLine());

            //proceso

            double ccon = c * (Math.PI / 180.0);
            double z = Math.Sin(ccon) * t;
            double y = Math.Sqrt(t * t - z * z);
            double x = Math.Sqrt(w * w - z * z) - y;

            x = Math.Round(x, 2); //para redondear 

            //Salida
            Console.WriteLine("x = " + x);
        }
    }
}
