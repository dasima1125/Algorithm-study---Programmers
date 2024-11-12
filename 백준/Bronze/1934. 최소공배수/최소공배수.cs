using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < int.Parse(s); i++)
            {
                string[] insert = Console.ReadLine().Split();
                int a = int.Parse(insert[0]);
                int b = int.Parse(insert[1]);
                sb.AppendLine(lcm(a, b).ToString());
            }
            Console.WriteLine(sb.ToString());


        }
        public static int lcm(int n, int m)
        {
            return (n * m) / gcd(n, m); 
        }
        public static int gcd(int n, int m)
        {
            if (m == 0) return n;
            else return gcd(m, n % m);
        }

    }
} 