using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();

            int dado1 = 0;
            int dado2 = 0;
            string continuar = "s";
            int total = dado1 + dado2;
            int dobles = 0;
            int suma = dado1 + dado2;
            double mayores = 0;
            int turno = 0;

            while (continuar == "s" && suma != 2 && total < 100 && dobles != 3)
            {
                dado1 = aleatorio.Next(5, 7);
                dado2 = aleatorio.Next(5, 7);
                total += dado1 + dado2;
                Console.WriteLine("dado1 " + dado1);
                Console.WriteLine("dado2 " + dado2);
                turno = 1;
                if (dado1 == dado2 && suma != 2)
                {
                    dobles += 1;
                }
                else
                {
                    dobles = 0;
                }
                if (dado1 == 1 && dado2 == 1)
                {
                    total = 0;
                    
                    Console.WriteLine("Elimindo papu");
               
                }
                if(total >= 100)
                {
                    total = 100;
                    Console.WriteLine("Total" + total);
                    Console.WriteLine("Ganaste el juego");
                }

                if (total < 100 && suma != 2)
                {

                    Console.WriteLine("Total " + total);
                    Console.WriteLine("Desea continuar s/n");
                    continuar = Console.ReadLine();
                    turno += 1;
                }
                if (dobles == 3)
                {
                    Console.WriteLine("Total" + total);
                    Console.WriteLine("Ganaste el juego");
                }
                if (suma < 6)
                {
                    mayores += 1;
                }
            }

            Console.WriteLine("dobles " + dobles);
            Console.WriteLine("Mayores " + (mayores/turno)*100);
            Console.WriteLine("Total " + total);
            Console.WriteLine("Gracias por participar");
        }
    }
}
