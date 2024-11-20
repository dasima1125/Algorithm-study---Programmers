using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] m = Console.ReadLine().Split(" ");
            List<(int, int)> list = new List<(int, int)>();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                list.Add((i + 1, int.Parse(m[i])));
            }

            int idx = 0;

            while (list.Count > 0)
            {
                int cnt = list[idx].Item2;
                sb.Append(list[idx].Item1 + " ");
                list.RemoveAt(idx);

                if (list.Count == 0) break;
               
                if (cnt > 0)
                {
                    idx = (idx + cnt - 1) % list.Count;
                }
                else
                {
                    idx = (idx + cnt) % list.Count;
                    if (idx < 0) idx += list.Count;
                }
            }

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
