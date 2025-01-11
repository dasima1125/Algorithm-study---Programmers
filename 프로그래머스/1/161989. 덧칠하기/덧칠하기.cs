using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int n, int m, int[] section) {
        int answer = 0;
        HashSet<int> sectionSet = new HashSet<int>(section); 
        
        for (int i = 1; i <= n+1; i++)
        {
            if(sectionSet.Contains(i)) {
                answer++;
                i += m - 1; 
            }
        }
        return answer;
    }
}