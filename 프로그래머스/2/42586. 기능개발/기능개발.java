import java.util.*;

class Solution {
    public int[] solution(int[] progresses, int[] speeds) {
        
        List<Integer> result = new ArrayList<>();
        
        int currentMaxDay = (int)Math.ceil((100.0 - progresses[0]) / speeds[0]);
        int count = 1;
        
        for(int i = 1; i < progresses.length; i++) 
        {
            int day = (int)Math.ceil((100.0 - progresses[i]) / speeds[i]);
            
            if(day <= currentMaxDay) count++;
            else 
            {
                result.add(count);
                currentMaxDay = day;
                count = 1;
            }
        }
        
        result.add(count);
        return result.stream().mapToInt(i -> i).toArray();
    }
}