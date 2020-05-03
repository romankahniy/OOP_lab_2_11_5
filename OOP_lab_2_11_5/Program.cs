using System;

namespace OOP_lab_2_11_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var random = new Random();

            int[,] array = new int[n, n];

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    array[i, j] = random.Next(-100, 100);
                }
            }

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    Console.Write("{0, 5} ", array[i, j]);
                }
                Console.WriteLine();
            }

            for (int i = 0; i < n; ++i)
            {
                array[i, n - i - 1] = 0;
            }

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    array[i, j] *= array[i, j];
                }
            }

            Console.WriteLine("\n");

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    Console.Write("{0, 5} ", array[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
