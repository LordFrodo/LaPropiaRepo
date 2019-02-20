using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int carta = 0, total = 0, x = 0, y = 0;
            string continuar = "p";

            x = aleatorio.Next(1, 11);
            Console.WriteLine("Carta 1 = " + x);
            y = aleatorio.Next(1, 11);
            Console.WriteLine("Carta 2 = " + y);
            total = x + y;
            Console.WriteLine("Puntos totales = " + total);
            Console.Write("Desea continuar (s/n) : ");
            continuar = Console.ReadLine();

            while (continuar == "s" ) { 
                    carta = aleatorio.Next(1, 11);
                    Console.WriteLine("Su carta es " + carta);
                    total += carta;
                    if (total > 21)
                    {
                        total = 0;
                        Console.WriteLine("Eliminado");
                        continuar = "n";
                    }
                    else { 
                    
                        Console.WriteLine("Total = " + total);
                        Console.Write("Desea continuar (s/n)");
                        continuar = Console.ReadLine();
                    }

                }
                Console.WriteLine("Su total fue : " + total);
                Console.WriteLine("Gracias por participar");
                Console.ReadLine();
            }
        }
    }



