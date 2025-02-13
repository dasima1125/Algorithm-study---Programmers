using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        while(n>0)
        {
            answer += (n % 3) * (int)Math.Pow(3,(int)Math.Log(n,3));
            n /= 3;
        }
        return answer;
    }
}