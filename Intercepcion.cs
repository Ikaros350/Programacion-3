using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_tarea_larga_de_gio
{
    class Program
    {
        static void Main(string[] args)
        {



            int[] U = { 0, 0, 0, 1, 2, 2, 3, 4, 5, 6, 6, 6, 6, 6, 7, 8, 9, 10, 11, 12, 12, 12, 12, 13, 14, 15, 16, 17, 18, 18, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            int[] A = { 0, 0, 3, 6, 6, 6, 9, 12, 12, 12, 15, 18, 18 };
            int[] B = { 0, 0, 2, 2, 4, 6, 6, 6, 8, 10, 12, 12, 14, 16, 18, 18 };

            int[] interseccion = new int[4];
            Console.WriteLine("Intercepto");
            int numero = 31, cosa = 0;
            for (int i = 0; i < A.Length - 1; i += 1)
            {
                for (int j = 0; j < B.Length - 1; j += 1)
                {
                    if (A[i] == numero)
                    {
                        break;
                    }
                    else if (A[i] == B[j])
                    {
                        numero = A[i];
                        Console.WriteLine(A[i]);
                        interseccion[cosa] = A[i];
                        cosa += 1;
                        break;
                    }
                }
            }
        }
    }
}
