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
            string[] set  =  Console.ReadLine().Split(" ");
            int[] first   =  Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] second  =  Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            var a_b = first.Except(second); 
            var b_a = second.Except(first);

            Console.WriteLine(a_b.Count() + b_a.Count());
        }
    }
} 