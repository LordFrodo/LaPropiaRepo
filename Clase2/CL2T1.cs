using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingrese datos
            Console.WriteLine("Ingrese b,z,y");
            double bGrados= double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            //Valores cte 
            double fGrados = 90;

            //Transformacion de grados a radianes
            double f = fGrados * (Math.PI / 180);
            double b = bGrados * (Math.PI / 180);

            //Calculos
            double t = Math.Sqrt((y * y) + (z * z));
            double cRad = Math.Asin((z * Math.Sin(f)) / t);
            double c = cRad * (180 / Math.PI);
            double eGrados = (180 - c);
            double dgrados = (180 - (bGrados + eGrados));
            double d = dgrados * (Math.PI / 180);
            double x = (t * Math.Sin(b)) / Math.Sin(d);

            //Resultados
            Console.WriteLine("x:" + x);
            Console.ReadLine();


        }
    }
}
