using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Parcial {

    string[] names;
    double[] data;
    public static int codigo = 0; // 0 Primer simulacro. 1 Segundo simulacro

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
      

        for (int i = 0; i < notas.Length; i++)
        {
           

            if(notas[i] <= 3.0)
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
        for (int i = 0; i < notas.Length; i += 1)
        {

            Console.WriteLine("Nombre " + nombres[i]);
            Console.WriteLine("Puntaje " +notas[i]);
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
        for (int i = 0; i < notas.Length; i += 1)
        {

            Console.WriteLine("Nombre " + nombres[i]);
            Console.WriteLine("Puntaje " + notas[i]);
        }
        int cantidad = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] <= 3.0)
            {
                cantidad++;               
            }
        }
        salida = new string [cantidad];
        for (int i = 0; i < cantidad; i++)
        {
            salida[i]= nombres[i];
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
        char letra = 'A';
        int tamaño = 0;
        for (int i = 0; i < nombres.Length; i++)
        {
            string nombre = nombres[i];
            
            for (int j = 0; j < nombres[i].Length; j++)
            {
                char letraanalizada = nombre[j];
                if (letra == letraanalizada)
                {
                    tamaño++;
                    break;
                }
            }
        }
        salida = new string[tamaño];

        int contador = 0;
        for (int i = 0; i < nombres.Length; i++)
        {
            string nombre = nombres[i];
            for (int j = 0; j < nombres[i].Length; j++)
            {
                char letraanalizada = nombre[j];
                if (letra == letraanalizada)
                {
                    salida[contador] = nombres[i];
                    contador++;
                    break;
                }
            }
        }


        //- Arriba de esta línea va su código --------
        return salida;
    }
}


