using System;

namespace StringContains
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "PHP Tutorial";
            Console.WriteLine("PHP Tutorial");
            Console.WriteLine((str.Substring(1,2).Equals("HP") ? str.Remove(1,2) : str));
        }
    }
}
