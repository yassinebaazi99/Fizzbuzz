using System;

namespace TrianglePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 5;

            Console.WriteLine("Printing Triangle Pattern:\n");

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}