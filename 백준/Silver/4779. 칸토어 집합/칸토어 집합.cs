using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Cantor(ref char[] sec, int start, int length)
        {
            if (length == 1)
            {
                return;
            }

            int lengthSemi = length / 3;
            int mid = start + lengthSemi;

            for (int i = mid; i < mid + lengthSemi; i++)
            {
                sec[i] = ' ';
            }

            Cantor(ref sec, start, lengthSemi);
            Cantor(ref sec, mid + lengthSemi, lengthSemi);
        }

        static void Main()
        {
            int count;

            while (int.TryParse(Console.ReadLine(), out count))
            {
                int cnt = (int)Math.Pow(3, count);
                char[] temp = new char[cnt];
                for (int i = 0; i < cnt; i++)
                {
                    temp[i] = '-';
                }

                Cantor(ref temp, 0, cnt);
                Console.WriteLine(new string(temp));
            }
        }
    }
}
