/*
    Write a C# Sharp program to print the output of 
    multiplication of three numbers which will be 
    entered by the user.
*/
using System;

namespace MultUser
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, num3, result;
            Console.Write("\nFirst Number: ");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("\nSecond Number: ");
            num2 = float.Parse(Console.ReadLine());
            Console.Write("\nThird Number: ");
            num3 = float.Parse(Console.ReadLine());

            result = num1 * num2 * num3;

            Console.WriteLine(result);
            //int result = num1 * num2 * num3;
            //Console.WriteLine("Output: {0} x {1} x {2} = {3}", num1, num2, num3, result);
        }
    }
}
