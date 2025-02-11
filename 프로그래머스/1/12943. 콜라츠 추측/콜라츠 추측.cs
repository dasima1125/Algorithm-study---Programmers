public class Solution {
    public int solution(int num) {
        long n = num;
        int answer = 0;
        
        while (n != 1)
        {
            answer++;
            n = (n % 2 != 0) ? n * 3 + 1 : n / 2; 
        }
        if (answer >= 500) answer = -1;
        
        return answer;
    }
}