using System;
using System.Linq;

public class Solution {
    public int solution(int[] d, int budget) {
        Array.Sort(d);
        return d.TakeWhile(n => (budget -= n) >= 0).Count();
    }
}