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
            Dictionary<string, int> check = new Dictionary<string, int>();
            

            string[] s = Console.ReadLine().Split();
            int n = int.Parse(s[0]);
            int m = int.Parse(s[1]);

            for (int i = 0; i < n; i++)
            {
                string insert = Console.ReadLine();
                
                if (insert.Length >= m)
                {
                    if (check.ContainsKey(insert))
                    {
                        check[insert]++;
                    }
                    else
                    {
                        check.Add(insert, 1);
                    }

                }
            }
            // 빈도 길이 사전순으로 정렬
            var sorted = check
                .OrderByDescending(time => time.Value)// 딕셔너리에 저장된 개수순 
                .ThenByDescending(length => length.Key.Length)// 길이순 
                .ThenBy(word => word.Key)// 사전순
                .Select(word => word.Key)// 값만 추출
                .ToList();


            foreach (string word in sorted)
            {
                sb.AppendLine(word);
            } 
            Console.WriteLine(sb.ToString());

        }
    }
}
