using System;

namespace Dos_Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado = 0, total = 0, tiro = 0;
            string respuesta = "s";

            while (respuesta == "s")
            {
                tiro++;

                Console.WriteLine("¿Arrojar dados?(s/n)");
                respuesta = Console.ReadLine();

                dado = aleatorio.Next(1, 13);
                Console.WriteLine("Dado= " + dado);

                total += dado;

                Console.WriteLine("Total= " + total);
                Console.WriteLine("Tiro= " + tiro);

                if (dado == 12 && respuesta == "s")
                {
                    Random aleatorionew = new Random();
                    int dadonew;
                    dadonew = aleatorionew.Next(1, 13);

                    if (dadonew == 10)
                    {
                        Console.WriteLine("Dado=" + dadonew);
                        Console.WriteLine("Has ganado");
                        respuesta = "n";

                    }
                }

                if (tiro > 3)
                {
                    Console.WriteLine("No posee más turnos libres");

                    if (dado % 2 != 0)
                    {
                        Console.WriteLine("Has perdido");
                        respuesta = "n";
                    }

                    if (total > 99)
                    {
                        Console.WriteLine("Has ganado");
                        respuesta = "n";
                    }
                }
            }
        }
    }
}
