using System;

namespace Black_Jack_Multijugador
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //Variables
                Random Aleatorio = new Random();

                int jugadores = 0, contador = 0, maximo = 0, ganador = 0;
                int carta1 = 0, carta2 = 0, total = 0;

                Console.WriteLine("Cantidad de jugadores:");
                jugadores = int.Parse(Console.ReadLine());

                while (jugadores < 2 || jugadores > 5)
                {
                    Console.WriteLine("Entrada no valida");
                    Console.WriteLine("Cantidad de jugadores:");
                    jugadores = int.Parse(Console.ReadLine());
                }

                while (contador < jugadores)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Bienvenido jugador " + (contador + 1));
                    Console.ForegroundColor = ConsoleColor.White;

                    carta1 = Aleatorio.Next(1, 11);
                    Console.WriteLine("El valor de su carta es:" + carta1);

                    carta2 = Aleatorio.Next(1, 11);
                    Console.WriteLine("El valor de su carta es:" + carta2);

                    total = carta1 + carta2;
                    Console.WriteLine("El valor total de sus cartas es:" + total);
                    Console.WriteLine("Desea recibir otra carta?(s/n)");
                    string respuesta = Console.ReadLine();

                    while (respuesta != "s" && respuesta != "n")
                    {
                        Console.WriteLine("Entrada no valida");
                        Console.WriteLine("Desea recibir otra carta?(s/n)");
                        respuesta = Console.ReadLine();
                    }

                    while (respuesta == "s")
                    {
                        int cartanueva = Aleatorio.Next(1, 11);
                        Console.WriteLine("El valor de su carta es:" + cartanueva);

                        total += cartanueva;
                        Console.WriteLine("El valor total de sus cartas es:" + total);


                        if (respuesta == "n") break;


                        if (total < 21)
                        {
                            Console.WriteLine("Desea seguir jugando?(s/n)");
                            respuesta = Console.ReadLine();

                        }
                        else if (total == 21)
                        {
                            Console.WriteLine("Ganaste :)");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Perdiste :(");
                            break;
                        }
                    }

                    if (total > maximo && total <= 21)
                    {
                        maximo = total;
                        ganador = contador + 1;
                    }

                    contador++;
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ganador jugador:" + (ganador));
                Console.ForegroundColor = ConsoleColor.White;
            }

        }
    }
    }

