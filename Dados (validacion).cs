using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados_Simulacro
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado1 = 0, total = 0, consecutivos = 0, jugador = 1, n = 0;
            string respuesta = "s";
            Console.WriteLine("Ingrese numero de jugadores (2-5)");
            n = int.Parse(Console.ReadLine());
            while (n < 2 || n > 5)
            {
                Console.WriteLine("Error, ingrese un numero de jugadores (2-5)");
                n = int.Parse(Console.ReadLine());
            }
            if (n >= 2 && n <= 5)
            {
                Console.WriteLine("\nQue comience el juego");
                while (jugador <= n)
                {

                    Console.WriteLine("\n\nBienvenido Jugador: " + jugador);

                    while (true)
                    {
                        dado1 = aleatorio.Next(1, 7);
                        total += dado1;

                        Console.WriteLine("Dado = " + dado1);
                        if (dado1 == 1)
                        {
                            consecutivos += 1;
                            if (consecutivos == 3)
                            {
                                total = 0;
                                Console.WriteLine("Has perdido");
                                Console.WriteLine("Total: " + total);
                                consecutivos = 0;
                                break;
                            }
                        }
                        else
                        {
                            consecutivos = 0;
                        }
                        if (total < 100 && respuesta=="s")
                        {
                            Console.WriteLine("Total = " + total);
                            Console.Write("Desea continuar (s/n): ");
                            respuesta = Console.ReadLine();
                            if (respuesta != "s" || respuesta != "n") 
                            {
                                while (respuesta != "s"  && respuesta != "n")
                                {
                                    Console.WriteLine("Error. Ingrese una respuesta valida. Desea continuar (s/n)");
                                    respuesta = Console.ReadLine();
                                }
                            }

                            if (respuesta == "n")
                            {
                                total = 0;
                                respuesta = "s";
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Has ganado");
                            total = 0;
                            jugador += n;
                            break;
                        }
                    }
                    Console.WriteLine("Gracias por participar");
                    jugador += 1;
                }
            }
            Console.ReadLine();
        }
    }
}