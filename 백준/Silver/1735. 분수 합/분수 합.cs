using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] insert1 = Console.ReadLine().Split();
            int a_1 = int.Parse(insert1[0]);
            int b_1 = int.Parse(insert1[1]);
            string[] insert2 = Console.ReadLine().Split();
            int a_2 = int.Parse(insert2[0]);
            int b_2 = int.Parse(insert2[1]);

            int morther = lcm(b_1,b_2);
            int sons = (a_1 * (morther / b_1 )) + (a_2 * (morther / b_2));

            int counted = gcd(sons, morther);

            sons    /= counted;
            morther /= counted;
            
            Console.WriteLine(sons + " " + morther);


        }
        public static int lcm(int n, int m)
        {
            return n * m / gcd(n, m); 
        }
        public static int gcd(int n, int m)
        {
            if (m == 0) return n;
            else return gcd(m, n % m);
        }

    }
} 