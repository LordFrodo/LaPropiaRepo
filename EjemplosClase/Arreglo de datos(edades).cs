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
            Console.WriteLine("Ingrese cantidad de participantes: ");
            int n = int.Parse(Console.ReadLine());
            string[] nombres = new string [n];
            int[] edades = new int[n];
            Console.WriteLine("Ingrese nombres de los participantes");
            for (int i=0; i < nombres.Length; i++)
            {
                nombres[i] = Console.ReadLine();
            }
            Console.WriteLine("Ingrese la edad de los participantes");
            for (int s = 0; s < edades.Length; s++)
            {
                edades[s] = int.Parse(Console.ReadLine());
            }
            double total = 0, promedio = 0, Mayor = 0, Menor = 1000, desviacionEst = 0, indiceM = 0, indicem = 0, indiceCercano = 0;
            for(int r=0; r < edades.Length; r++)
            {
                total += edades[r];
                if (edades[r] > Mayor)
                {Mayor = edades[r];
                    indiceM = r;
                }
                if(edades[r] < Menor)
                {  Menor = edades[r];
                    indicem = r;
                }
            }
            promedio = total / edades.Length;
            for (int i = 0; i < edades.Length; i++) {
                desviacionEst = Math.Sqrt((Math.Pow(promedio - edades[i], 2)) / n);
                    }
            double[] absolutos = new double[edades.Length];
            int mascercano = 1000;
            for ( int w = 0; w < edades.Length; w++)
            {
                
                absolutos[w] = Math.Abs(edades[w]-promedio);
                if (absolutos[w] < mascercano) 
                {
                    mascercano = (int)absolutos[w];
                    indiceCercano = w;
                }

            }

            int p = (int)indiceM, q = (int)indicem, t = (int)indiceCercano;
            Console.WriteLine("El mayor es: " + nombres[p] + " con una edad de: " + Mayor);
            Console.WriteLine("El menor es: " + nombres[q] + " con una edad de: " + Menor);
            Console.WriteLine("El promedio de edades es de: " + promedio);
            Console.WriteLine("La desviacion estandar es de: " + desviacionEst);
            Console.WriteLine("La parsona con la edad mas cercana al promedio es: " + nombres[t]);
            Console.ReadLine();
        }
    }
}
