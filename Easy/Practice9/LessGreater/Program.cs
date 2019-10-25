using System;

namespace LessGreater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nInput the First Number(<100): ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nInput the Second Number(>200): ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((m < 100 && n > 200));
        }
    }
}
