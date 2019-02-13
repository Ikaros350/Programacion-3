using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_de_Programacion
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta = "s";
            int contador = 0;
            int maximo = 0;
            int minimo = 100;
            string nombremax = "aaaa";
            string nombremin = "aaaaa";
            double total = 0;

            while (respuesta == "s"){
                string nombre = Console.ReadLine();
                Console.WriteLine("Edad");
                int edad = int.Parse(Console.ReadLine());
                if (edad > maximo)
                {
                    maximo = edad;
                    nombremax = nombre;
                }
                if (edad < minimo)
                {
                    minimo = edad;
                    nombremin = nombre;
                }

                total += edad;
                
                contador += 1;
                Console.WriteLine("Desea ingresar otro dato");
                respuesta = Console.ReadLine();

            }
            double promedio = total / contador;
            Console.Write("Promedio: " + promedio);
            
            Console.Write("Edad Maxima" + maximo);
            Console.WriteLine("Nombre de la persona" + nombremax);

            Console.Write("Edad Minima" + minimo);
            Console.WriteLine("Nombre de la persona" + nombremin);


        }
    }
}
