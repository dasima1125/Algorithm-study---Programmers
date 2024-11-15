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

            for (int i = 0; i < n; i++)
            {
                long num = long.Parse(Console.ReadLine());
                while (true)
                {
                    if (num <= 1)
                    {
                        num++;
                        continue;
                    }
                    if (num == 2 || num == 3)
                    {
                        sb.AppendLine(num.ToString());
                        break;
                    }
                    if (num % 2 == 0 || num % 3 == 0)
                    {
                        num++;
                        continue;
                    }
                    bool isPrime = true;
                    for (long j = 5; j * j <= num; j += 6)
                    {
                        if (num % j == 0 || num % (j + 2) == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        sb.AppendLine(num.ToString());
                        break;
                    }
                    num++;
                }
            }

            Console.Write(sb.ToString());
        }
    }
}
