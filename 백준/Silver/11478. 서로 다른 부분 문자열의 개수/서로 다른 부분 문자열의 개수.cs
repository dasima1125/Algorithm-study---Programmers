using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            HashSet<string> set = new HashSet<string>();
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 1; j <= s.Length - i; j++)
                {
                    set.Add(s.Substring(i, j));
                }
            }
            Console.WriteLine(set.Count); 
        }
        
    }
} 