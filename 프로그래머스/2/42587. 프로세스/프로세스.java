import java.util.*;
class Solution {
    public int solution(int[] priorities, int location) {
        int answer = 0;
        Queue<int[]> queue = new LinkedList<>();
        
        for(int i = 0; i< priorities.length;i++)
            queue.offer(new int[]{i,priorities[i]});
        
        while(!queue.isEmpty())
        {
            int [] pick = queue.poll(); // [원래 위치, 우선순위]
            if(queue.stream().anyMatch(p -> p[1] > pick[1]))
            {
                queue.offer(pick);
                continue;
            }
            answer++;
            if(pick[0]== location)return answer;
        }
        return answer;
    }
}