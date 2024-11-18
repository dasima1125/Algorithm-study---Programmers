using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);

            Queue<int> queue = new Queue<int>();
            List<int> result = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                queue.Enqueue(i);
                
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < k; j++)
                {
                    int change = queue.Dequeue();
                    queue.Enqueue(change);
                }
                result.Add(queue.Dequeue());
            }
            Console.WriteLine("<"+String.Join(", ",result)+">");
        }
    }
}
