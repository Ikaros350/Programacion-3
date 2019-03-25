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
        double suma = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            suma += notas[i];
        }
        double promedio = suma / notas.Length;

        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] <= promedio)
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

        double suma = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            suma += notas[i];
        }
        double promedio = suma / notas.Length;

        double[] diferenciasPromedio = new double[notas.Length];

        for (int i = 0; i < notas.Length; i++)
        {
            diferenciasPromedio[i] = Math.Abs(promedio - notas[i]);
        }

        for (int i = 0; i < notas.Length; i++)
        {

            double menor = diferenciasPromedio[i];
            string menorN = nombres[i];

            for (int k = i; k < notas.Length; k++)
            {
                if (menor > diferenciasPromedio[k])
                {

                    double pasar = menor;
                    menor = diferenciasPromedio[k];
                    diferenciasPromedio[k] = pasar;

                    string pasarN = menorN;
                    menorN = nombres[k];
                    nombres[k] = pasarN;
                }
            }

            diferenciasPromedio[i] = menor;
            nombres[i] = menorN;
            Console.WriteLine("\nLos alumnos ordenados son: " + nombres[i]);
            Console.WriteLine("\nLas notas ordenadas son: " + diferenciasPromedio[i]);
        }

        for (int i = 0; i < 5; i++)
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

        double suma = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            suma += notas[i];
        }
        double promedio = suma / notas.Length;

        int tamanoSalida = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] >= promedio)
            {
                tamanoSalida++;
            }
        }

        salida = new string[tamanoSalida];
        int count = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] >= promedio)
            {
                salida[count] = nombres[i];
                count++;
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

        int tamanoSalida = 0;
        char letra1 = 'A', letra2 = 'E', letra3 = 'I', letra4 = '0', letra5 = 'U';
        for (int i = 0; i < nombres.Length; i++)
        {
            string nombreAnalizar = nombres[i];
            char letraActual = nombreAnalizar[0];
            if (letra1 == letraActual || letra2 == letraActual || letra3 == letraActual || letra4 == letraActual || letra5 == letraActual)
            {
                tamanoSalida++;
            }
        }

        salida = new string[tamanoSalida];

        int count = 0;
        for (int i = 0; i < nombres.Length; i++)
        {
            string nombreAnalizar = nombres[i];
            char letraActual = nombreAnalizar[0];
            if (letra1 == letraActual || letra2 == letraActual || letra3 == letraActual || letra4 == letraActual || letra5 == letraActual)
            {
                salida[count] = nombres[i];
                count++;
            }
        }

        //- Arriba de esta línea va su código --------
        return salida;
    }
}


