using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] first = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int m = int.Parse(Console.ReadLine());
            int[] second = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                if (map.ContainsKey(first[i]))
                {
                    map[first[i]]++;
                }
                else
                {
                    map[first[i]] = 1;
                }
            }
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < m; i++)
            {
                sb.Append(map.ContainsKey(second[i]) ? map[second[i]] : 0);
                sb.Append(" ");
            }

            Console.WriteLine(sb.ToString().Trim());

        }
    }
}