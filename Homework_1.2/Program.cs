using System;

namespace Homework_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter to string");
            string str = Console.ReadLine();
            string str1 = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 1)
                str1 = string.Concat(str1, str[i]);
            }
            Console.WriteLine("New string:");
            Console.WriteLine(str1);
        }
    }
}
