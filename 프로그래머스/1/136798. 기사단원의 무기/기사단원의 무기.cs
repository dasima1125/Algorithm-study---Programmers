using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int number, int limit, int power) {
        List<int> list = new List<int>();
        int answer = 0;
        for (int i = 1; i <= number; i++)
        {
            int count = 0;
            for (int j = 1; j * j <= i; j++) 
            {
                if (i % j == 0) 
                {
                    count++; 
                    if (j * j != i) 
                    {
                        count++; 
                    }
                }
            }
            list.Add(count);  
            
        }
        
        
        foreach (var item in list) 
        {
            answer += (item > limit) ? power : item;
        }
        
        return answer;
    }
}