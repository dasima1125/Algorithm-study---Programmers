using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public string solution(string s) {
    
        string[] a = s.Split(" ");
        List<int> b = new List<int>(a.Select(int.Parse));
        b.Sort();

        string answer = b[0] + " " + b[b.Count - 1];
        
        return answer;
    }
}