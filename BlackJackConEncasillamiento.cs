using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_con_encasillamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int total = 0;
            int carta1 = 0;
            int carta2 = 0;
            int jugadores = 0;
            int indice = 0;
            int max = 0;

            Console.Write("Ingresar la cantidad de judadores ");

            int n = int.Parse(Console.ReadLine());

            int [] jugador = new int[n];
            int [] puntaje = new int[n];

            for (int i = 0; i < n; i += 1)
            {
                jugadores += 1;
                jugador[i] = jugadores;
                Console.WriteLine("Jugador " + jugador[i]);
                

                carta1 = aleatorio.Next(1, 11);
                carta2 = aleatorio.Next(1, 11);

                total = carta1 + carta2;

                Console.WriteLine("primera carta: " + carta1);
                Console.WriteLine("segunda carta: " + carta2);
                Console.WriteLine("Puntos: " + total);

                Console.WriteLine("Desea continuar? (s/n)");
                string respuesta = Console.ReadLine();

                while(respuesta == "s" && total < 21)
                {
                    carta1 = aleatorio.Next(1, 11);
                    total += carta1;
                    puntaje[i] = total;

                    Console.WriteLine("carta: " + carta1);
                    Console.WriteLine("Puntos: " + total);

                    if (total < 21)
                    {
                        Console.WriteLine("Desea continuar? (s/n)");
                        respuesta = Console.ReadLine();
                        
                    }
                    if (total == 21)
                    {
                        Console.WriteLine("BlackJack");

                    }
                    else if (total > 21)
                    {
                        Console.WriteLine("Eliminado");
                        puntaje[i] = 0;
                    }
                    
                }
                if (puntaje[i] > max)
                {
                    max = puntaje[i];
                    indice = i;
                }
            }

      
                Console.WriteLine("Gracias por JUGAR");
            Console.Write("el ganador es " + jugador[indice] + " con " + max);
        }
    }
}
