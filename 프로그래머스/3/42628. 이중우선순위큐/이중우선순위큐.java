import java.util.*;
class Solution {
    public static int[] solution(String[] operations) {
        int[] answer = {0,0};
        PriorityQueue<Integer> pq_high = new PriorityQueue<>((a, b)-> b - a);
        PriorityQueue<Integer> pq_low  = new PriorityQueue<>((a, b)-> a - b);

        for (String insert : operations) 
        {
            int n = Integer.parseInt(insert.substring(2)); //3번째문자부터 변환

            if(insert.charAt(0) == 'I')//adder 
            {
                pq_low.add(n);
                pq_high.add(n);
            }

            else //controlor 
            {
                if(n == -1 && !pq_low.isEmpty()) pq_high.remove(pq_low.poll());
                
                else if(n == 1 && !pq_high.isEmpty()) pq_low.remove(pq_high.poll()); 
            }
            
        }
    
        if(!pq_high.isEmpty())
        {
            answer[0] = pq_high.peek();
            answer[1] = pq_low.peek();
        }
        return answer;
        
    }
}