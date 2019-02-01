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
            Console.WriteLine("Ingrese w,d,x");
            double w = double.Parse(Console.ReadLine());
            double dGrados = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());

            //Valores Cte
            double fGrados = 90;

            //Transformacion a radianes
            double d = dGrados * (Math.PI / 180);
            double f = fGrados*(Math.PI/180);

            //Calculos
            double z = (w * Math.Sin(d)) / Math.Sin(f);
            double g = Math.Sqrt((w * w) - (z * z));
            double y = g - x;

            Console.WriteLine("y:" + y);
            Console.ReadLine();


        }
    }
}
