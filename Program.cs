using System;
using System.Diagnostics;
using System.Threading;

namespace OrednamientoBusquedaG2_2024_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] A = { 5, 7, 1, 3, 12, 20, 8 };
            int[] A = Ordenamiento.Generar(100000);
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            //Console.WriteLine("Matriz original");
            //Ordenamiento.Imprimir(A);
            
            // Midiendo tiempo de ejecucion
            //stopwatch.Start();
            Ordenamiento.Burbuja(A);
            stopwatch.Stop();
            
            //Console.WriteLine("\nMatriz ordenada");
            //Ordenamiento.Imprimir(A);

            Console.WriteLine("\nTiempo de ejecucion del ordenamiento: {0} [ms]", stopwatch.ElapsedMilliseconds);

            Console.ReadLine();
        }
    }
}
