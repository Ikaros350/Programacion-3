using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_de_tarifa
{
    class Program
    {
        static void Main(string[] args)
        {
            double SMMLV = 828116;
            double Salario = double.Parse(Console.ReadLine());
            double A = 2 * SMMLV;
            double B = 4 * SMMLV;

            if (Salario < (2 * SMMLV))
            {
                Console.WriteLine("Se aplica la tarifa A");
            }
            if ( A <= Salario && Salario <= B & Salario != B)
            {
                Console.WriteLine("Se aplica la tarifa B");
            }
            else if (Salario >= B)
            {
                Console.WriteLine("Se aplica la tarifa C");
            }
        }
    }
}
