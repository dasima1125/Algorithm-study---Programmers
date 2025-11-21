import java.util.*;

class Solution {
    public int[] solution(int[] progresses, int[] speeds) {
        
        List<Integer> completeday = new ArrayList<>();
        List<Integer> result = new ArrayList<>();
        
        for(int i = 0; i < progresses.length; i++)
        {
             completeday.add((int)Math.ceil((100.0 - progresses[i]) / speeds[i]));// 반올림 필수 그냥 인트걸면 잔여일 날라감
        }
        int MaxDay = completeday.get(0);
        int count = 1;
         
        for(int i = 1; i < completeday.size();i++)
        {
            // 기준일 이하
            if(completeday.get(i) <= MaxDay)
                count++;
            // 기준일 초과
            else
            {
                result.add(count);           //그 동안 작업 적재
                MaxDay = completeday.get(i); //신규 기준일 재배치
                count = 1;                   //배포수량 초기화
            }
        }
        //남은배포수량 추가 
        result.add(count);
        return result.stream().mapToInt(i -> i).toArray();
    }
}