using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Solution {
    public int solution(string[] babbling) {
        List<string> inner = new List<string>(babbling);
        int answer = 0;

        foreach (string str in inner) 
        {
            if (Regex.IsMatch(str, "(ayaaya|yeye|woowoo|mama)")) //연속발음 필터를 추가해줍시다
                continue; 
            
            string modifiedStr = str;
            modifiedStr = Regex.Replace(modifiedStr, "aya|ye|woo|ma", "");
            if (modifiedStr == "") answer++;

        }
        return answer;
    }
} 