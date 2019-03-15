using System;

class Cacorra
{

    string[] names;
    double[] data;

    public Cacorra(string[] _names, double[] _data)
    {
        data = new double[_data.Length];
        _data.CopyTo(data, 0);
        names = new string[_names.Length];
        _names.CopyTo(names, 0);
    }


    public int PrimerPunto()
    {
        string[] nombres = new string[names.Length];
        names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length];
        data.CopyTo(notas, 0);
        int salida = 0;

        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] <= 3)
            {
                salida++;
            }
        }


        //- Arriba de esta línea va su código --------

        return salida;
    }

    public string[] SegundoPunto()
    {
        string[] nombres = new string[names.Length];
        names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length];
        data.CopyTo(notas, 0);
        string[] salida = new string[5];

        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        string temp;
        double temp1;
        for (int i = 0; i < notas.Length; i++)
        {
            for (int j = 0; j < notas.Length - 1 ; j++)
            {
                if(notas[j] > notas[j + 1]) {

                    //ordeno notas 
                    temp1 = notas[j + 1];
                    notas[j + 1] = notas[j];
                    notas[j] = temp1;
                    
                    //ordeno nombres
                    temp = nombres[j + 1];
                    nombres[j + 1] = nombres[j];
                    nombres[j] = temp;


                }

            }
        }

        for (int i = 0; i < salida.Length; i++)
        {
            salida[i] = nombres[i];
        }

        //- Arriba de esta línea va su código --------

        return salida;
    }

    public string[] TercerPunto()
    {
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

        int papa = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] < 3)
            {
                salida[papa] = nombres[i];
                papa++;
            }
        }


        //- Arriba de esta línea va su código --------

        return salida;
    }

    public string[] CuartoPunto()
    {
        string[] nombres = new string[names.Length];
        names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length];
        data.CopyTo(notas, 0);
        string[] salida = new string[0];

        //--------------------------------------------
        //- Abajo de esta línea va su código ---------

        string temp;
        bool semaforo = false;
        int tama;
        for (int i = 0; i < nombres.Length; i++)
        {
            temp = nombres[i];
            semaforo = false;
            for (int j = 0; j < temp.Length; j++)
            {
                if(temp[j].CompareTo('A') == 0){
                    semaforo = true;
                }
            }
            
            if (semaforo){
                Array.Resize(ref salida, salida.Length + 1);
                tama = salida.Length;
                salida[tama - 1] = nombres[i];
            }
        }

        //- Arriba de esta línea va su código --------

        return salida;

    }
 
    public static void Main ()
    {
        string  [] nom = new string[10] { "A1", "B2", "c3", "A4", "c5" ,"B6","c7","A8","c9","A10"};
        double  [] not = new double[10] { 3.0, 2.9, 4.5, 1.8, 3.6, 2.2, 1.6, 4.5, 3.2, 4.0 };

        Cacorra c = new Cacorra(nom,not);

        string [] s1 = c.CuartoPunto();

        for (int i = 0; i < s1.Length; i++)
        {
            Console.WriteLine(s1[i]);
        }


        Console.ReadLine();
    }
}
