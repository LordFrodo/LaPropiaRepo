using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Parcial {

    string[] names;
    double[] data;
    public static int codigo = 1; // 0 Primer simulacro. 1 Segundo simulacro

    public Parcial(string[] _names, double[] _data) {
        data = new double[_data.Length];
        _data.CopyTo(data, 0);
        names = new string[_names.Length];
        _names.CopyTo(names, 0);
    }


    public int PrimerPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        int salida = 0 ;
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        double promedio = 0, promediotemp = 0;
        for(int i = 0; i < notas.Length; i++)
        {
            promediotemp += notas[i];
        }
        promedio = promediotemp / notas.Length;
        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] < promedio)
            {
                salida++;
            }
        }


        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] SegundoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[5];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        double promedio = 0, promediotemp = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            promediotemp += notas[i];
        }
        promedio = promediotemp / notas.Length;
        double[] temp = new double[notas.Length];
        for (int i = 0; i < notas.Length; i++)
        {
            temp[i]=Math.Abs(notas[i]-promedio);
        }
        for (int i = 0; i < temp.Length; i++)
        {

            for (int j = 0; j < temp.Length-1; j++)
            {
                double temp1 = 0;
                string temptxt = "";
                if (temp[j] > temp[j+1])
                {
                    temp1 = temp[j+1];
                    temp[j+1] = temp[j];
                    temp[j] = temp1;

                    temptxt = nombres[j+1];
                    nombres[j+1] = nombres[j];
                    nombres[j] = temptxt;
                }
            }
        }
        for(int i = 0; i < salida.Length; i++)
        {
            salida[i] = nombres[i];
        }

        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] TercerPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[0];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        double promedio = 0, promediotemp = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            promediotemp += notas[i];
        }
        promedio = promediotemp / notas.Length;
        //REVISAR GITHUB PARCIAL
        for(int i=0;i<notas.Length; i++)
        {

            for(int j = 1; j < notas.Length; j++)
            {
                double temp = 0;
                string temptxt = "";
                if (notas[j] < notas[i])
                {
                    temp = notas[i];
                    notas[i] = notas[j];
                    notas[j] = temp;
                    temptxt = nombres[i];
                    nombres[i] = nombres[j];
                    nombres[j] = temptxt;
                }
            }
        }
        int contador = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] >= promedio)
            {
                contador++;
            }
        }
        salida = new string[contador];
        int contador2 = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] >= promedio)
            {
                salida[contador2] = nombres[i] ;
                contador2++;
            }
        }
        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] CuartoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[0];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        string temp = "";
        bool semaforo = false;
        int contador = 0;
        for(int i = 0; i < nombres.Length; i++)
        {
            temp = nombres[i];
            semaforo = false;
            char letra=temp[0];
            if (letra == 'A' || letra == 'E' || letra == 'I' || letra == 'O' || letra == 'U')
            {
                semaforo = true;
            }
            
            if (semaforo)
            {
                contador++;
            }
        }
        salida = new string[contador];
        int posicion = 0;
        for (int i = 0; i < nombres.Length; i++)
        {
            temp = nombres[i];
            semaforo = false;
            char letra = temp[0];
            if (letra == 'A' || letra == 'E' || letra == 'I' || letra == 'O' || letra == 'U')
            {
                semaforo = true;
            }
            
            if (semaforo)
            {
                salida[posicion] = nombres[i];
                posicion++;
            }
        }


            //- Arriba de esta línea va su código --------
            return salida;
    }
}


