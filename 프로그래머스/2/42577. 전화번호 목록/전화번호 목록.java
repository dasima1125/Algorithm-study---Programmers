import java.util.HashSet;

class Solution {
    public static boolean solution(String[] phone_book) { 
        HashSet<String> hash = new HashSet<>();

        for(String phone : phone_book) 
            hash.add(phone);
        
        for(String phone : phone_book) 
        {
                                                          
            for(int i = 1 ; i < phone.length(); i++)  
                // i 가 0부터 시작하면 서브스트링특성상 0,0이되버림 사실상의미없음 ==> 1부터 시작
                // phone이 전부 마지막문자열까지 검사해버리면 자기자신을 접두어로 인지함 고로 직전에 완성직전에멈춰야함 ==> <으로 직전 제한
                //1195524421경우 1 11 119 이때 3번째때 119를 해시에서 컨테인 메서드 사용 이프문으로 필터   
                if (hash.contains(phone.substring(0, i))) return false;
        }
        return true;
    }
}