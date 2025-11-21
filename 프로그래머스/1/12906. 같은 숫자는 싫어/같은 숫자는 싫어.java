import java.util.*;

public class Solution {
    public int[] solution(int []arr) {
        ArrayList<Integer> result = new ArrayList<>();
        int prev = -1;
        for (int num : arr) 
            if(num != prev)
            {
                prev = num;
                result.add(prev);
            }
        return result.stream().mapToInt(Integer::intValue).toArray();
    }
}