using System;

namespace UnDado
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            string respuesta = "s";
            int total = 0;
            int dadoA = 0, dadoB = 0;
            double contador1 = 0, contador2 = 0;
            int par = 0, totaltiros = 0;


            Console.WriteLine("Desea jugar? (s/n)");
            respuesta = Console.ReadLine();

            while (respuesta == "s")
            {
                contador1 += 1;

                dadoA = aleatorio.Next(1, 7);
                Console.Write("Dado A:" + dadoA);

                dadoB = aleatorio.Next(1, 7);
                Console.WriteLine(" Dado B:" + dadoB);

                total = dadoA + dadoB;
                Console.Write("Total de dados:" + total);

                totaltiros += total;
                Console.WriteLine(" Total de tiros:" + totaltiros);

                if (total > 6) contador2 += 1;

                if (dadoA == dadoB) par += 1;
                Console.WriteLine("Total de pares:" + par);

                if ((dadoA == 1) && (dadoB == 1))
                {

                    Console.WriteLine("Has perdido :(");
                    respuesta = "n";

                    double porcentaje = (contador2 / contador1) * 100;
                    Console.WriteLine("Porcentaje de tiros mayores a 6:" + porcentaje);

                }

                if ((totaltiros > 99) || (par == 3))
                {
                    Console.WriteLine("Has ganado :)");
                    respuesta = "n";

                    double porcentaje = (contador2 / contador1) * 100;
                    Console.WriteLine("Porcentaje de tiros mayores a 6:" + porcentaje);
                }

                if ((totaltiros < 100) && (respuesta == "s"))
                {
                    Console.WriteLine("Desea continuar? (s/n)");
                    respuesta = Console.ReadLine();
                }

            }
        }
    }
}
