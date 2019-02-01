using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salario Independiente o dependiente y cuanto es");

            double Salario = double.Parse(Console.ReadLine());

            double Contrato = double.Parse(Console.ReadLine());

            double Base = (40.0 / 100) * Salario;
            if (Base < 828116.00)
            {
                Base = 828116.00;
            }
            

            double riesgo = double.Parse(Console.ReadLine());

            double Arl = 0;

            double Eps = 0;

            double Pension = 0;

            double Prima = 0;


            // double Dp = 1;
            //double In = 0;

            if (Contrato == 1)
            {
                Console.WriteLine("Independiente");

                Pension = (16 / 100 * Base);
                Eps = (12.5 / 100 * Base);

                if (riesgo == 1)
                {
                    Arl = 0.522 / 100 * Base;
                }
                if (riesgo == 2)
                {
                    Arl = 1.044 / 100 * Base;
                }
                if (riesgo == 3)
                {
                    Arl = 2.436 / 100 * Base;
                }
                if (riesgo == 4)
                {
                    Arl = 4.350 / 100 * Base;
                }
                else if (riesgo < 5)
                {
                    Arl = 6.960 / 100 * Base;
                }
            }
            else
            {
                Console.WriteLine("dependiente");

                Pension = (16.0 / 100) * Base;
                Eps =(12.5/100) * Base;
                Prima = Salario;

            }


                double SalarioReal = Salario - Eps - Pension - Arl;
            double Anual =(Salario * 12);

            Console.WriteLine("Salario mensual" + SalarioReal);
            Console.WriteLine("Salario Anual" + Anual + Prima);

        }
    }
}
