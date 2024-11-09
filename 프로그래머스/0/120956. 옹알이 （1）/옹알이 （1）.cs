using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Solution {
    public int solution(string[] babbling) {
        List<string> inner = new List<string>(babbling);
        int answer = 0;

        foreach (string str in inner) 
        {
            string modifiedStr = str;
            modifiedStr = Regex.Replace(modifiedStr, "aya|ye|woo|ma", "");
            if (modifiedStr == "") answer++;

        }
        return answer;
    }
} 