/*
    Write a C# Sharp program to print the result of dividing two numbers.
*/

using System;

namespace DivideTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double divide = (double)10 / 4;
            Console.WriteLine(divide);
        }
    }
}

/*
    int is an integer type; dividing two ints performs an integer division, 
    i.e. the fractional part is truncated since it can't be stored in the 
    result type (also int!). 
    Decimal, by contrast, has got a fractional part. By invoking 
    Decimal.Divide, your int arguments get implicitly converted to 
    Decimals.
*/