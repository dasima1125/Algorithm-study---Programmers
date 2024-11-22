using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] priorities, int location) {
        
        int answer = 0;
        Queue<int[]> queue = new Queue<int[]>();

        for (int i = 0; i < priorities.Length; i++) 
        {
            queue.Enqueue(new int[] { i , priorities[i] });
        }

        int[] target = new int[] { location , priorities[location] };

        while (true) 
        {
            int[] que = queue.Dequeue();
            if (queue.Any(p => p[1] > que[1])) queue.Enqueue(que);
            else 
            {
                answer++;
                if (que.SequenceEqual(target)) return answer; 
            }
        }
    }
}