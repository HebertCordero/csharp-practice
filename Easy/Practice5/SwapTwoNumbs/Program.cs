/*
    Write a C# Sharp program to swap two numbers.

    Test Data:
        Input the First Number : 5
        Input the Second Number : 6
        Expected Output:
        After Swapping :
        First Number : 6
        Second Number : 5
*/
using System;

namespace SwapTwoNumbs
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;
            Console.Write("\nInput the Fisrt Number: ");
            num1 = int.Parse((Console.ReadLine()));
            Console.Write("\nInput the Second number: ");
            num2 = int.Parse((Console.ReadLine()));

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine(num1 + " " + num2);
        }
    }
}