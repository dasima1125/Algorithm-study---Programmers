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
            for (int i = 0; i < n; i++)
            {
                Stack<int> stack = new Stack<int>();
                string s = Console.ReadLine();

                bool vaild = true;

                foreach (char a in s)
                {
                    if(a == '(')
                    {
                        stack.Push(a);
                    }
                    else
                    {
                        if (stack.Count == 0)  
                        {
                            vaild = false;  
                            break;
                        }
                        stack.Pop();
                    }
                }
                if (!vaild || stack.Count != 0)
                {
                    sb.AppendLine("NO");
                }
                else
                {
                    sb.AppendLine("YES");  
                }
            }
            Console.WriteLine(sb.ToString());

            
        }
    }
}
