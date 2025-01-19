using System;

public class Solution {
    public int solution(string s) {
        string[] numbersCount = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string answer = " ";
        
        while(s.Length > 0)
        {
            if(char.IsDigit(s[0]))
            {
                answer += s[0];
                s = s.Substring(1);
                
            }
            else
            {
                for(int i =0;i < numbersCount.Length; i++)
                {
                    if(s.StartsWith(numbersCount[i]))
                    {
                        answer += i;
                        s = s.Substring(numbersCount[i].Length);
                    }
                } 
            }
        }
        
        return int.Parse(answer);
    }
}