import java.util.HashSet;

class Solution {
    public boolean solution(String[] phone_book) { 
        HashSet<String> hash = new HashSet<>();

        for (String phone : phone_book) 
        {
            hash.add(phone);
        }
        for (String phone : phone_book) 
        {
            for (int i = 1; i <= phone.length() - 1; i++)    
             {
                if (hash.contains(phone.substring(0, i))) 
                {
                    return false;
                }
            }
            
        }
        return true;
    }
}