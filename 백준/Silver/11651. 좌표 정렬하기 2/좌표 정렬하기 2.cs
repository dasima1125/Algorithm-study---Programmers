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
            int a = int.Parse(Console.ReadLine());
            List<(int, int)> list = new List<(int, int)>();

            for (int i = 0; i < a; i++)
            {
               string [] s = Console.ReadLine().Split();
               list.Add((int.Parse(s[0]),int.Parse(s[1])));
            }

            // y 값 기준으로 소팅 
            //       ㄴ추가조건 , y좌표가 같으면 x좌표가 증가하는 순서로 정렬
            //                    ㄴ 삼항문으로 컴페어 분할  y가 같을때는 x 기준 소트 다를경우 y 기준
            list.Sort((x, y) => x.Item2 != y.Item2 ? x.Item2.CompareTo(y.Item2) : x.Item1.CompareTo(y.Item1));

            StringBuilder sb = new StringBuilder();
            
            foreach (var item in list)
            {
                sb.AppendLine($"{item.Item1} {item.Item2}");
            }
            Console.Write(sb.ToString());


        }
    }
}
