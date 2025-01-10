using System;
using System.Collections.Generic;

class Solution {
    public int solution(int[,] maps) {
        int n = maps.GetLength(0);
        int m = maps.GetLength(1);
        
        Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();
        bool [,] visited = new bool[n,m];
        int  [,] way     = {{0,1},{0,-1},{1,0},{-1,0}};//오른쪽 왼쪽 아래 위 위치값 저장
        
        queue.Enqueue(new Tuple<int,int>(0,0));
        visited[0,0] = true;
        
        int steps = 0; //초기 작업수 
        
        while(queue.Count > 0) 
        {
            int size = queue.Count; //할당되어있는 큐 수 확인
            for(int i = 0; i < size; i++) //저장되어있는 모든 큐를 분해후 작업
            {
                var temp = queue.Dequeue();
                int x = temp.Item1;
                int y = temp.Item2;
                
                if(x == n - 1 && y == m - 1) return steps + 1;// 도달위치 뭐 +1 하기 싫으면 스탭을 1부터 시작해도되긴함
                
                for (int d = 0; d < 4; d++)
                {
                    int nx = x + way[d, 0];  
                    int ny = y + way[d, 1]; 
                    if (nx >= 0 && nx < n && ny >= 0 && ny < m && maps[nx, ny] == 1 && !visited[nx, ny])// nx >= 0 && nx < n 배열의 탈출 방지
                    {                                                                                   // maps[nx, ny] == 1 가는 좌표 벽이 아닌지 확인       
                        queue.Enqueue(new Tuple<int, int>(nx, ny));                                     // !visited[nx, ny] 이미 전에 갔던곳인지 확인
                        visited[nx, ny] = true;
                    }
                
                }
                
            }
            steps++;// 이동 횟수 증가
        }
        return -1; //큐가 목표도착까지 다 소진시
    }
}