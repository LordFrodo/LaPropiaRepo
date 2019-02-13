using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            string respuesta = "s";
            int maximo = 0;
            int minimo = 100;
            int contador = 0;
            double total = 0;
            string nombre_mayor = "";
            string nombre_menor ="" ;

            while(respuesta=="s"){
                Console.Write("Ingrese su nombre: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese su edad");
                int edad = int.Parse(Console.ReadLine());

                if (edad> maximo)
                {
                    maximo = edad;
                    nombre_mayor = nombre;
                }
                if (edad<=minimo)
                {
                    minimo = edad;
                    nombre_menor = nombre;
                }
                contador += 1;
                total += edad;
                Console.Write("Desea ingresar otro dato(s/n)");
                respuesta = Console.ReadLine();
            }

            double promedio = total / contador;
            Console.WriteLine("La edad minima es de "+nombre_menor+" con una edad de " + minimo);
            Console.WriteLine("La edad maxima es de "+nombre_mayor+" con una edad de " + maximo);
            Console.WriteLine("La edad promedio es " + promedio);
            Console.ReadLine();
        }
    }
}
