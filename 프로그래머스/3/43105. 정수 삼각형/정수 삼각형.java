import java.util.*;
class Solution {
    public int solution(int[][] triangle) {
        
        int n = triangle.length;
        int[][] dp = new int[n][n];
        
        for (int i = 0; i < n; i++)//제일 하단 선 기입 
        {
            dp[n-1][i] = triangle[n-1][i];
        }
      
        //바텀업 구조
        //로직 구조
        // 맨아래 배열 + 1 부분에서 비교 우측과 좌측 비교해서 더큰값을 dp배열에 저장 
        // 꼭대기 갈때까지 반복 i는 현재 선택된 부분 높이 j는 그 높이 비례해서 반복해야할수 제어 반복할수는 높이 + 1 인 상태임
        for(int i = n - 2; i >= 0 ; i--)
        {  
            for (int j = 0; j <= i; j++) 
            {  
                dp[i][j] = Math.max(dp[i+1][j], dp[i+1][j+1]) + triangle[i][j];
            }
        }
        //근데 구조가 맘에안듬
        return dp[0][0];
    }
}