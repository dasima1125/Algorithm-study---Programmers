using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            string [] insert = Console.ReadLine().Split(" ");
            StringBuilder sb = new StringBuilder();
            
            int n = int.Parse(insert[0]);
            int m = int.Parse(insert[1]);

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            
            int[] prefix = new int[n + 1];

            for (int i = 0; i < n; i++)
            {
                prefix[i + 1] = prefix[i] + arr[i];
            }

            for (int i = 0; i < m; i++)
            {
                string [] input = Console.ReadLine().Split(" ");
                int first  = (int.Parse(input[0]));
                int second = (int.Parse(input[1]));

                sb.AppendLine((prefix[second] - prefix[first - 1]).ToString());
            }
            Console.WriteLine(sb.ToString());
        }
        
    }
}