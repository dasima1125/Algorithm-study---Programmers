using System;

public class Solution {
    public int solution(int storey) {
        int answer = 0;

        while (storey > 0) 
        {
            int count = storey % 10;

            if (count >= 5 && (storey / 10) % 10 >= 5) 
            {
                storey += 10;
                answer += 10 - count;
            } 
            else if (count >= 6) 
            {
                storey += 10;
                answer += 10 - count;
            } 
            else answer += count;

            storey /= 10;
        }

        return answer;
    }
}
