using System;

public class Solution {
    public string solution(string s, string skip, int index) {
        string answer = "";
        
        for(int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            int count = 0;

            while (count < index) {
                c++;
                if (c > 'z') c = 'a';

                if (!skip.Contains(c)) {
                    count++;
                }
            }
            answer += c;
        }
        return answer;
    }
}