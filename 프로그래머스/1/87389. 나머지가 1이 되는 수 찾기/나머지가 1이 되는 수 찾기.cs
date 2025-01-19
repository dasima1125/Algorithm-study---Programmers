using System;
using System.Collections.Generic;
using System.Linq;


public class Solution {
    public int solution(int n) {
        List<int> list = new List<int>();
        
        for(int i = 1; i <= n ; i++)
        {
            if(n % i == 1)
                list.Add(i);
        }
        return list.Min();
    }
}