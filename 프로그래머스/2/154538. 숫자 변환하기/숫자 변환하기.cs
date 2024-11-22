using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int x, int y, int n) {
        
        Queue<int[]> queue = new Queue<int[]>();
        queue.Enqueue(new int[] {x,0});
        
        bool[] check = new bool[y+1];
        
        while (queue.Count > 0)
        {
            int[] que = queue.Dequeue();
            int now   = que[0];
            int count = que[1];
            
            if (now == y) return count;
            
            if (now + n <= y && !check[now + n])
            {
                queue.Enqueue(new int[] { now + n, count + 1 });
                check[now + n] = true;
            }
            
            if (now *2 <= y && !check[now *2])
            {
                queue.Enqueue(new int[]{ now * 2, count + 1 });
                check[now * 2] = true;
            }
            if (now * 3 <= y && !check[now * 3])
            {
                queue.Enqueue(new int[] { now * 3, count + 1 });
                check[now * 3] = true;
            }
            
        }
        
        return -1;
    }
}