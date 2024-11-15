using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            List<int> list2 = new List<int>();

            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }
            
            for (int i = 0; i < list.Count - 1; i++)
            {
                
                list2.Add(list[i + 1] - list[i]);
            }

            int range = list2[0];
            int count = 0;
            
            for (int i = 1; i < list2.Count; i++)
            {
                range = gcd(range, list2[i]);
            }

            for (int i = 0; i < list2.Count; i++)//각 간격구하고 그값 나누기 물론 2의경우는 적당한간격이니 -1 추가
            {
                count += (list2[i] / range) - 1;
            }

            Console.WriteLine(count);
        }

        public static int gcd(int n, int m)
        {
            if (m == 0) return n;
            else return gcd(m, n % m);
        }
    }
}