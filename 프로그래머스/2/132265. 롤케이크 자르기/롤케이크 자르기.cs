using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] topping) {
        int answer = 0;
        int n = topping.Length;

        Dictionary<int, int> leftToppings = new Dictionary<int, int>();
        Dictionary<int, int> rightToppings = new Dictionary<int, int>();

        for (int i = 0; i < n; i++)
        {
            if(rightToppings.ContainsKey(topping[i]))
            {
                rightToppings[topping[i]]++;
            } 
            
            else
            {
                rightToppings[topping[i]] = 1;
            }
        }

        int leftCount = 0;
        int rightCount = rightToppings.Count;

     
        for (int i = 0; i < n - 1; i++) 
        {
           
            if(leftToppings.TryGetValue(topping[i], out int count))
            {
                leftToppings[topping[i]]++;
            }
            
            else
            {
                leftToppings[topping[i]] = 1;
                leftCount++;
            }
            rightToppings[topping[i]]--;
            
            if (rightToppings[topping[i]] == 0) 
            {
                rightToppings.Remove(topping[i]);
                rightCount--;
            }

            if (leftCount == rightCount) {
                answer++;
            }
        }

        return answer;
    }
}
