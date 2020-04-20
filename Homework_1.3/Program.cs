using System;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;   // number 1
            double b;   // number 2
            char oper;   // math operation
            Console.WriteLine("Write the first number:");   // input first number
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Write the second number:");   // input second number
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Write the math operation(+, -, /, *):");   // input math operation
            oper = Convert.ToChar(Console.ReadLine());
            switch (oper)
            {
                case '+':
                    Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
                    break;
                case '-':
                    Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
                    break;
                case '/':
                    if (b == 0)
                        Console.WriteLine("Error! Division by zero.");
                    else
                        Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
                    break;
                case '*':
                    Console.WriteLine("{0} - {1} = {2}", a, b, a * b);
                    break;
                default:
                    Console.WriteLine("Error! Unknown math operation.");
                    break;
            }

        }
    }
}