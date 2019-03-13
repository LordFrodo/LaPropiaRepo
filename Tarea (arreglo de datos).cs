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
            //Definicion de variables
            int[] U = new int[31];
            int[] A = new int[13] { 0, 3, 0, 6, 9, 6, 6, 12, 15, 12, 18, 12, 18 };
            int[] B = new int[16] { 4, 0, 2, 2, 0, 8, 6, 6, 10, 8, 12, 18, 14, 12, 16, 18 };
            for (int i = 0; i < 31; i++)
            {
                U[i] = i;
                //Console.Write(U[i] + " ");
            }
            int[] interseccion = new int[4] { -1, -1, -1, -1 };
            int[] union = new int[A.Length + B.Length];
            int[] complemento = new int[31];
            int semaforo = 0, indice = 0;
            for (int i = 0; i <union.Length; i++)
            {
                union[i] = -1;
            }
            for (int i=0; i < complemento.Length; i++)
            {
                complemento[i] = -1;
            }
            //interseccion
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if (A[i] == B[j])
                    {

                        semaforo = 0;
                        for (int k = 0; k < interseccion.Length; k++)
                        {

                            if (interseccion[k] == B[j])
                            {
                                semaforo = 1;
                            }
                        }

                        if (semaforo == 0)
                        {
                            interseccion[indice] = B[j];
                            indice++;
                        }
                    }
                }
            }
            Console.WriteLine("Interseccion");
            for (int i = 0; i < interseccion.Length; i++)
            {
                Console.Write(interseccion[i] + " ");
            }
            Console.Write("\n");
            //Union
            indice = 0;
            for (int i = 0; i < A.Length; i++)
            {
                semaforo = 0;
                for (int k = 0; k < union.Length; k++)
                {
                    if (A[i] == union[k])
                    {
                        semaforo = 1;
                    }
                }
                    if (semaforo == 0)
                    {
                        union[indice] = A[i];
                        indice++;
                    }
            }
            for (int i = 0; i < B.Length; i++)
            {
                semaforo = 0;
                for (int k = 0; k < union.Length; k++)
                {
                    if (B[i] == union[k])
                    {
                        semaforo = 1;
                    }
                }
                    if (semaforo == 0)
                    {
                        union[indice] = B[i];
                        indice++;
                    }
                
            }
            Array.Resize(ref union, indice);
            Console.WriteLine("Union");
            for (int i = 0; i < union.Length; i++)
            {
                Console.Write(union[i] + " ");
            }

            Console.Write("\n");

            //complento

            indice = 0;
            for (int i = 0; i < U.Length; i++)
            {
                semaforo = 0;
                for (int k = 0; k < union.Length; k++)
                {
                    if (union[k] == U[i])
                    {
                        semaforo = 1;
                    }

                }
                if (semaforo == 0)
                {
                    complemento[indice] = U[i];
                    indice++;
                }

            }
            Array.Resize(ref complemento, indice);
            Console.WriteLine("Complemento");
            for (int i = 0; i < complemento.Length; i++)
            {
                Console.Write(complemento[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
