using System;
using System.Collections.Generic;


public class Solution {
    public int[] solution(int n, long left, long right) {
        List<int> list = new List<int>();
        for (long i = left; i <= right; i++)
        {
            list.Add((int)Math.Max(i/n , i%n) + 1 );
        }

        return list.ToArray();
    }
}