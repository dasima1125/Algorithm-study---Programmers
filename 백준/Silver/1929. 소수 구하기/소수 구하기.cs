using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            
            int low = int.Parse(input[0]);
            int high = int.Parse(input[1]);

            StringBuilder sb = new StringBuilder();
            bool[] check = Enumerable.Repeat(true, high + 1).ToArray();
            check[1] = false;

            for (int i = 2; i * i <= high; i++)
            {
                if (check[i])
                for (int j = i * i; j <= high; j += i)
                {
                    check[j] = false;
                }
            }

            for (int i = low; i <= high; i++)
            {
                if (check[i]) 
                {
                    sb.AppendLine(i.ToString());
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
