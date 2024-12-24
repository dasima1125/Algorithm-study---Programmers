using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] progresses, int[] speeds) {
        List<int> result = new List<int>();
        
        int[] completeday = new int[progresses.Length];
        
        for(int i = 0; i < progresses.Length; i++)
        {
            completeday[i] = (int)Math.Ceiling((100.0-progresses[i])/speeds[i]);
            
        }
        int maxDays = completeday[0]; 
        int count = 1;
        
        for (int i = 1; i < progresses.Length; i++)
        {
            if (completeday[i] <= maxDays)
            {
                count++; 
            }
            else
            {
                result.Add(count); 
                maxDays = completeday[i];count = 1; 
            }
        }
        result.Add(count);
        
        
        return result.ToArray();
    }
}