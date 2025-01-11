import java.util.Stack;

class Solution {
    public String solution(String number, int k) {
        
        Stack<Integer> stack = new Stack<>();

        int delete = number.length() - k;

        for (int i = 0; i < number.length(); i++) 
        {
            int temp = number.charAt(i) - '0';
            
            while (!stack.isEmpty() && k > 0 && stack.peek() < temp) 
            {
                stack.pop();
                k--;
            }
            stack.push(temp);
        }
        
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < delete; i++) 
        {
            sb.append(stack.get(i)); 
        }
        
        
        return sb.toString();
    }
}