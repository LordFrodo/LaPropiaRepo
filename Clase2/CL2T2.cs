using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingrese datos
            Console.WriteLine("Ingrese d,b,y");
            double dGrados = double.Parse(Console.ReadLine());
            double bGrados = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            //Valores Cte
            double fGrados = 90;

            //Transformacion de grados a radianes
            double b = bGrados * (Math.PI / 180);
            double d = dGrados * (Math.PI / 180);
            double f = fGrados * (Math.PI / 180);

            //Calculos
            double eGrados = (180 - (dGrados + bGrados));
            double cGrados = (180 - (eGrados));
            double aGrados = (180 - (cGrados + fGrados));
            double c = cGrados * (Math.PI / 180);
            double a = aGrados * (Math.PI / 180);
            double z = (y * Math.Sin(c)) / Math.Sin(a);

            //Resultados
            Console.WriteLine("z:" + z);

            Console.ReadLine();
        }
    }
}
