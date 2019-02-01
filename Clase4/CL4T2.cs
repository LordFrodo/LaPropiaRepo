using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CL4T2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el salario");
            double salario = double.Parse(Console.ReadLine());
            int SMMLV = 828116;

            //Menor a dos salarios minimos
            if (salario < (2 * SMMLV))
            {

                Console.WriteLine("Tarifa A");
                Console.WriteLine("Cuota Moderadora: 3200$");

            }
            else if (salario >= (2 * SMMLV) & salario < (5 * SMMLV))
            {
                //Sean 2 o mas salarios pero menos de 5 SMMLV
                Console.WriteLine("Tarifa B");
                Console.WriteLine("Cuota Moderadora: 12700$");
            }
            else
            {
                //Mayor a 4 SMMLV

                Console.WriteLine("Tarifa C");
                Console.WriteLine("Cuota Moderadora: 33500$");
            }


            Console.ReadLine();
        }
    }
}
