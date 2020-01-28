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
            float [] n_definitiva = new float[IngresarNumEstudiante()];
            string[] nombres_E = new string[n_definitiva.Length];

            IngresarNombres_Notas(n_definitiva,nombres_E);

        }
        public static int IngresarNumEstudiante()
        {
            bool es_entero = false;
            int tamano = -1;
            int temp = 0;
            while (es_entero == false)
            {
                Console.WriteLine("Ingrese el número de estudiantes que desea archivar");
                es_entero = int.TryParse(Console.ReadLine(), out temp);
                if (es_entero == false||temp<0)
                {
                    Console.WriteLine("\n-------------ERROR-------------");
                    tamano = -1;
                    es_entero = false;
                }
                else
                {
                    tamano = temp;
                   // return tamano;
                }
            }

            return tamano;
        }
        public static void IngresarNombres_Notas(float[] notas_def,string[] nombres)
        {
            float x, y, z;
            for(int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre del estudiante "+(i+1));
                nombres[i] = Console.ReadLine();
                Console.WriteLine("Ingrese sus notas");


                do
                {
                    x = float.Parse(Console.ReadLine());
                    y = float.Parse(Console.ReadLine());
                    z = float.Parse(Console.ReadLine());

                } while (x > 5 || y > 5 || z > 5);
              
                notas_def[i] = (x + y + z) / 3;
            }
            for (int i = 0; i < notas_def.Length; i++)
            {
                Console.WriteLine("La nota final de " + nombres[i] + " es: " + notas_def[i]);
            }



            Console.ReadLine();
        }
    }
}
