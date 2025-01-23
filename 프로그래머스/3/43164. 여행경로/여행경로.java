import java.util.*;
class Solution {
    private static boolean[] visited; 
    private static List<String> ways = new ArrayList<>();
    
    public static String[] solution(String[][] tickets) {
        visited = new boolean[tickets.length];

        dfs(0, "ICN", "ICN", tickets);
    
        ways.sort(null);
        
        
        String[] answer = ways.get(0).split(" ");
        return answer;
    }
    
    public static void dfs(int count, String start, String route, String[][] tickets) {
       
        if (count == tickets.length)// 모두 경유하면 리스트에 저장  
        {
            ways.add(route);
            return;
        }

        for (int i = 0; i < tickets.length; i++) 
        {
            if (tickets[i][0].equals(start) && !visited[i]) 
            {
                visited[i] = true;
                dfs(count + 1, tickets[i][1], route + " " + tickets[i][1], tickets);
                visited[i] = false;
            }
        }
        return;
    }
}