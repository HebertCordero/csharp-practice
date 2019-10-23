/*
    Write a C# Sharp program to print the result of the specified operations.
*/
using System;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            float op1 = -1 + 4 * 6;
            float op2 = (35 + 5) % 7;
            float op3 = 14 + -4 * 6 / 11;
            float op4 = 2 + 15 / 6 * 1 - 7 % 2;

            Console.WriteLine(op1);
            Console.WriteLine(op2);
            Console.WriteLine(op3);
            Console.WriteLine(op4);
        }
    }
}
