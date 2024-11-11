using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            HashSet<string>check = new HashSet<string>();
           
            for (int i = 0; i < n; i++)
            {
                string[] read = Console.ReadLine().Split(" ");
                if (read[1] == "enter")
                {
                    check.Add(read[0]);
                    
                }
                else if (read[1] == "leave")
                {
                    check.Remove(read[0]);

                }
            }
            StringBuilder sb = new StringBuilder();
            foreach (string s in check.OrderByDescending(a => a))
            {
                sb.AppendLine(s);

            }
            
            Console.WriteLine(sb.ToString());

        }
    }
}