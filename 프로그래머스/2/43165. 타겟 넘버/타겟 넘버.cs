using System;
using System.Collections.Generic;

public class Solution {
    int count = 0;
    public int solution(int[] numbers, int target) {
        DFS(numbers, target,0,0); 
        return count;
    }
    public void DFS(int[] numbers, int target, int index, int sum)
    {
        if (index == numbers.Length)//분기 끝 카운트 시작
        {
            if (sum == target) count++;
            return;
        } 
        //넘버배열과 타겟 값은 계승 인덱스값은 분기생성당 +1 이고 다음값 더하기값과 빼기값 생성
        DFS(numbers, target, index + 1, sum + numbers[index]); 
        DFS(numbers, target, index + 1, sum - numbers[index]);
        
    }
}