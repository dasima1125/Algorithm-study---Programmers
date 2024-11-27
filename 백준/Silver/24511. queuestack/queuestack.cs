using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int n = int.Parse(Console.ReadLine());
            int[] a_type = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] b_type = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int m = int.Parse(Console.ReadLine());
            int[] c_type = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Queue<int> q = new Queue<int>();
            for (int i = n - 1; i >= 0; i--)
            {
                if (a_type[i] == 0) q.Enqueue(b_type[i]);

            }

            for (int i = 0; i < m; i++)
            {
                q.Enqueue(c_type[i]);
                sb.Append(q.Dequeue() + " ");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}