using System;

namespace MultTable
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1;
            Console.Write("\nTable number: ");
            num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("{0} * {1} = {2}", num1, 0, num1*0);
            Console.WriteLine("{0} * {1} = {2}", num1, 1, num1*1);
            Console.WriteLine("{0} * {1} = {2}", num1, 2, num1*2);
            Console.WriteLine("{0} * {1} = {2}", num1, 3, num1*3);
            Console.WriteLine("{0} * {1} = {2}", num1, 4, num1*4);
            Console.WriteLine("{0} * {1} = {2}", num1, 5, num1*5);
            Console.WriteLine("{0} * {1} = {2}", num1, 6, num1*6);
            Console.WriteLine("{0} * {1} = {2}", num1, 7, num1*7);
            Console.WriteLine("{0} * {1} = {2}", num1, 8, num1*8);
            Console.WriteLine("{0} * {1} = {2}", num1, 9, num1*9);
            Console.WriteLine("{0} * {1} = {2}", num1, 10, num1*10);
        }
    }
}
