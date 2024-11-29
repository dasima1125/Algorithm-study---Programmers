using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            int count = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) 
            {
                string s = Console.ReadLine();
                if (s == "ENTER")
                {
                    count += set.Count();
                    set.Clear();
                }
                else  set.Add(s);
            }
            count += set.Count();
            Console.WriteLine(count);
        }
    }
}