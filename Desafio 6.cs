using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado = 0;
            int total = 0;
            int contador = 0;
            int Ccontador2 = 0;
            string continuar = "s";


            dado = aleatorio.Next(1, 13);
            total += dado;
            Console.WriteLine("Dado " + dado);
            Console.WriteLine("total " + total);
            continuar = Console.ReadLine();
            if (dado == 10)
            {
                contador = contador + 1;
            }

            if (continuar == "s")
            {

                dado = aleatorio.Next(1, 13);
                total += dado;
                if (dado == 10)
                {
                    contador = contador + 1;
                }
                if (dado != 12 && dado != 10)
                {
                    contador = 0;
                }
                if (dado == 12 && contador >= 1)
                {
                    Console.WriteLine("dado " + dado);
                    Console.WriteLine("total " + total);

                    Console.WriteLine(" gano ");
                    Ccontador2 = Ccontador2 + 2;


                }
                if (Ccontador2 < 2)
                {
                    Console.WriteLine("dado " + dado);
                    Console.WriteLine("total " + total);
                    Console.WriteLine("sigues?...  ");
                    continuar = Console.ReadLine();
                    if (continuar == "s")
                    {

                        dado = aleatorio.Next(1, 13);
                        total += dado;
                        if (dado == 10)
                        {
                            contador = contador + 1;
                        }
                        if (dado != 12 && dado != 10)
                        {
                            contador = 0;
                        }
                        if (dado == 12 && contador >= 1)
                        {
                            Console.WriteLine(" gano ");
                            Ccontador2 = Ccontador2 + 2;
                        }
                        if (Ccontador2 < 2)
                        {
                            Console.WriteLine("dado " + dado);
                            Console.WriteLine("total " + total);
                            Console.WriteLine("sigues?...  ");
                            continuar = Console.ReadLine();
                        }
                    }
                }
            }

            dado = 2;

            while (continuar == "s" && total < 100 && dado % 2 == 0 && Ccontador2 < 2)
            {

                dado = aleatorio.Next(1, 11);
                Console.WriteLine("dado " + dado);
                if (dado == 10)
                {
                    contador = contador + 1;
                }
                if (dado != 12 && dado != 10)
                {
                    contador = 0;
                }
                if (dado == 12 && contador >= 1)
                {
                    total += dado;
                    Console.WriteLine("  gano por suerte");
                    Ccontador2 = Ccontador2 + 2;
                }
                if (dado % 2 != 0)
                {
                    total += dado;
                    Console.WriteLine("perdio");
                }
                if (total >= 100)
                {
                    Console.WriteLine("gano");
                    total += dado;
                }
                if (dado % 2 == 0 && Ccontador2 < 2)
                {
                    total += dado;
                    Console.WriteLine("total " + total);
                    if (total < 100)
                    {
                        Console.WriteLine("le sigue ?   ");
                        continuar = Console.ReadLine();
                    }
                }
            }
            Console.WriteLine("se acabo");
            Console.WriteLine("total " + total);
        }
        
    }
}
