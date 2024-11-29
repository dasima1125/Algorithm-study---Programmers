using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> namecheck = new Dictionary<string, int>(); //감염시 1 비감염시 0
            namecheck.Add("ChongChong", 1);// 최초 감염자
              
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split();
                string a = s[0];
                string b = s[1];
                bool infect = false;
                //값이 이미 들어가있을경우  만약 감염상태면 감염 활성화
                if ((namecheck.ContainsKey(a) && namecheck[a] == 1) || (namecheck.ContainsKey(b) && namecheck[b] == 1)) infect = true;
                
                if(infect)
                {
                    if (!namecheck.ContainsKey(a)) namecheck.Add(a, 1);
                    else  namecheck[a] = 1;
                  
                    if (!namecheck.ContainsKey(b)) namecheck.Add(b, 1);
                    else  namecheck[b] = 1;
                }
                else
                {
                    if(!namecheck.ContainsKey(a)) namecheck.Add(a, 0); 
                    if(!namecheck.ContainsKey(b)) namecheck.Add(b, 0);
                }
            }
            Console.WriteLine(namecheck.Values.Count(v => v == 1));
        }
    }
}