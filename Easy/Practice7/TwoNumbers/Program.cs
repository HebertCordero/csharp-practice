using System;

namespace TwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2;
            Console.Write("\nWrite the First number: ");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("\nWrite the Second number: ");
            num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1+num2);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1-num2);
            Console.WriteLine("{0} * {1} = {2}", num1, num2, num1*num2);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1/num2);
            Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1%num2);
        }
    }
}
