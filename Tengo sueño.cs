using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar la cantidad de personas");

            int n = int.Parse(Console.ReadLine());
            string[] nombre = new string[n];
            int[] edad = new int[n];
            int max = 0;
            int min = 10000;
            int indice = 0;
            int indice2 = 0;
            double total = 0;
            double promedio = 0;
            double diferencia = 0;
            double desviacion = 0;
            

            for (int i = 0; i < n; i += 1)
            {
                nombre[i] = Console.ReadLine();
                edad [i] = int.Parse(Console.ReadLine());
                total += edad[i];

                
                if (edad[i] > max)
                {
                    max = edad[1];
                    indice = i;
                }
                if (edad[i] < min)
                {
                    min = edad[1];
                    indice2 = i;
                }               
            }
            promedio = total / n;
            double cerca = 100;
            string cercan = "";

            for (int i = 0; i < n; i += 1)
            {
                double pr = promedio - edad[i];
                if (Math.Abs(pr) < cerca)
                {
                    cerca = pr;
                    cercan = nombre[i];
                }
            }

             for (int i = 0; i < n; i += 1)
            {
                diferencia += Math.Pow(promedio - edad[i],2);
            }
            desviacion = Math.Sqrt(diferencia / n);

            Console.Write("edad mayor" + edad[indice] + " y es " + nombre [indice]);
            Console.Write("edad menor" + edad[indice2] + " y es " + nombre[indice2]);
            Console.Write("El promedio es" + promedio + "y es " + cercan);
            Console.Write("Desviacion" + desviacion);
        }
    }
}

