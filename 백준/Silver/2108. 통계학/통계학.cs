using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> check = new Dictionary<int, int>();
            List<int> numbers = new List<int>();

            string[] s = Console.ReadLine().Split();
            
            int n = int.Parse(s[0]);
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                int insert = int.Parse(Console.ReadLine());
                numbers.Add(insert);
                sum += insert;
                
                if (check.ContainsKey(insert)) check[insert]++;
                else  check.Add(insert, 1);
              
            }
            Console.WriteLine((int)Math.Round(sum/n));//첫번째 케이스

            numbers.Sort();
            Console.WriteLine(numbers[n/2]); // 두번째 케이스

            var sort1 = check.OrderByDescending(x => x.Value);
            var sort2 = check.Where(x => x.Value == sort1.First().Value).ToList();
            if(sort2.Count() == 1)
            {
                Console.WriteLine(sort2.First().Key);
            }
            else
            {
                var sort3 = sort2.OrderBy(x => x.Key).Skip(1).First().Key;
                Console.WriteLine(sort3);
            }
            Console.WriteLine(numbers[numbers.Count - 1] - numbers[0]);//4번째 케이스

        }
    }
}