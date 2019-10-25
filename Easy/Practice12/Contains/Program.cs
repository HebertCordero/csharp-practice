//Write a C# program to check if a given string contains 'w' character between 1 and 3 times.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contains
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = 0;
            bool ans = false;
            Console.Write("Input a string: ");
            string str = Console.ReadLine();
            Console.WriteLine("Testing the string... Cecking for 'w' characters...");
            char[] chars = str.ToCharArray();
            for(int i = 0; i < chars.Length; i++) {
                //Console.WriteLine(" " + chars[i]);
                if(chars[i] == 'w'){
                    temp++;
                    if(temp > 1 && temp <= 3) {
                        ans = true;
                    } else {
                        ans = false;
                    }
                }
            }
            Console.WriteLine(ans);
        }
    }
}
