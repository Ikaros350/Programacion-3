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
            double B = 5 * SMMLV;
            double CuotaA = 3200; // Menos de 2 SMMLV
            double CuotaB = 12700; // Entre 2 o mas SMMLV hasta 5 SMMLV 
            double CuotaC = 33500; // 5 o mas SMMLV

            if (Salario < A)
            {
                Console.WriteLine("Se aplica la tarifa A");
                Console.WriteLine("La cuota de moderadora es: " + CuotaA);
            }
            if (A <= Salario && Salario <= B & Salario != B)
            {
                Console.WriteLine("Se aplica la tarifa B");
                Console.WriteLine("La cuota de moderadora es: " + CuotaB);
            }
            else if ( Salario >= B)
            {
                Console.WriteLine("Se aplica la tarifa C");
                Console.WriteLine("La cuota de moderadora es: " + CuotaC);
            } 
        }
    }
}