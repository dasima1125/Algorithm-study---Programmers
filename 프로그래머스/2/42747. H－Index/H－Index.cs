using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] citations) {
        
        List<int> list = new List<int>(citations);
        int answer = 0;
        
        list.Sort();
        list.Reverse();
        
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] >= i + 1)
                answer++;
            else
                break;
        }
        return answer;
    }
}