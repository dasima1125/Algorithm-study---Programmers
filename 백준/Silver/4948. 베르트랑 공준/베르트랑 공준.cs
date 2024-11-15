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

            bool[] check = Enumerable.Repeat(true, 2 * 123456 + 1).ToArray();
            check[0] = check[1] = false;

            for (int i = 2; i * i <= 2 * 123456; i++)
            {
                if (check[i])
                    for (int j = i * i; j <= 2 * 123456; j += i)
                    {
                        check[j] = false;
                    }
            }

            while (true)
            {
                int count = 0;
                int n = int.Parse(Console.ReadLine());
                if (n == 0) break;

                for (int i = n + 1; i <= 2 * n; i++)
                {
                    if (check[i])
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
