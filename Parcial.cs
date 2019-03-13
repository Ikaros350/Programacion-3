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
        double tem = 0;
        string tem2 = "";
        for (int j = 0; j < notas.Length - 1; j += 1)
        {
            for (int i = 0; i < notas.Length - 1; i += 1)
            {
                if (notas[i] > notas[i + 1])
                {
                    tem = notas[i];
                    notas[i] = notas[i + 1];
                    notas[i + 1] = tem;


                    tem2 = nombres[i];
                    nombres[i] = nombres[i + 1];
                    nombres[i + 1] = tem2;
                }

            }

        }

        for (int i =0; i < salida.Length; i++)
        {
                salida[i] = nombres[i];
                Console.WriteLine("Nombre " + nombres[i]);
                Console.WriteLine("Nota " + notas[i]);
            
        }
        Console.WriteLine("\n " );


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
       

        double tem = 0;
        string tem2 = "";
        for (int j = 0; j < notas.Length - 1; j += 1)
        {
            for (int i = 0; i < notas.Length - 1; i += 1)
            {
                if (notas[i] > notas[i + 1])
                {
                    tem = notas[i];
                    notas[i] = notas[i + 1];
                    notas[i + 1] = tem;


                    tem2 = nombres[i];
                    nombres[i] = nombres[i + 1];
                    nombres[i + 1] = tem2;
                }

            }

        }
        int contadorN = 0;
        for (int i =0; i < notas.Length; i++)
        {
            if (notas[i] < 3.0)
            {
                contadorN += 1;
            }
        }

        salida = new string[contadorN];

        for (int j = 0; j < contadorN; j++)
        {

            for (int i = j; i < notas.Length; i++)
            {
                if ( notas[i] <= 3.0)
                {
                    salida[j] = nombres[i];
                    break;
                }
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

