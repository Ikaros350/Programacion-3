using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Votos por el Partido 1");
            int a = int.Parse(Console.ReadLine()); //votos 1
            Console.WriteLine("Votos por el Partido 2");
            int b = int.Parse(Console.ReadLine()); // votos 2
            Console.WriteLine("Votos en blanco");
            int blancos = int.Parse(Console.ReadLine()); // votos en blanco
            Console.WriteLine("Votos anulados");
            int anulados = int.Parse(Console.ReadLine()); // votos anulados
            Console.WriteLine("Poblacion total");
            int n = int.Parse(Console.ReadLine()); // poblacion
            Console.WriteLine("Porcentaje de mayores de edad en la poblacion");
            double p = double.Parse(Console.ReadLine())/100; // porcentaje de la poblacion mayor de edad
            
            int votos = a + b + anulados + blancos;

                      
            int abstencion = ((int)(n * p)) - votos;
            

           

            bool A = votos > n; // Si el total de votos es superior al total de la población  
            bool B = (Math.Abs(a-b)) < 0.10 * votos; //  la diferencia de votos entre el partido 1 y 2 es menor al 10% de los votos totales 
            bool C = votos < 0.30 * n; // el número de votantes es inferior al 30% de la población

            if ((A || B) && C)
            {
                Console.WriteLine("Las elecciones deben ser repetidas, debido a que la informacion no es valida");
            }
            else
            {
                if (a > b)
                {
                    Console.WriteLine("el ganador es el partido 1 por: " + a);
                }
                else
                {
                    Console.WriteLine("el ganador es el partido 2 por: " + b);
                }
            }
            Console.WriteLine("abstenidos: " + abstencion);
            Console.WriteLine("votos en total: " + votos);

        }
    }
}
