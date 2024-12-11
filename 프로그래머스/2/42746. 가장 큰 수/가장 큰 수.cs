using System;
using System.Linq;


public class Solution {
    public string solution(int[] numbers) {
    
        string[] strings = numbers.Select(x => x.ToString()).ToArray();
        Array.Sort(strings , (x , y) => (y + x).CompareTo(x + y));
        
        if (strings[0] == "0")
        {
            return "0";
        }
        
        return String.Join("", strings);
    }
}