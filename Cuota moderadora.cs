using System;

namespace Cuota_moderadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su salario");

            double salario = double.Parse(Console.ReadLine());

            double sm = 908526;

            double dossm = 2 * sm;
            double cuasm = 4 * sm;

            if (salario < sm)
            {
                Console.WriteLine("Usted es tarifa A y debe un copago de 3500");
            }

            else if (dossm <= salario && salario <=cuasm )
            {
                Console.WriteLine("Usted es tarifa B y debe un copago de 14000");
            }
           if (salario > cuasm)
            {
                Console.WriteLine("Usted es tarifa C y debe un copago de 36800");


            }
        }
    }
}
