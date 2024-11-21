using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int[] sequence, int k)
    {
        int start = 0;
        int end = 0;
        int currentSum = 0;
        int[] answer = new int[2];
        List<int[]> results = new List<int[]>();

        while (end < sequence.Length)
        {
            currentSum += sequence[end];

            while (currentSum > k && start <= end)
            {
                currentSum -= sequence[start];
                start++;
            }

            if (currentSum == k)
            {
                results.Add(new int[] { start, end });
            }

            end++;
        }

        if (results.Count == 1)
        {
            answer[0] = results[0][0];
            answer[1] = results[0][1];
        }
        else if (results.Count > 1)
        {
            int minLength = results.Min(r => r[1] - r[0]);
            var minResult = results.First(r => (r[1] - r[0]) == minLength);
            answer[0] = minResult[0];
            answer[1] = minResult[1];
        }

        return answer;
    }
}