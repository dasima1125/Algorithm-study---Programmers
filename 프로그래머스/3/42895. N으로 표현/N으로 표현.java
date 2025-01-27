import java.util.*;
class Solution {
    public static int solution(int N, int number) {
        Set<Integer>[] dp = new Set[9]; 
        for (int i = 0; i < 9; i++) 
        {
            dp[i] = new HashSet<>();
        }
    
        for (int i = 1; i <= 8; i++) 
        {  
            dp[i].add(Integer.parseInt(String.valueOf(N).repeat(i)));
            for (int j = 1; j < i; j++) 
            {
                for (int num1 : dp[j]) 
                {
                    for (int num2 : dp[i - j]) 
                    {
                        dp[i].add(num1 + num2); // 더하기
                        dp[i].add(num1 - num2); // 빼기
                        dp[i].add(num1 * num2); // 곱하기
                        if (num2 != 0) dp[i].add(num1 / num2);//나누기 소수점은 알아서 쳐내고
                        
                    }
                }
                
            }

            if (dp[i].contains(number)) 
            {
                return i;
            }
        }
        return -1;
    }
    
}