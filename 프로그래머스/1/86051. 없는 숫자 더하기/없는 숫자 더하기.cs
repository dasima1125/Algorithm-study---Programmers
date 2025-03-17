using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        bool [] target = new bool[10];
        for(int i = 0; i < numbers.Length; i++)
        {
            target[numbers[i]] = true;
        }
        
        for(int i = 0; i < target.Length; i++)
        {
            if(!target[i])
                answer += i;
        }
        return answer;
    }
}