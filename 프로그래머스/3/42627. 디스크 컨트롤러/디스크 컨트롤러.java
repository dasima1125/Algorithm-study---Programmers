import java.util.*;
class Solution {
    public static int solution(int[][] jobs) {
        int answer = 0;
        //System.out.println(Arrays.deepToString(jobs));
        Arrays.sort(jobs, (a, b)-> a[0] - b[0]);
        //System.out.println(Arrays.deepToString(jobs));
        PriorityQueue<int[]> pq = new PriorityQueue<>((a, b)-> a[1] - b[1]);
      
        int count = 0;
        int index = 0;
        int end = 0;
        while(count < jobs.length)
        {
            while(index < jobs.length && jobs[index][0] <= end)
            {
                pq.add(jobs[index++]);
            }
            //System.out.println(Arrays.deepToString(pq.toArray()));
            
            if(pq.isEmpty()) end = jobs[index][0];
            else
            {
                int[] curr = pq.poll();
                answer += end - curr[0] + curr[1];
                end += curr[1];
                count++;
            }
        }
    
        return answer /= jobs.length;
    }
}