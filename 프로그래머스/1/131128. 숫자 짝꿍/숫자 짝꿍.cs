using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string solution(string X, string Y) {
        int[] countX = new int[10];
        int[] countY = new int[10];
        
        List<int> list = new List<int>();
        
         foreach (char c in X) {
            countX[c - '0']++;
        }
        foreach (char c in Y) {
            countY[c - '0']++;
        }
        
        for (int i = 0; i < 10; i++) 
        {
            int commonCount = Math.Min(countX[i], countY[i]);
            for (int j = 0; j < commonCount; j++) 
            {
                list.Add(i);
            }
        }
        
        
        list.Sort();
        list.Reverse();
        
        if(list.Count == 0)
            return "-1";
        
        if(list.All(x => x == 0))
            return "0"; 
    
        return (String.Join("",list));
    }
}