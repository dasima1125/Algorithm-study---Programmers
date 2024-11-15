using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            bool[] check = Enumerable.Repeat(true, 1000000 + 1).ToArray();

            for (int i = 2; i * i <= 1000000; i++)
            {
                if (check[i])
                for (int j = i * i; j <= 1000000; j += i)
                {
                    check[j] = false;
                }
            }

            for (int i = 0; i < n; i++)
            {
                int count = 0;
                int read = int.Parse(Console.ReadLine());
                for (int j = 2; j <= read / 2; j++)
                {
                    if (check[j] && check[read - j]) 
                    {
                        count++;
                    }
                }
                sb.AppendLine(count.ToString());
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
