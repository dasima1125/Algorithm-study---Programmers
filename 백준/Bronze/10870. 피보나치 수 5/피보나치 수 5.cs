using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(pibo(n));
        }
        public static int pibo(int n)
        {
            if (n <= 1)
                return n;
            return pibo(n - 1) + pibo(n - 2);
        }
    }
}