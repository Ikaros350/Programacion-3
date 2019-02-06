using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASE_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()); //votos 1
            int b = int.Parse(Console.ReadLine()); // votos 2
            int blancos = int.Parse(Console.ReadLine()); // votos en blanco
            int anulados = int.Parse(Console.ReadLine()); // votos anulados
            int n = int.Parse(Console.ReadLine()); // poblacion
            double p = double.Parse(Console.ReadLine()); // porcentaje de la poblacion mayor de edad
            int abstencion = ((int)(n * p)) - a - b - blancos - anulados;
            int votantes = a + b + anulados + blancos;


            bool C = anulados <= 0.3 * (a + b);
            bool D = blancos <= (a + b);
            bool E = abstencion < votantes;

            if ((C || D) && E)
            {
                Console.WriteLine("Las votaciones fueron exitosas");
                if (a > b)
                {
                    Console.WriteLine("el ganador es el partido 1 por: " + a);
                }
                else
                {
                    Console.WriteLine("el ganador es el partido b por" + b);
                }
            }
            else
            {
                Console.WriteLine("Las eleciones no son validas");

            }
        }
    }
}
