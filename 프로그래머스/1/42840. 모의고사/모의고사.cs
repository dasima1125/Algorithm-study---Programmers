using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] answers) {
        List<int> score = new List<int>{0,0,0};
        List<int> result = new List<int>{};
        
        int[] one = { 1, 2, 3, 4, 5 };
        int[] two = { 2, 1, 2, 3, 2, 4, 2, 5 };
        int[] thr = { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };
        
        for(int i = 0; i < answers.Length; i++)
        {
            if(answers[i] == one[i % one.Length]) score[0]++;
            if(answers[i] == two[i % two.Length]) score[1]++;
            if(answers[i] == thr[i % thr.Length]) score[2]++;
        }
        
        for (int i = 0; i < score.Count; i++) 
        {
            if (score[i] == score.Max()) result.Add(i + 1); 
        }
        
        return result.ToArray();
        
    }
}