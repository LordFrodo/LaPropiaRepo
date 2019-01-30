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
            //Ingreso de datos
            Console.WriteLine("Ingrese t, a");
            double t = double.Parse(Console.ReadLine());
            double aGrados = double.Parse(Console.ReadLine());

            //Valores cte
            double bGrados = 90;

            //Transformacion a radianes
            double a = aGrados * (Math.PI / 180);
            double b = bGrados * (Math.PI / 180);

            //Calculo por ley de senos y pitagoras
            double y = (t * Math.Sin(a)) / Math.Sin(b);
            double z = Math.Sqrt((t * t) - (y * y));
            double cRad = Math.Asin((z * Math.Sin(b)) / t);
            double c = cRad * (180 / Math.PI);


            //Resultados
            Console.WriteLine("y:" + y);
            Console.WriteLine("z:" + z);
            Console.WriteLine("c:" + c);
            Console.ReadLine();

        }
    }
}
