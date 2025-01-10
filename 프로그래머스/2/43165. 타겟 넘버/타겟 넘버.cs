using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] numbers, int target) {
        Stack<Tuple<int, int>> stack = new Stack<Tuple<int, int>>();//스택 방식 재귀 방법도 있음
        stack.Push(new Tuple<int, int>(0, 0)); 
        int count = 0;
        
        while(stack.Count > 0)
        {
            var current =stack.Pop();       // 기존값 꺼냄 및 분해
            int index = current.Item1;      // 몇회 분기인지 저장
            int currentSum = current.Item2; // 지금까지의 총 합
            if (index == numbers.Length)    // 목표분기도달 성공: 생성 종료
            {
                // 목표 값에 도달했으면 카운트 증가
                if (currentSum == target) count++;
            }
            else                            // 목표분기도달 실패: 분기 생성
            {                               //인덱스 값 *1 과 * -1 생성
                stack.Push(new Tuple<int, int>(index + 1, currentSum + numbers[index]));
                stack.Push(new Tuple<int, int>(index + 1, currentSum - numbers[index]));
            }
            
        }
        return count;
    }
}