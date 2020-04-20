using System;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements in the array:");
            int n = Convert.ToInt16(Console.ReadLine());
            int[] M = new int[n];
            Random r = new Random();
            Console.WriteLine("Source array:");
            int sum = 0;
            for (int k = 0; k < n; k++)
            {
                M[k] = r.Next(10);
                Console.Write(M[k] + "  ");
                if (M[k] % 2 == 0) sum =  M[k] + sum;
            }
            Console.WriteLine();
            Console.WriteLine("Sum even elements of array: " + sum);

        }

    }
}