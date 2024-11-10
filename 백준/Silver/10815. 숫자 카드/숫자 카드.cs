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
            HashSet<int> cardSet = new HashSet<int>();

            string[] input = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                cardSet.Add(int.Parse(input[i]));
            }

            int m = int.Parse(Console.ReadLine());
            string[] check = Console.ReadLine().Split();


            StringBuilder sb = new StringBuilder(); 
            for (int i = 0; i < m; i++)
            {
                if (cardSet.Contains(int.Parse(check[i])))
                {
                    sb.Append("1 ");
                }
                else
                {
                    sb.Append("0 ");
                }
            }
            Console.WriteLine(sb.ToString().TrimEnd());

        }
    }
}
