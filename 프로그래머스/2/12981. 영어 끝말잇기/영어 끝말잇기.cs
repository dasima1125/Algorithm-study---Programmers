using System;
using System.Collections.Generic;
class Solution
{
    public int[] solution(int n, string[] words)
    { 
        int[] answer = { 0, 0 };
        int time = 1;
        int roop = 1;

        List<string> list = new List<string>();
        list.Add(words[0]);
        for (int i = 1; i < words.Length; i++)
        {
            time += 1;
            if (time > n)
            {
                time = 1;
                roop += 1;
            }
            
            if (words[i - 1][words[i - 1].Length - 1] != words[i][0])
            {
                answer[0] = time;
                answer[1] = roop;
                break;
            }
            else if (list.Contains(words[i]))
            {
                answer[0] = time;
                answer[1] = roop;
                break;
                                            
            }
            list.Add(words[i]);

        }

        return answer;
    }
}