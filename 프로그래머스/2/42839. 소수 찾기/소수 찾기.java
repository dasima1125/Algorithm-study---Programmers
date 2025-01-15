import java.util.*;
class Solution {
    static List<Boolean> visited = new ArrayList<>();
    static HashSet<Integer> set = new HashSet<>();
    
    public int solution(String numbers) {
        int answer = 0;
        for(int i = 0; i < numbers.length(); i++) visited.add(false);
        dfs(numbers , 0, "");
        
        for(Integer i : set)
        {
            if(isprime(i)) answer++;
        }
        return answer;
    }
    
    private static void dfs(String numbers, int depth , String now)
    {
        
        //종단점 
        if(depth == numbers.length())
        {
            return;
        }
        
        for(int i = 0; i < numbers.length(); i++)
        {
            if(!visited.get(i))
            {
                visited.set(i,true);
                set.add(Integer.parseInt(now + numbers.charAt(i)));
                dfs(numbers,depth + 1,now + numbers.charAt(i));
                visited.set(i, false);
            }

        }
        
    }
    private static boolean isprime(int n)
    {
        if(n < 2) return false; // 2까지는 소수아님
        for (int i = 2; i <= (int)Math.sqrt(n); i++) 
        {
            if(n % i == 0) return false; //나눠지면 소수가아니겠죠?
        }
        return true;
    }
}