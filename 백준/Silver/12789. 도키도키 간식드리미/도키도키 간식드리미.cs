using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int top_count = int.Parse(Console.ReadLine());
            int[] student = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

            Queue<int> insert = new Queue<int>();
            Stack<int> waitline = new Stack<int>();

            bool check = true;
            int nowtime = 1;

            foreach (int score in student)
            {
                insert.Enqueue(score);
            }

            while (true)
            {
                if (insert.Count == 0) 
                {
                    break;
                }
                else if (insert.Peek() == nowtime) 
                {
                    nowtime++;
                    insert.Dequeue();
                }
                else if (waitline.Count > 0 && waitline.Peek() == nowtime) 
                {
                    nowtime++;
                    waitline.Pop();
                }
                else if (insert.Count > 0 && insert.Peek() > nowtime) 
                {
                    if (waitline.Count == 0 || insert.Peek() < waitline.Peek())
                    {
                        waitline.Push(insert.Dequeue());
                    }
                    else 
                    {
                        check = false;
                        break;
                    }
                }
            }

            Console.WriteLine(check ? "Nice" : "Sad");
        }
    }
}
