import java.util.*;

class Solution {
    static ArrayList<Integer>[] nodes;
    
    public int solution(int n, int[][] edge) {
    
        nodes = new ArrayList[n + 1];
        for (int i = 0; i < n + 1; i++) {
            nodes[i] = new ArrayList<>();
            
        }
        for (int[] node : edge) 
        {
            nodes[node[0]].add(node[1]);
            nodes[node[1]].add(node[0]);
            
        }
        return bfs(n, 1);
    }
    
    int bfs(int n, int start) {
        
        boolean [] visited = new boolean[n + 1];
        int[] distances = new int[n + 1];
        Queue<Integer> queue = new LinkedList<>();
        
        visited[start] = true;
        queue.offer(start);
        
        while (!queue.isEmpty()) {
            int current = queue.poll();
    
            for (int next : nodes[current]) 
            {
                if (!visited[next]) 
                {
                    visited[next] = true;
                    distances[next] = distances[current] + 1; 
                    queue.offer(next);
                }
            }
        } 
  
        int maxDistance = 0;
        int count = 0;

        for (int i = n; i > 0; i--) {
            if (distances[i] > maxDistance) 
            {
                maxDistance = distances[i];
                count = 1;
            } 
            else if (distances[i] == maxDistance) 
            {
                count++;
            }
        }

        return count;
        
    }
}