 using System;

public class Solution {
    public string solution(string s) {
        
        string answer = "";

        if (s[0].ToString() == " ")
            answer+= s[0];
        else
            answer+= s[0].ToString().ToUpper();

        for (int i = 1; i < s.Length; i++)
        {
            if (s[i].ToString() != " " && s[i-1].ToString() == " ")
                answer += s[i].ToString().ToUpper();
            else
                answer += s[i].ToString().ToLower();  
        }
        
        return answer;
    }
}