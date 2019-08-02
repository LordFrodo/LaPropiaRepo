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
            Hamburguesa hamburguesa;//Declaracion del objeto
            hamburguesa = new Hamburguesa();
            Console.Write(hamburguesa.EsComidaDeVegano() ? "Es comida de verano" : "No vives de ensalada"); //Represantacion de un if de forma abreviada
            Console.ReadKey(); //No se cierre la ventana
        }
    }
}
