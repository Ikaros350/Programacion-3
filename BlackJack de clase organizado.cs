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
            int tem = 0;
            string tem2 = "";


            Console.Write("Ingresar la cantidad de judadores ");

            int n = int.Parse(Console.ReadLine());

            int[] jugador = new int[n];
            int[] puntaje = new int[n];
            string[] nombre = new string[n];

            for (int i = 0; i < n; i += 1)
            {
                jugadores += 1;
                jugador[i] = jugadores;
                Console.WriteLine("\n\nJugador " + jugador[i]);
                Console.WriteLine("Nombre del jugador ");
                nombre[i] = Console.ReadLine();

                carta1 = aleatorio.Next(1, 11);
                carta2 = aleatorio.Next(1, 11);

                total = carta1 + carta2;

                Console.WriteLine("primera carta: " + carta1);
                Console.WriteLine("segunda carta: " + carta2);
                Console.WriteLine("Puntos: " + total);

                Console.WriteLine("Desea continuar? (s/n)");
                string respuesta = Console.ReadLine();

                while (respuesta == "s")
                {
                    carta1 = aleatorio.Next(1, 11);
                    total += carta1;

                    Console.WriteLine("carta: " + carta1);
                    Console.WriteLine("Puntos: " + total);

                    if (total < 21)
                    {
                        Console.WriteLine("Desea continuar? (s/n)");
                        respuesta = Console.ReadLine();

                    }
                    else if (total == 21)
                    {
                        Console.WriteLine("BlackJack");

                    }
                    else
                    {
                        Console.WriteLine("Eliminado");
                        total = 0;
                        break;
                    }

                }//Fin del turno del jugador
                puntaje[i] = total;
                if (puntaje[i] > max)
                {
                    max = puntaje[i];
                    indice = i;
                }

            }
            for (int j = 0; j < n - 1; j += 1)
            {
                for (int i = 0; i < n - 1; i += 1)
                {
                    if (puntaje[i] < puntaje[i + 1])
                    {
                        tem = puntaje[i];
                        puntaje[i] = puntaje[i + 1];
                        puntaje[i + 1] = tem;


                        tem2 = nombre[i];
                        nombre[i] = nombre[i + 1];
                        nombre[i + 1] = tem2;
                    }

                }

            }


            for (int i = 0; i < n; i += 1)
            {

                Console.WriteLine("Nombre " + nombre[i]);
                Console.WriteLine("Puntaje " + puntaje[i]);
            }

            Console.WriteLine("Gracias por JUGAR");
            Console.Write("el ganador es " + jugador[indice] + " con " + max);
        }
    }
}
