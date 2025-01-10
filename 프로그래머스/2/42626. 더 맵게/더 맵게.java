import java.util.PriorityQueue;

class Solution {
    public int solution(int[] scoville, int K) {
        int count = 0;
        PriorityQueue<Integer> heap =  new PriorityQueue<>();
        for (Integer add : scoville) 
        {
            heap.add(add);
        }
        while (heap.size() > 1 && heap.peek() < K) 
        {
            int a = heap.poll();
            int b = heap.poll();
            
            int insert = a + (b * 2);
            heap.add(insert);
            count++;
        }
        return (heap.peek() < K) ? -1 : count;
    }
}