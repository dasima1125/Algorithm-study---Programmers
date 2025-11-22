import java.util.*;

class Solution {
    public int[] solution(int[] prices) {
        
        int[] answer = new int[prices.length];
        Stack<Integer> stack = new Stack<>(); //유지 시간이 확정되지 않은 과거 시점들의 인덱스 스택

        for(int i = 0; i < prices.length; i++) //각 날짜당(인덱스) 가격 비교 순환 ex) 1 > 2 > 3 > 2 >  ....
        {
            while(!stack.isEmpty() && prices[i] < prices[stack.peek()])//유지시간이 확정되지않은 기록이 있을때 and 가격이 떨어질때
            {
                int index = stack.pop();   // 해당기록은 확정 제거
                answer[index] = i - index; // 확정일을 미리 answer에 저장 저장식은 지금 인덱스인 i - 유지시간 확정된 일자 index
             
            }
            stack.push(i); // 현재 날짜 인덱스 스택에 부여(미확정 상태)
        }
        
        while(!stack.isEmpty()) //미확정일 기록 부여
        {
            int idx = stack.pop();
            answer[idx] = prices.length - 1 - idx;
        }

        return answer;
    }
}
