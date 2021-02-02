using System;

namespace Calculo_tarifa
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

            if (salario <sm)
            {
                Console.WriteLine("Usted es tarifa A");
            }

            else if(sm<= salario && salario <= dossm)
            {
                Console.WriteLine("Usted es tarifa B");
            }
            else if (salario >cuasm)
            {
                Console.WriteLine("Usted es tarifa C");
            }
            //video: https://youtu.be/R5_pBt8FZDo

        }
    }
}
