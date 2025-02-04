import java.util.Arrays;

class Solution {
    public int solution(int[] people, int limit) {
        Arrays.sort(people);
        int light = 0;
        int heavy = people.length - 1;
        int count = 0;
        System.out.println( light+ "/" +heavy);
        while (light <= heavy) 
        {  
            if (people[light] + people[heavy] <= limit) 
            {
                light++; 
            }
            heavy--; 
            count++; 
        }
        return count;
    }
}