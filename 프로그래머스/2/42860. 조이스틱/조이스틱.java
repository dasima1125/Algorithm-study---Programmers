class Solution {
    public int solution(String name) {
        int ticks = 0;
        int length = name.length();
        int move = length-1; 
        char[] chars = name.toCharArray();
        for (int i = 0; i < length; i++) 
        { 
            if (chars[i] != 'A') ticks += Math.min(chars[i]-'A', 'Z'-chars[i]+1);
            int next = i+1;
            while (next < length && chars[next] == 'A') next ++;
            
            move = Math.min(move, i*2+length-next); 
            move = Math.min(move, (length-next)*2 + i); 
        }
        return ticks + move;
    }
}