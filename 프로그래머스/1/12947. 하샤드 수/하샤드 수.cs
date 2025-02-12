using System;

public class Solution {
    public bool solution(int x) {
        
        string insert = x.ToString();
        bool answer = false;
        int sum = 0;
        
        for (int i = 0; i < insert.Length; i++)
        {
            sum += int.Parse(insert[i].ToString());
        }
        
        if(x % sum ==0)answer = true;


        return answer;
    }
}