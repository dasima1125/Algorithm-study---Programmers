using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string s) {
        
        int[] answer = new int[s.Length];
        
        answer[0] = -1;
        
        for (int i = 1; i < s.Length; i++)
        {
            int sum = s.LastIndexOf(s[i],i-1);   
            answer[i] = sum == -1 ? -1 : i - sum;
        }
        
       
        return answer;
    }
}