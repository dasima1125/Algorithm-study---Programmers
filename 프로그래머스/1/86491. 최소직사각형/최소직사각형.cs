using System;

public class Solution {
    public int solution(int[,] sizes) {
        
        int max = 0; 
        int min = 0;
        for(int i = 0;i < sizes.GetLength(0); i++)
        {
            max = Math.Max(max,Math.Max(sizes[i,0],sizes[i,1]));
            min = Math.Max(min,Math.Min(sizes[i,0],sizes[i,1]));
        }

        return max * min;
    }
}