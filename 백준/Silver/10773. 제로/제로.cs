using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int s = int.Parse(Console.ReadLine());
                if(stack.Count == 0)
                {
                    stack.Push(s);
                    continue;
                }

                switch(s)
                {
                    case 0: 
                        stack.Pop();
                        break;

                    default:
                        stack.Push(s);
                        break; 
                }
            }
            Console.WriteLine(stack.Sum());
        }
    }
}
