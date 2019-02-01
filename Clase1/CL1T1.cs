using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese z, y");
            double z = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            //Valores Angulos
           double bGrados = 90; //CTE triangulo rectangulo


            //Calculo de lados
            double t = Math.Sqrt((y * y) + (z * z));

            //Conversion angulos a radianes
            double b = bGrados * (Math.PI / 180.0);

            //Calculo de angulos
            double aRad= Math.Asin((y * Math.Sin(b)) / t);
            double cRad = Math.Asin((z * Math.Sin(b)) / t);
            double a = aRad * (180 / Math.PI);
            double c = cRad * (180 / Math.PI);

            //Resultados
            Console.WriteLine("t:" + t);
            Console.WriteLine("a:" + a);
            Console.WriteLine("c:" + c);
            Console.ReadLine();




            


        }
    }
}
