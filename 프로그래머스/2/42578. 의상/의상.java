import java.util.HashMap;

class Solution {
    public int solution(String[][] clothes) {
        int answer = 1;

        HashMap <String , Integer> map = new HashMap<>();

        for(String[] strings : clothes) 
            map.put(strings[1],map.getOrDefault(strings[1], 0) + 1);
        
        //수식상 단순히 조합을 곱하는것이 아닌 안입는 경우도 생각해줘야함
        for (int  values : map.values()) 
            answer *= (values + 1); 
    
        //문제는 이러면 둘다 안입는경우의수가 딱 한번나옴, 그럼 하나 제거해주면됨.
        return answer - 1;
    }
}