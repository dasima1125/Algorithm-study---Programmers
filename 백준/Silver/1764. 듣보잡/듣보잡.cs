using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] set  =  Console.ReadLine().Split(" ");
            int a = int.Parse(set[0]);
            int b = int.Parse(set[1]);
            
            HashSet<string> names = new HashSet<string>();
            List<string> list = new List<string>();

            for (int i = 0; i < a; i++)
            {
                names.Add(Console.ReadLine());    
            }
            for (int j = 0; j < b; j++)
            {
                string name = Console.ReadLine();
                if (names.Contains(name))
                {
                    list.Add(name);   
                }
            }
            list.Sort();

            Console.WriteLine(list.Count);
            Console.WriteLine(String.Join("\n", list));
        }
    }
} 