using System;
using System.Linq;

public class Solution
{
    public int[] solution(int k, int[] score)
    {
        int[] answer = new int[score.Length];

        for (int i = 0; i < score.Length; i++)
        {
            int[] sum = new int[i + 1];
            
            for (int j = 0; j <= i; j++)
            {
                sum[j] = score[j];
            }
            
            if (sum.Length <= k)
            {
                answer[i] = sum.Min();
            }
            else
            {
                var modifiedSum = sum.OrderByDescending(x => x).Take(k).ToArray();
                answer[i] = modifiedSum[k - 1]; 
            }
        }

        return answer;
    }
}