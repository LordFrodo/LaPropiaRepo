using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Parcial {

    string[] names;
    double[] data;

    public Parcial(string[] _names, double[] _data) {
        data = new double[_data.Length];
        _data.CopyTo(data, 0);
        names = new string[_names.Length];
        _names.CopyTo(names, 0);
    }


    public int PrimerPunto() {
        string[] nombres = new string[names.Length];
        names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length];
        data.CopyTo(notas, 0);
        int salida = 0 ;

        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
 


        //- Arriba de esta línea va su código --------

        return salida;
    }

    public string[] SegundoPunto() {
        string[] nombres = new string[names.Length];
        names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length];
        data.CopyTo(notas, 0);
        string[] salida = new string[5];

        //--------------------------------------------
        //- Abajo de esta línea va su código ---------



        //- Arriba de esta línea va su código --------

        return salida;
    }

    public string[] TercerPunto() {
        string[] nombres = new string[names.Length];
        names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length];
        data.CopyTo(notas, 0);
        string[] salida = new string[0];

        //--------------------------------------------
        //- Abajo de esta línea va su código ---------



        //- Arriba de esta línea va su código --------

        return salida;
    }

    public string[] CuartoPunto() {
        string[] nombres = new string[names.Length];
        names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length];
        data.CopyTo(notas, 0);
        string[] salida = new string[0];

        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        string temp;
        bool semaforo = false;
        int tamaño = 0, contador = 0;
        for (int i = 0; i < nombres.Length; i++)
        {
            temp = nombres[i];
            semaforo = false;
            for (int j = 0; j < temp.Length; j++)
            {
                char letra = temp[j];
                if (letra=='A')
                {
                    semaforo = true;;

                }
            }
            if (semaforo) contador++;
        }
        salida = new string[contador];
        for (int i = 0; i < nombres.Length; i++)
        {
            temp = nombres[i];
            semaforo = false;

            for (int j = 0; j < temp.Length; j++)
            {
                char letra = temp[j];
                if (letra == 'A')
                {
                    semaforo = true; ;
                }
            }
            if (semaforo)
            {
                salida[tamaño] = nombres[i];
                tamaño++;
            }


        }




        //- Arriba de esta línea va su código --------

        return salida;
    }
}

