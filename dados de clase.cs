using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();

            int jugadores = 0;
            int n = 0;
            int total = 0;
            int contador = 0;
            int dado = 0;
            string jugar = "s";


            Console.Write("ingresar numero de jugadores ");
            n = int.Parse(Console.ReadLine());
            while (n > jugadores+1)
            {
                jugadores += 1;
                
                Console.Write("hola jugador " + jugadores );
                
                while (true)
                {
                    dado = aleatorio.Next(1, 7);
                    Console.WriteLine("Dado : " + dado);
                    total += dado;

                    if (dado == 1)
                    {
                        contador += 1;
                    }
                    else
                    {
                        contador = 0;
                    }

                    if (total >= 100)
                    {
                        Console.Write("Ganaste ");
                        break;
                    }

                    if (contador == 3)
                    {
                        Console.Write("perdiste ");
                        break;
                    }
                    if (total < 100)
                    {
                        Console.WriteLine("total"+total);
                        Console.WriteLine("desean continuar jugando?");
                        jugar = Console.ReadLine();
                        if (jugar != "s")
                        {
                            break;
                        }
                    }
                }
                Console.Write("Gracias por participar ");
                
                Console.Write("desean continuar jugando?");
                
                jugar = Console.ReadLine();
                if (jugar != "s")
                {
                    break;
                }
            }
        }
    }
}
