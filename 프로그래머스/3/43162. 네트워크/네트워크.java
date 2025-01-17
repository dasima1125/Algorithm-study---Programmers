import java.util.*;
class Solution {
    static boolean[] visit;
    public int solution(int n, int[][] computers) {
    //이미 인접행렬이있음 굳이 노드를 만들필요없이 걍 배열 가져오는게 더 나을듯?
        visit = new boolean[n];
        int count = 0;
        for (int i = 0; i < n; i++) 
        {
            if (!visit[i]) 
            {
                bfs(i, computers);
                count++; 
            }
        }
        return count;
    }
    public static void bfs(int startPoint, int[][] computers) {
        Queue<Integer> queue = new LinkedList<>();
        queue.offer(startPoint);// 작업 큐에 삽입
        visit[startPoint] = true;//시작부분 사용 판정

        while (!queue.isEmpty())//큐에담긴 작업들 순차적 실행 
        {
            int current = queue.poll();// 
            for (int i = 0; i < computers.length; i++) 
            {
                if (computers[current][i] == 1 && !visit[i]) 
                //연결된 노드 이전,이전후 이전한곳 큐에 넣고 방문한곳 처리
                {
                    visit[i] = true;
                    queue.offer(i);
                }
            }
        }
    }
}