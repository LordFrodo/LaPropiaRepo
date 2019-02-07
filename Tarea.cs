using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Tarea
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

            if (((votantes > n) || Math.Abs(a-b) < (votantes*0.1)) && votantes < (n*0.3)) {

                Console.WriteLine("Las votaciones se haran nuevamente");

            } else {

                if (a > b){
                    Console.WriteLine("El partido 1 es el ganador");
                }else if (a < b){

                    Console.WriteLine("El partido 2 es el ganador");
                }
            }
            Console.ReadLine();
        }
    }
}
