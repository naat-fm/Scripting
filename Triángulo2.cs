using System;

namespace Triangulo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicio
            Console.WriteLine("Ingrese 't':");
            double t = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese 'a':");
            double a = double.Parse(Console.ReadLine());

            //Proceso
            double agrad = a * ( Math.PI/180.0 );

            double z = Math.Cos(agrad) * t;
            double y = (Math.Sin(agrad) * t);
            double c = Math.Atan(z / y);

            double cgrados = c * (180 / Math.PI);

            //Resultados 
            
            Console.WriteLine("z=" +  z);
            Console.WriteLine("y =" + y);
            Console.WriteLine("c =" + cgrados);
        }
    }
}
