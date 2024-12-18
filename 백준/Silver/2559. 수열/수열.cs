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
            
            int n = int.Parse(insert[0]);
            int k = int.Parse(insert[1]);

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);

            int sum = 0;
            for (int i = 0; i < k; i++)
            {
                sum += arr[i];
            }

            int result = sum;

            for (int i = k; i < n; i++)
            {
                sum += arr[i] - arr[i - k]; 
                result = Math.Max(result, sum);  
            }

            Console.WriteLine(result);
        }
        
    }
}