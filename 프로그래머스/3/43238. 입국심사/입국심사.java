import java.util.*;
class Solution {
    public long solution(int n, int[] times) {
        long answer = 0;
        Arrays.sort(times);
        long left = 0;
        long right = (long)n * times[times.length -1];
        while(left <= right) {
            long mid = (left + right) / 2;
            long complete = 0;
            for (int i : times) complete += mid/i;
                
            if (complete < n) left = mid + 1; // 처리수가 사람수보다 미달, 최소값 상승
                
            else 
            {
                right = mid - 1;// 처리수가 사람수보다 많거나 같음,하지만 더작은 값이 있을수있음
                answer = mid;   //  ㄴ 관건은 이 조건을 가는게아님, 양쪽끝값이 같아져야함          
            }
        
        }  
        return answer;
    }
}