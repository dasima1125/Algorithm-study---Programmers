using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            int n = int.Parse(sr.ReadLine());
            LinkedList<int> list = new LinkedList<int>();
            StringBuilder sb = new StringBuilder();

            int storage = 0;

            for (int i = 0; i < n; i++)
            {
                string[] s = sr.ReadLine().Split(" ");
                switch (int.Parse(s[0]))
                {
                    case 1:
                        list.AddFirst(int.Parse(s[1]));
                        storage++;
                        break;

                    case 2:
                        list.AddLast(int.Parse(s[1]));
                        storage++;
                        break;

                    case 3:
                        if (storage > 0)
                        {
                            sb.AppendLine(list.First.Value.ToString());
                            list.RemoveFirst();
                            storage--;
                        }
                        else
                        {
                            sb.AppendLine("-1");
                        }
                        break;

                    case 4:
                        if (storage > 0)
                        {
                            sb.AppendLine(list.Last.Value.ToString());
                            list.RemoveLast();
                            storage--;
                        }
                        else
                        {
                            sb.AppendLine("-1");
                        }
                        break;

                    case 5:
                        sb.AppendLine(storage.ToString());
                        break;

                    case 6:
                        sb.AppendLine(storage == 0 ? "1" : "0");
                        break;

                    case 7:
                        sb.AppendLine(storage > 0 ? list.First.Value.ToString() : "-1");
                        break;

                    case 8:
                        sb.AppendLine(storage > 0 ? list.Last.Value.ToString() : "-1");
                        break;
                }
            }

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();
        }
    }
}
