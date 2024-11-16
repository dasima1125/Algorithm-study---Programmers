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
            char[] allowed = { '(', ')', '{', '}', '[', ']'};

            while(true)
            {
                string str = Console.ReadLine();

                if(str == ".") break;
                
                str = string.Concat(str.Where(a => allowed.Contains(a)));
                Stack<char> stack = new Stack<char>();
                bool vaild = true;

                foreach (char c in str)
                {
                    if (c == '(' || c == '{' || c == '[')
                    {
                        stack.Push(c);
                    }
                    else
                    {
                        if(stack.Count == 0)//여는게 없으면
                        {
                            vaild = false;//종료
                            break;
                        }

                        char top = stack.Pop();//  맨위꺼 저장
                        if((c ==')' && top != '(') || (c == '}' && top != '{') || (c == ']' && top != '['))//맨위에꺼가 닫는거랑 불일치시
                        {
                            vaild = false;//종료
                            break;
                        }
                    }
                    
                }
                if (!vaild || stack.Count != 0)
                {
                    sb.AppendLine("no");
                }
                else
                {
                    sb.AppendLine("yes");
                }

            }    
            Console.WriteLine(sb.ToString());
  
        }
    }
}