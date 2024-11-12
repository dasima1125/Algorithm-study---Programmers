using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] insert = Console.ReadLine().Split();
            int data  = int.Parse(insert[0]);
            int order = int.Parse(insert[1]);

            Dictionary<string,int> database1 = new Dictionary<string,int>();
            Dictionary<int,string> database2 = new Dictionary<int,string>();

            for (int i = 1; i <= data; i++) 
            {
                string input = Console.ReadLine();
                database1.Add(input, i);
                database2.Add(i, input);
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < order; i++)
            {
                string ordering = Console.ReadLine();
                if (Regex.IsMatch(ordering, @"\d"))
                {
                    sb.AppendLine(database2[int.Parse(ordering)]);
                }
                else
                {
                    sb.AppendLine(database1[ordering].ToString());
                }
            }
            Console.WriteLine(sb);

        }
        
    }
} 