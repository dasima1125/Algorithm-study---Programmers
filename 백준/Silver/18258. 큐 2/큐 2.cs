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
            StringBuilder sb = new StringBuilder();
            Queue<int> queue = new Queue<int>();
            int lastcheck = -1;

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                switch(input[0])
                {
                    case "push":
                        queue.Enqueue(int.Parse(input[1]));
                        lastcheck = int.Parse(input[1]);
                        break;

                    case "pop":
                        if(queue.Count > 0) sb.AppendLine(queue.Dequeue().ToString());
                        else sb.AppendLine("-1");
                        break;

                    case "size":
                        sb.AppendLine(queue.Count.ToString());
                        break;

                    case "empty":
                        if(queue.Count > 0) sb.AppendLine("0");
                        else sb.AppendLine("1");
                        break;

                    case "front":
                        if (queue.Count > 0) sb.AppendLine(queue.Peek().ToString());
                        else sb.AppendLine("-1");
                        break;

                    case "back":
                        if (queue.Count > 0) sb.AppendLine(lastcheck.ToString());//last로하면 타임아웃걸리려나
                        else sb.AppendLine("-1");
                        break;
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}