import java.util.LinkedList;
import java.util.Queue;

public class Solution {
    public int solution(int bridge_length, int weight, int[] truck_weights) {
        Queue<Integer> bridge = new LinkedList<>();
        int ticks = 0;
        int nowWeight = 0;

        for (int truck : truck_weights) 
        {
            while (true) {
                if (bridge.size() == bridge_length) nowWeight -= bridge.poll(); //큐 끝 트럭 나갈시 무게 뺴고 큐에서 삭제
                
                if (nowWeight + truck <= weight) //추가 가능시
                {
                    bridge.add(truck);
                    nowWeight += truck;
                    ticks++;
                    break; // 와일문 연산을 다음 트럭기준으로 옴김
                } 
                else  //추가 불가능
                {
                    bridge.add(0);
                    ticks++;
                }
            }
        }

        return ticks + bridge_length;
    }
}