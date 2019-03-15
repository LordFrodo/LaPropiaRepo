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
            string frase = "Perro que ladra no muerde,pero perro que muerde no ladra Muerd";
            String palabra = "Muerde";
            frase = frase.ToUpper();
            palabra = palabra.ToUpper();
            int contador = 0;
            for (int i = 0; i < frase.Length - 5;i++)
            {
                if (frase[i + 0] == 'M')
                {
                    if (frase[i + 1] == 'U')
                    {
                        if(frase[i+2]== 'E'){
                            if (frase[i + 3] == 'R')
                            {
                                if (frase[i + 4] == 'D')
                                {
                                    if (frase[i + 5] == 'E')
                                    {
                                        contador++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Contador= " + contador);


        }
    }
}
