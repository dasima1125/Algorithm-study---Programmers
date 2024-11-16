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
            Stack<int> stack = new Stack<int>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split();
                switch(int.Parse(s[0]))
                {
                    case 1: 
                        stack.Push(int.Parse(s[1]));
                        break;
                    
                    case 2:  
                        if (stack.Count > 0)
                            sb.AppendLine(stack.Pop().ToString());
                        else
                            sb.AppendLine("-1");
                        break;
                    
                    case 3:
                        sb.AppendLine(stack.Count.ToString());
                        break;
                    
                    case 4:
                        if (stack.Count == 0)
                            sb.AppendLine("1");
                        else
                            sb.AppendLine("0");
                        break;
                    
                    case 5:
                        if (stack.Count > 0)
                            sb.AppendLine(stack.Peek().ToString());
                        else
                            sb.AppendLine("-1");
                        break;
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
