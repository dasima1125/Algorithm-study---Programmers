import java.util.*;

class Solution {
    public static int[] solution(String[] genres, int[] plays) {
        List <Integer> answer = new ArrayList<>();

        HashMap <String , Integer>   countmap = new HashMap<>();
        HashMap<String, List<int[]>> ordermap = new HashMap<>();

        for (int i = 0; i < genres.length; i++) 
        {
            countmap.put(genres[i], countmap.getOrDefault(genres[i],0) + plays[i]);
            if(!ordermap.containsKey(genres[i])) ordermap.put(genres[i], new ArrayList<>()); //ordermap.putIfAbsent(genres[i], new ArrayList<>()); <= 이걸로 대체 가능 
            ordermap.get(genres[i]).add(new int[]{i, plays[i]});                             //인수 주입 (순서 , 재생수)
           
        }
        
        //정렬순서   ==> 람다식 사용할때 많은 수부터라면 정렬을 거꾸로 하는걸 잊지말자.

        // 1. 많이 재생된 장르를 먼저 수록.
        ArrayList <String> order1 = new ArrayList<>(countmap.keySet());
        order1.sort((a,b) -> countmap.get(b) - countmap.get(a));
    
        for (String s : order1) 
        {
            int count = 0;
            List<int[]> songList = ordermap.get(s);
            // 2. 많이 재생된 노래를 먼저 수록. ordermap [1]인수(재생수) 기준으로 정렬
            songList.sort((a,b) ->  b[1] - a[1] );//많이 재생된 수 부터이므로 반대로 정렬
            // 3. 고유 번호가 낮은 노래를 먼저 수록.ordermap [0]인수(순서) 기준으로 정렬
            songList.sort((a,b) -> a[0]);
            
            for (int[] song : songList) {
                if (count >= 2) break;
                answer.add(song[0]);
                count++;
            }
            
        }
        
        return answer.stream().mapToInt(Integer::intValue).toArray();
    }
}