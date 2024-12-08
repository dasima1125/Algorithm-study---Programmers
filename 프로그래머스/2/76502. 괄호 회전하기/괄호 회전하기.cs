using System;
using System.Collections.Generic;
public class Solution {
    public int solution(string s) {
        int answer = 0;
        
        for(int i = 0; i < s.Length; i++)
        {
            s = s.Substring(1) + s[0];
            
            
            Stack<char> stack = new Stack<char>();
            
            foreach(char c in s)
            {
                if(stack.Count == 0)
                {
                    stack.Push(c);
                    continue;
                }
                if((c==')' && stack.Peek() =='(')||(c=='}' && stack.Peek() =='{')||(c==']' && stack.Peek() =='['))
                {
                    stack.Pop();
                    continue;
                }
                
                stack.Push(c);
                
            }
            
            if(stack.Count == 0) answer++;
        }
        return answer;
    }
}