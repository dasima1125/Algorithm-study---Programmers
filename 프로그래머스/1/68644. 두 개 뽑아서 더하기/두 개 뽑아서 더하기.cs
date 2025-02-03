using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] numbers) {
        
        List<int> list = new List<int>();
        
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < numbers.Length; j++)
            {
                if (i == j)
                    continue;
            
                list.Add(numbers[j] + numbers[i]);

            }
        }
        list.Sort();
        list = list.Distinct().ToList();
        
        return list.ToArray();
    }
}