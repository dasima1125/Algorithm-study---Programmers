using System;

public class Solution {
    public int solution(string word) {
        int answer = 0;
        int[] c = { 781, 156, 31, 6, 1 };
        char[] arr = { 'A', 'E', 'I', 'O', 'U' };

        for (int i = 0; i < word.Length; i++) 
        {
            answer += Array.IndexOf(arr, word[i]) * c[i] + 1;
        }
        
        return answer;
    }
}