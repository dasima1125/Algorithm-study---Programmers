import java.util.*;

class Solution {
    public  int[] solution(int brown, int yellow) {
        
        for(int i=1; i <= brown + yellow; i++) 
        {
            int j = (brown + yellow) / i;
            if (i + j == (brown + 4) / 2 && i * j == brown + yellow) 
            {
                return new int[] {j,i};               
            }
            
        }
        return null;
    }
}