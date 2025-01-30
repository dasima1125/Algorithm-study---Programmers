using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int k, int m, int[] score) {
        int answer = 0;
        
        Array.Sort(score);
        Stack<int> stack = new Stack<int>(score);
        
        
            while(stack.Count >= m)
            {
                List<int> list = new List<int>();
                for(int j = 0; j <m; j++)
                {
                    if(stack.ElementAt(0) <= k)
                    {
                        list.Add(stack.ElementAt(0));
                        stack.Pop();
                    }
                    
                }
                list.Sort();
                answer += list[0] * m;
                
            }
            
        
        
        
        
        return answer;
    }
}