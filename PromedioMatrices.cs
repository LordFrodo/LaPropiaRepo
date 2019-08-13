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
            Console.WriteLine("Ingrese el tamaño de la matriz (fila, columna)");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n,m];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Asigne valor de la posicion " + i+", 0");
                matriz[i, 0] = int.Parse(Console.ReadLine());
                for(int j = 0; j < m; j++)
                {
                    Console.WriteLine("Asigne valor de la posicion " + i + "," + j);
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Promedio(matriz);
            Console.ReadKey();

        }
        public static float[] Promedio(int[,] matriz)
        {
            int tamano = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                tamano++; ;
            }
            float[] promedio = new float[tamano];
            for(int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    promedio[i] += (matriz[i, j]);
                }
            }
            for (int i = 0; i < promedio.Length; i++)
            {
                promedio[i] = promedio[i] / matriz.GetLength(0);
                Console.WriteLine(promedio[i]);
                
            }
            return promedio;
        }
        

    }
}
