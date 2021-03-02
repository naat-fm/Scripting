using System;

namespace Simulacro2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            string respuesta = "s";

            int dado = 0, dadoe = 0, totaltiros = 0;
            double contador1 = 3, contador2 = 0, contador3 = 0, contador4 = 0;
            //Contador1 : Vidas, Contador2: Perder vida, Contador3: Dados espaciales, contador4: Ganar vidas

            Console.WriteLine("Desea jugar? (s/n)");
            respuesta = Console.ReadLine();


            if (respuesta == "s")
            {
                Console.WriteLine("Inicia con 3 vidas y 2 dados especiales, si desea usarlos responda 'e'");

                while ((totaltiros < 100) && (contador1 > 0))
                {

                    Console.WriteLine("Desea continuar? (s/n/e)");
                    respuesta = Console.ReadLine();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Vidas:" + contador1);
                    Console.ForegroundColor = ConsoleColor.White;


                    if (respuesta == "s")
                    {

                        dado = aleatorio.Next(1, 7);
                        Console.Write("Dado: " + dado);

                        totaltiros += dado;
                        Console.WriteLine(" Total tiros: " + totaltiros);

                    }

                    if (dado == 1)
                    {
                        contador2++;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Cantidad de dados1 = " + contador2);
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    if (contador2 == 2)
                    {
                        contador2 = 0;
                        contador1--;
                        totaltiros -= 10;
                        Console.WriteLine(" Usted ha perdido una vida y 10 puntos, total: " + totaltiros);

                    }

                    if (dado == 6 || dadoe == 6)
                    {
                        contador4++;

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Cantidad de dados 6: " + contador4);
                        Console.ForegroundColor = ConsoleColor.White;


                        if (contador4 == 2 && contador1 < 3)
                        {
                            contador1++;
                            contador4 = 0;

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Ha obtenido una vida");
                            Console.WriteLine("Vidas:" + contador1);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }

                    else
                    {
                        contador4 = 0;
                    }

                    if (respuesta == "e" && contador3 < 2)
                    {
                        contador3++;
                        dadoe = aleatorio.Next(1, 13);

                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Write("Dado especial: " + dadoe);
                        Console.ForegroundColor = ConsoleColor.White;

                        totaltiros += dadoe;
                        Console.WriteLine(" Total tiros: " + totaltiros);
                    }


                    if (totaltiros > 99)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Felicidades, has ganado.");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }

                    if (contador1 <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Has perdido");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }

                    while (respuesta == "e" && contador3 == 2)
                    {
                        Console.WriteLine("Entrada no valida");
                        break;
                    }

                    while (respuesta != "s" && respuesta != "n" && respuesta != "e")
                    {
                        Console.WriteLine("Entrada no valida");
                        break;
                    }
                }
            }
        }
    }
}
