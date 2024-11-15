using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a =int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 1; i * i <= a; i++)
            {
                count++;
            }
            Console.WriteLine(count);
        }
    }
}