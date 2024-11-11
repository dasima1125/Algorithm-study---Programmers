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

            for (int i = 0; i < m; i++)
            {
                map[second[i]] = 0;
            }

            for (int i = 0; i < n; i++)
            {
                if (map.ContainsKey(first[i]))
                {
                    map[first[i]]++;
                }

            }
            StringBuilder sb = new StringBuilder();

            foreach (var a in map)
            {
                sb.Append(a.Value + " ");
            }

            Console.WriteLine(sb.ToString());

        }
    }
}
