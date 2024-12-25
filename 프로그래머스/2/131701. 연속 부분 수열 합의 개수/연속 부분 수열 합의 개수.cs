using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] elements) {
        
        int[] modifiedTangerine = elements.Concat(elements).ToArray();
        List<int> list = new List<int>();
        for (int i = 1; i <= elements.Length; i++)
        {
            for (int j = 0; j < elements.Length; j++)
            {
                int count = 0;
        
                for (int k = 0; k < i; k++)
                {
                    count += modifiedTangerine[j + k];
                }
                list.Add(count);
            }
        }
        
        list = list.Distinct().ToList();
        list.Sort();
        return list.Count;
    }
}