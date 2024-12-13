using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int k, int[] tangerine) {

        Dictionary<int, int> sizeCount = new Dictionary<int, int>();

        foreach (var size in tangerine) 
        {
            if(sizeCount.ContainsKey(size)) sizeCount[size]++; 
            else sizeCount[size] = 1;
        }

        List<int> list = new List<int>(sizeCount.Values);
        list.Sort((a, b) => b.CompareTo(a));

        int total = 0;
        int answer = 0;

        foreach (var count in list)
        {
            total += count;
            answer++;

            if (total >= k)
            {
                break;
            }
        }

        return answer;
    }
}
