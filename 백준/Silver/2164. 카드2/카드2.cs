using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int> queue = new Queue<int>();
            for (int i = 1; i <= n; i++)
            {
                queue.Enqueue(i);
            }

            while (true)
            {
                if (n == 1)
                {
                    Console.WriteLine(queue.Dequeue().ToString());
                    break;
                }
                queue.Dequeue();
                n--;
                int back = queue.Dequeue();
                queue.Enqueue(back);
            }
        }
    }
}
