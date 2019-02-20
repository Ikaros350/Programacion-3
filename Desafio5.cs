using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al Blackjack piraaaaaaaaaaaaaata");

            Random aleatorio = new Random();

            int Puntos = 0;
            int puntosI = 0;
            int carta = 0;
            int carta2 = 0;
            int cartarobada = 0;
            string respuesta = "s";

          
                carta = aleatorio.Next(1, 11);
                carta2 = aleatorio.Next(1, 11);

                puntosI = carta + carta2;

                Console.WriteLine("primera carta: "+carta);
                Console.WriteLine("segunda carta: "+carta2);
                Console.WriteLine("Puntos:"+ puntosI);

            Console.WriteLine("Desea continuar: ");
            respuesta = Console.ReadLine();
            if (respuesta == "s")
            {
                while (Puntos < 22 && respuesta == "s")
                {
                    Console.WriteLine("primera carta: " + carta);
                    Console.WriteLine("segunda carta: " + carta2);
                    cartarobada = aleatorio.Next(1, 11);
                    Console.WriteLine("Carta robada " + cartarobada);
                    Puntos = puntosI + cartarobada;

                    Console.WriteLine("Puntos " + Puntos);

                    if (Puntos == 21)
                    {
                        Console.WriteLine("Blackjack");
                    }
                    if (Puntos > 21)
                    {

                        Console.WriteLine("vuelas con: " +Puntos);
                        
                        Console.WriteLine("No puedes jugar mas");
                    }
                   
                    else 
                    {
                        puntosI += cartarobada;
                        
                        Console.WriteLine("Desea continuar: ");
                        respuesta = Console.ReadLine();

                    }
                }

            }
            
            Console.WriteLine("Fin del juego amigo");
            Console.WriteLine("Tu puntaje final fue..." + Puntos);

        }
    }
}
