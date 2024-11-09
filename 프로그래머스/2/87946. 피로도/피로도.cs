using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    
    static int answer = 0;
    
    public int solution(int k, int[,] dungeons) 
    {
        bool[] visited = new bool[dungeons.GetLength(0)];
        
        dfs(dungeons, visited, k);
        
        return answer;
    }
    public static void dfs(int[,] dungeons, bool[] visited, int k)
    {
        answer = Math.Max(answer, visited.Count(v => v));
        
        for (int i = 0; i < dungeons.GetLength(0); i++)
        {
            if (!visited[i] && dungeons[i, 0] <= k)
            {
                visited[i] = true;
                dfs(dungeons, visited, k - dungeons[i, 1]);
                visited[i] = false;
            }
       }
}
}