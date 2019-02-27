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
            Console.WriteLine("Ingrese numero de jugadores");
            n = int.Parse(Console.ReadLine());
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
                        if(consecutivos == 3)
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
                    if (total < 100)
                    {
                        Console.WriteLine("Total = " + total);
                        Console.Write("Desea continuar (s/n): ");
                        if (Console.ReadLine() != "s")
                        {
                            total = 0;
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
                }Console.WriteLine("Gracias por participar");
                jugador += 1;
            }
            Console.ReadLine();
        }
    }
}
