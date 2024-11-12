
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] insert = Console.ReadLine().Split();
            int data  = int.Parse(insert[0]);
            int order = int.Parse(insert[1]);

            Dictionary<string,int> database = new Dictionary<string,int>();

            for (int i = 1; i <= data; i++) 
            {
                database.Add(Console.ReadLine(), i);
                 
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < order; i++)
            {
                string ordering = Console.ReadLine();
                if (Regex.IsMatch(ordering, @"\d"))
                {            
                    sb.AppendLine(database.ToList()[int.Parse(ordering) - 1].Key);
                }
                else
                {
                    sb.AppendLine(database[ordering].ToString());
                }
            }
            Console.WriteLine(sb);

        }
        
    }
}  
//이와같이 문제는 뭐냐 .. 귀찬아서 딕셔너리를 한개만으로 할려했던거였다 테스트케이스가 10만이 넘다보니 딕셔너리로 접근속도는 만족했지만 숫자일때 데이터베이스의 키를 찾을려고 깡으로 ToList를쓰다보니 메모리를 미친듯이 먹어버렸다
//코드가 맘에안들어도 일단 속도랑 안정성위주로 가야하나?
