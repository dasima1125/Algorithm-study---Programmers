using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            int a = int.Parse(Console.ReadLine());
            List<(int, string)> list = new List<(int, string)>();

            for (int i = 0; i < a; i++)
            {
               string [] s = Console.ReadLine().Split();
               list.Add((int.Parse(s[0]), s[1]));
            }

            var sortedlist = list.OrderBy(x => x.Item1) .ToList(); //sort를 사용하면 동일한값 순서가 바뀔수있음

            foreach (var item in sortedlist)
            {
                Console.WriteLine(item.Item1 + " " + item.Item2);
            }

        }
    }
}