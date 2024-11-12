
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
