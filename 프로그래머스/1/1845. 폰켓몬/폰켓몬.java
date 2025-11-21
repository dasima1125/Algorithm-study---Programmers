import java.util.HashSet;
class Solution {
    public int solution(int[] nums) 
    {
        HashSet<Integer> set = new HashSet<>();
        for (Integer i : nums)  set.add(i); 

        return Math.min(set.size(), nums.length / 2);
    }
}