using System;
using System.Linq;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        
        int[] student = new int[n];
        Array.Fill(student, 1);
        for(int i = 0; i<lost.Length; i++)
        {
            student[lost[i] -1] -= 1;
            
        }
        for(int i = 0; i<reserve.Length; i++)
        {
            student[reserve[i] -1] += 1;
        }
        for(int i = 0; i < n; i++)
        {
            if(student[i] == 2)
            {
                if(i -1 >= 0 && student[i - 1] == 0)
                {
                    student[i - 1] = 1; 
                    student[i] = 1;
                }
                else if(i +1 < student.Length && student[i + 1]==0)
                {
                    student[i + 1] = 1;
                    student[i] = 1;
                }
            }
        }
        return student.Count(a => a >= 1);
    }
}