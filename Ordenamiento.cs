using System;

namespace OrednamientoBusquedaG2_2024_1
{
    internal class Ordenamiento
    {
        internal static int[] Generar(int N)
        {
            Random random = new Random();
            int [] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = (int)(random.NextDouble() * 10000);
            }
            return A;
        }
        internal static void Imprimir(int[] A)
        {
            foreach (int a in A)
            {
                Console.Write(" {0} ", a);
            }
        }
        internal static void Burbuja(int [] A)
        {
            int N = A.Length;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N - 1; j++)
                {
                    if (A[j] > A[j+1])
                    {
                        int Aux = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = Aux;
                    }
                }
            }
        }
        internal static void Baraja(int[] A)
        {
            int N = A.Length;
            for (int i = 1; i < N; i++)
            {
                int min = A[i];
                int j = i - 1;
                while (j >= 0 && A[j] > min)
                {
                    A[j + 1] = A[j];
                    j = j - 1;
                }
                A[j + 1] = min;
            }
        }
        internal static void Quicksort(int[] A)
        {

        }
    }
}
