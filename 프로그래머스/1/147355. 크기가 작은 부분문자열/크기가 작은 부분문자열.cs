using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;

        for (int i = 0; i <= t.Length - p.Length; i++) 
        {
            string sub = t.Substring(i, p.Length); 
            if (long.Parse(sub) <= long.Parse(p)) 
            { 
                answer++;
            }
        }

        return answer;
    }
}