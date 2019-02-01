using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CL4T1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el salario");
            double salario = double.Parse(Console.ReadLine());
            int SMMLV = 828116;

            //Menor a dos salarios minimos
            if(salario < (2*SMMLV))
            {

                Console.WriteLine("Tarifa A");
                
            } else if(salario >= (2 * SMMLV) & salario < (4 * SMMLV))
            {
                //Sean 2 o mas salarios pero menos de 4 SMMLV
                Console.WriteLine("Tarifa B");
            }
            else
            {
                //Mayor a 4 SMMLV

                Console.WriteLine("Tarifa C");
            }

            Console.ReadLine();
        }
    }
}
