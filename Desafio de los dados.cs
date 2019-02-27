using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado = 0, total = 0;
            int dado2 = 0, vidas = 3;
            int turnos = 0;
            string continuar = "s";

            while (continuar == "s" && vidas >0)
            {
                dado = aleatorio.Next(1, 7);
                Console.WriteLine("Dado: " + dado);
                turnos += 1;

                if (turnos % 2 == 0)
                {
                    vidas -= 1;
                    Console.WriteLine("Perdiste una vida " + vidas + " vidas");

                }

                if (vidas == 0)
                {
                    Console.WriteLine("Perdiste");
                    break;
                }

                if (turnos % 3 == 0)
                {
                    
                    dado2 = aleatorio.Next(1, 7);
                    Console.WriteLine("Dado2: " + dado2);

                    if (dado == dado2)
                    {
                        vidas += 1;
                    }
                    
                }
                        total += dado;
                Console.WriteLine("Total: " + total);
                Console.WriteLine("Vidas: " + vidas);
                Console.WriteLine("Continuas?...");
                if (Console.ReadLine() != "s") break;


            }




        }
    }
}

