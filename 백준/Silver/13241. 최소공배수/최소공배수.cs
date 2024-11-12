using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] insert = Console.ReadLine().Split();
            int a = int.Parse(insert[0]);
            int b = int.Parse(insert[1]);
            
            Console.WriteLine(lcm(a,b));
        }
        public static long lcm(int n, int m)
        {
            return (long)n * m / gcd(n, m); 
        }
        public static int gcd(int n, int m)
        {
            if (m == 0) return n;
            else return gcd(m, n % m);
        }

    }
} 