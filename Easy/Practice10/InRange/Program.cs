using System;

namespace InRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nInput the First Number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nInput the Second Number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((a <= 10 && a >= -10) || (b <= 10 && b >= -10));
        }
    }
}
