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
            //int[] A = { 1, 3, 5, 7, 8, 12, 20 };
            //int x = 8;
            //int i = Busqueda.Lineal(A, x);
            //int i = Busqueda.Binario(A, 0, A.Length, x);
            //if (i != -1)
            //{
            //    Console.WriteLine("El valor {0} esta en la posicion {1}", x, i);
            //}
            //else
            //{
            //    Console.WriteLine("Numero no encotrado");
            //}

            

            int[] A = Ordenamiento.Generar(1000);
            Stopwatch stopwatchBurbuja = new Stopwatch();
            Stopwatch stopwatchBaraja = new Stopwatch();

            //stopwatch.Start();
            //Console.WriteLine("Matriz original");
            //Ordenamiento.Imprimir(A);

            // Midiendo tiempo de ejecucion
            stopwatchBurbuja.Start();
            Ordenamiento.Burbuja(A);
            stopwatchBurbuja.Stop();
            Console.WriteLine("\nTiempo de ejecucion del ordenamiento: {0} [ms]", stopwatchBurbuja.ElapsedMilliseconds);


            stopwatchBaraja.Start();
            Ordenamiento.Baraja(A);
            stopwatchBaraja.Stop();
            Console.WriteLine("\nTiempo de ejecucion del ordenamiento: {0} [ms]", stopwatchBaraja.ElapsedMilliseconds);

            //Console.WriteLine("\nMatriz ordenada");
            //Ordenamiento.Imprimir(A);

            //Console.WriteLine("\nTiempo de ejecucion del ordenamiento: {0} [ms]", stopwatch.ElapsedMilliseconds);

            Console.ReadLine();
        }
    }
}
