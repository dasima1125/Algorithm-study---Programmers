import java.util.*;
class Solution {
    public static int solution(int[][] routes) {

        int answer = 1;
        Arrays.sort(routes,(a,b) -> a[1] - b[1]);
      
        int camPos = routes[0][1]; //시작점 설정
       
        for(int i = 1; i < routes.length; i++) 
        {
            if(camPos < routes[i][0]) 
            { 
                camPos = routes[i][1];
                answer++;
            }
        }
        return answer;
    }
}