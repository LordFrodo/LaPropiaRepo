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
            Fruta fruta = new Fruta();
            
            fruta.Madura = true;
            fruta.Tipo_fruta = "Platanera";
            //fruta.Vitaminas =new string[4] { "Vitamina B6", "Vitamina C", "Vitamina B12", "Potacio" };
            fruta.Cantidad = 10;
            Console.WriteLine(fruta.Madura);
            Console.WriteLine(fruta.Tipo_fruta);
            Console.WriteLine(fruta.Cantidad);
            Console.WriteLine(fruta.Volumen);
            Console.WriteLine(fruta.Vitaminas);
            Console.WriteLine(fruta.Nombre);

            Console.ReadKey();
             
        }
    }
}
