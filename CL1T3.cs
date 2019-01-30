using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de datos
            Console.WriteLine("Ingrese c,z");
            double cGrados = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());

            //Valores Cte
            double bGrados = 90;

            //Transformacion de grados a radianes
            double c = cGrados * (Math.PI / 180);
            double b = bGrados * (Math.PI / 180);

            //Calculos
            double t = (z * Math.Sin(b)) / Math.Sin(c);
            double y = Math.Sqrt((t * t) - (z * z));
            double aRad = Math.Asin((y * Math.Sin(b)) / t);
            double a = aRad * (180 / Math.PI);

            //Resultados
            Console.WriteLine("t:" + t);
            Console.WriteLine("y:" + y);
            Console.WriteLine("a:" + a);
            Console.ReadLine();
        }
    }
}
