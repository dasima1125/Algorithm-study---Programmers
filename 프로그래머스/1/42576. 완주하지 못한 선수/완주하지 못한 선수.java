import java.util.HashMap;
class Solution {
    public String solution(String[] participant, String[] completion) {
        String answer = "";
        HashMap<String,Integer> set = new HashMap<>();
        for (String string : participant) 
        {
            set.put(string, set.getOrDefault(string, 0) + 1); 
        }

        for (String string : completion) 
        {
            set.put(string, set.get(string)-1);
        }
      
        for (String key : set.keySet()) 
        {
            if (set.get(key) == 1) 
            {
                answer = key;
                break; 
            }
        }
        return answer;
    }
}