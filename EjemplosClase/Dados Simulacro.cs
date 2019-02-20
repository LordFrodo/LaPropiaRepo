using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado1 = 0, dado2 = 0,  total = 0, tiros = 0;
            double Contador6 = 0,dobles = 0,porcentaje=0;
            string continuar = "s";
            while (continuar == "s")
            {
                dado1 = aleatorio.Next(1, 7);
                dado2 = aleatorio.Next(1, 7);
                Console.WriteLine("Dado 1 = " + dado1 + " Dado 2 = " + dado2);
                if(dado1==1 && dado2 == 1)
                {
                    total = 0;
                    Console.WriteLine("Eliminado");
                    continuar = "n";
                }     
                else
                {
                    total += dado1 + dado2;
                    tiros += 1;
                    if (dado1 + dado2 > 6)
                    {
                        Contador6 += 1;
                    }
                    if (dado1 == dado2 && dado1 > 1)
                    {
                        dobles += 1;
                    }
                    else {
                        dobles = 0;
                    }
                    if (dobles == 3)
                    {
                        Console.WriteLine("Has Ganado");
                        continuar = "n";
                    }
                    if (total < 100)
                    {
                        Console.WriteLine("Total = " + total);
                        Console.Write("Desea continuar (s/n): ");
                        continuar = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Total = " + total);
                        continuar = "n";
                        Console.WriteLine("Has ganado");
                    }
                }
            }
            Console.WriteLine("Su total fue " + total);
            porcentaje = (Contador6 / tiros) * 100;
            Console.WriteLine("El porcentaje de veces que saco mas de 6 fue de " + porcentaje);
            Console.Write("Gracias por participar");
            Console.ReadLine();
        }
    }
}
