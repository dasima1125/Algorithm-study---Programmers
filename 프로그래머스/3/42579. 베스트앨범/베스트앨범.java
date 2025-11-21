import java.util.*;

class Solution {
    public static int[] solution(String[] genres, int[] plays) {
        
        List<Integer> answer = new ArrayList<>();
        HashMap<String, Integer>     countMap = new HashMap<>(); //장르별 재생된 수 맵 
        HashMap<String, List<int[]>> orderMap = new HashMap<>(); //장르별 곡 맵

        for (int i = 0; i < genres.length; i++) 
            addMap(countMap, orderMap, genres[i], i, plays[i]);
        
        // 1.속한 노래가 많이 재생된 장르를 먼저 수록합니다.
        List<String> orderCount = new ArrayList<>(countMap.keySet()); // 장르별 재생된 종류 저장
        orderCount.sort((a, b) -> countMap.get(b) - countMap.get(a)); // 람다식 사용, 오더카운트를 정렬에 사용대신 카운트맵 이용 

        for (String genre : orderCount) 
            answer.addAll(selectTopSongs(orderMap.get(genre)));
        

        return answer.stream().mapToInt(Integer::intValue).toArray(); //정적배열로 리턴시켜줘야함 리스트는 박싱 클래스만쓸수있어서 어쩔수없음
        // answer를 스트림으로 전환 --> 매핑후 인트로 전환 --> 배열로전환
    }
    
    private static void addMap(Map<String, Integer> countMap, Map<String, List<int[]>> orderMap, String genre, int index, int play) 
    {
        //재생수 추가
        countMap.put(genre, countMap.getOrDefault(genre, 0) + play); // => 없으면 0인 맵 추가후 재생수 더함 , 있을경우 기존값에 재생수 더함
        
        //장르 추가
        orderMap.putIfAbsent(genre, new ArrayList<>()); // 장르저장배열 초기화(없으면 뭐.. 넘어가고)
        orderMap.get(genre).add(new int[]{index, play});// 장르배열에 해당곡 인덱스와 재생수 저장
    }

    private static List<Integer> selectTopSongs(List<int[]> songList) 
    {
        //songList.sort((a,b) ->  b[1] - a[1] ); // 재생수 기준 내림차순
        //songList.sort((a,b) -> a[0]); // 인덱스 기준 오름차순 
        songList.sort((a, b) -> b[1] != a[1] ? b[1] - a[1] : a[0] - b[0]);
        
        List<Integer> result = new ArrayList<>(); //리턴용 배열 생성
        
        for (int i = 0; i < Math.min(2, songList.size()); i++)  //최대 2, math함수로 만약 더적으면 적은수로
            result.add(songList.get(i)[0]); // 해당곡 인덱스 방출 [1] 의 경우 재생수임
        
        return result;
    }
}
