import java.util.*;
class Solution {
    static boolean[] visit;
    static int result = 0;
    
    public int solution(String begin, String target, String[] words) {
        visit = new boolean[words.length];
        dfs(begin, target, words, 0);
        return result;
    }
    public int dfs(String start , String target , String[] words, int count)
    {
        if(start.equals(target)) result = count;
        
        for (int i = 0; i < words.length; i++) 
        {
            if(visit[i]) continue;   
            if (LetterCheck(start, words[i])) 
            {
                visit[i] = true;
                dfs(words[i], target, words, count + 1);
                visit[i] = false;
            }   
        }
         
        return 0;
    }
    
    public static boolean LetterCheck(String a,String b)
    {
        int count = 0;
        for (int i = 0; i < a.length(); i++) 
        {
            if (a.charAt(i) != b.charAt(i)) count++; 
        }
        return count == 1;
    }
}