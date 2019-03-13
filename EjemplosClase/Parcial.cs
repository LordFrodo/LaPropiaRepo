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
        for(int i = 0; i < notas.Length; i++)
        {
            if (notas[i] <= 3)
            {
                salida++;
            }
        }


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

        int indice = 0;
        for (int i = 0; i < notas.Length; i++) {
            int semaforo = 2;
            for (int j = 0; j < notas.Length; j++)
            {

                if ( notas[i]<notas[j])
                {
                    semaforo = 0;
                }
            }
            if (semaforo == 0)
            {
                salida[indice] = nombres[i];
                indice+=1;
                
            }
            Array.Resize(ref salida, 5);
        }

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
        int contador = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] < 3)
            {
                contador++;
               // salida[i] = nombres[i];
            }
        }
        salida = new string[contador];

        int cont = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] < 3)
            {
                salida[cont] = nombres[i];
                cont++;
            }
        }


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



        //- Arriba de esta línea va su código --------

        return salida;
        
    }

}

