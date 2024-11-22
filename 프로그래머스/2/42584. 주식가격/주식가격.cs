using System;
using System.Collections.Generic;


public class Solution {
    public int[] solution(int[] prices) {
        
        List<int> list = new List<int>();
        for (int i = 0; i < prices.Length; i++)
        {
            int count = 0;
            for (int j = i + 1 ; j < prices.Length; j++) 
            {
                count++;
                
                if (prices[j] < prices[i])
                {
                    break;
                }
            }
            list.Add(count);
        }
        return list.ToArray();
    }
}