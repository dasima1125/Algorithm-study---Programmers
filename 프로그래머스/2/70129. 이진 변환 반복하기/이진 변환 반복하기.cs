using System;

public class Solution {
    public int[] solution(string s) {
        int count_0       = 0;
        int count_convert = 0;

        while (s != "1")
        {
            count_0 += s.Length - s.Replace("0", "").Length;
            s = s.Replace("0", "");
            s = Convert.ToString(s.Length, 2);
            count_convert++;
        }
        
        return new int[] {count_convert,count_0};
    }
}