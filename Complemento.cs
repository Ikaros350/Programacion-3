using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int[] U = { 0, 0, 0, 1, 2, 2, 3, 4, 5, 6, 6, 6, 6, 6, 7, 8, 9, 10, 11, 12, 12, 12, 12, 13, 14, 15, 16, 17, 18, 18, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
        int[] A = { 0, 0, 3, 6, 6, 6, 9, 12, 12, 12, 15, 18, 18 };
        int[] B = { 0, 0, 2, 2, 4, 6, 6, 8, 10, 12, 12, 14, 16, 18, 18 };
        int[] Complemento = new int[30];
        Console.WriteLine("Complementos");
        int cont = 0, cosa = 0;
        bool T = true;
        for (int i = 0; i < U.Length; i += 1)
        {
            T = true;
            for (int j = 0; j < A.Length - 1; j += 1)
            {
                if (U[i] == A[j] || U[i] == B[j])
                {
                    T = false;
                }
                cont = +1;
            }
            for (int j = cont; j < B.Length - 1; j += 1)
            {
                if (U[i] == B[j])
                {
                    T = false;
                }
            }
            if (T == true)
            {
                Console.WriteLine(U[i]);
                Complemento[cosa] = U[i];
                cosa += 1;
            }
        }
    }
}

