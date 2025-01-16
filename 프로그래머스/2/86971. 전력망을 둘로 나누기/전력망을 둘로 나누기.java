import java.util.*;
class Solution {
    static ArrayList<Integer>[] tree;
    
    public static int solution(int n, int[][] wires) {
        tree = new ArrayList[n + 1];
        int answer = Integer.MAX_VALUE;

        for (int i = 0; i < n + 1; i++) 
        {
            tree[i] = new ArrayList<>();//Integer 리스트 초기화
        }
        for (int[] node : wires) 
        {
            // 노드 생성
            tree[node[0]].add(node[1]);
            tree[node[1]].add(node[0]);
        }

        for (int[] wire : wires) {

            //노드 끊기 (양방향 제거, 생성과 반대원리)
            tree[wire[0]].remove(Integer.valueOf(wire[1])); 
            tree[wire[1]].remove(Integer.valueOf(wire[0])); 
        
            answer = Math.min(answer,bfs(n, wire[0])); //기존값과 비교후 낮은값 갱신.
            // 백트레킹
            tree[wire[0]].add(wire[1]);
            tree[wire[1]].add(wire[0]);
        }

        return answer;
    }
    public static int bfs(int n, int start) 
    {
        boolean[] visited = new boolean[n + 1];
        Queue<Integer> queue = new LinkedList<>();
        visited[start] = true;
        queue.offer(start);

        int count = 1;

        while (!queue.isEmpty()) 
        {
            int node = queue.poll();
            for (int chain : tree[node]) 
            {
                if (!visited[chain]) 
                {
                    visited[chain] = true;
                    queue.offer(chain);
                    count++;
                }
            }
        }
 
        return (int)Math.abs(count - (n- count));//차이값 구하기위해 절대값 반환
    }
}