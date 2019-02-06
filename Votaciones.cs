using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese # de votos del partido 1, 2, votos en blanco y votos anulados. Ingrese poblacion total y el porcentaje de los mayores de edad");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int blancos = int.Parse(Console.ReadLine());
            int anulados = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());

            
            int votantes = (a + b + blancos + anulados);
            int abstencion = (int)(n * (p / 100)) - (votantes);

            if (((anulados < ((a + b) * 0.3)) || ((a + b) > blancos)) && (abstencion < votantes)){
                if (a > b)
                {
                    Console.WriteLine("El partido ganador es 1");
                }
                else if (a < b)
                {
                    Console.WriteLine("El partido ganador es 2");

                }
                Console.WriteLine("Las votaciones fueron exitosas");
            }
            else {
                Console.WriteLine("Las elecciones seran realizadas nuevamente");
            }
            Console.ReadLine();

        }
    }
}
