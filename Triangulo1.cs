using System;

namespace Triángulo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicio
            Console.WriteLine("Ingrese 'y' :");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese 'z':");
            double z = double.Parse(Console.ReadLine());

            //Proceso
      
            double a = Math.Atan(y / z);
            double c = Math.Atan(z / y);
            double t = (3 / Math.Sin(c));

            double agrados = a * (180.0 / Math.PI);
            double cgrados = c * (180.0 / Math.PI);

            //Resultados 
            Console.WriteLine("t=" + t);
            Console.WriteLine("a=" + agrados);
            Console.WriteLine("c =" + cgrados);
        }
    }
}
