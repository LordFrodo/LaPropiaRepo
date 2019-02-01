using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese w,t,c");
            double w = double.Parse(Console.ReadLine());
            double t = double.Parse(Console.ReadLine());
            double cGrados = double.Parse(Console.ReadLine());

            //Calculos
            double eGrados = 180 - cGrados;
            double e = eGrados * (Math.PI / 180);
            double dRad = Math.Asin((t * Math.Sin(e)) / w);
            double dGrados = dRad * (180 / Math.PI);
            double bGrados = 180 - (dGrados + eGrados);
            double b = bGrados * (Math.PI / 180);
            double x = (w * Math.Sin(b)) / Math.Sin(e);

            Console.WriteLine("x:" + x);
            Console.ReadLine();

        }
    }
}
