
using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] ingredient) {
        int answer = 0;
        Stack<int> stack = new Stack<int>();

        foreach (int item in ingredient) {
            stack.Push(item);
            if (stack.Count >= 4) {

                if (stack.Peek() == 1 && stack.ElementAt(1) == 3 && stack.ElementAt(2) == 2 && stack.ElementAt(3) == 1) {
                    answer++;

                    stack.Pop();
                    stack.Pop();
                    stack.Pop();
                    stack.Pop();
                }
            }
        }

        return answer;
    }
}