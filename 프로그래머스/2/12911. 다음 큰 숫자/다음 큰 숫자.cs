using System;

class Solution 
{
    public int solution(int n) 
   {
        int answer = n;
        int time = Convert.ToString(answer,2).Replace("0","").Length;
        while (true)
        {
            answer += 1;
            if(Convert.ToString(answer, 2).Replace("0", "").Length == time) break; 
        }

        return answer;
    }
}