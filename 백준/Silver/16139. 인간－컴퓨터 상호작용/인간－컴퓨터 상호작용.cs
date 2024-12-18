using System;
using System.Text;
class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        string s = Console.ReadLine();
        int n = s.Length;
        int[,] prefix = new int[26, n + 1];

        for (int i = 0; i < n; i++)
        {
            int charIndex = s[i] - 'a';

            for (int j = 0; j < 26; j++)
            {
                prefix[j, i + 1] = prefix[j, i];
            }
            prefix[charIndex, i + 1]++;
        }
       
        int q = int.Parse(Console.ReadLine());

        for (int i = 0; i < q; i++)
        {
            string[] query = Console.ReadLine().Split(' ');
            char alpha = query[0][0];
            int l = int.Parse(query[1]);
            int r = int.Parse(query[2]);

            int alphaIndex = alpha - 'a';
            int result = prefix[alphaIndex, r + 1] - prefix[alphaIndex, l];
            
            sb.AppendLine(result.ToString());
        }
        Console.WriteLine(sb.ToString());
    }
}