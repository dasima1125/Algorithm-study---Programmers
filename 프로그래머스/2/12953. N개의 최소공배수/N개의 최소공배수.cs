public class Solution {
    public int solution(int[] arr) {
        
        int sum = arr[0];
        
        for (int i = 0; i < arr.Length; i++)
        {
            sum = (sum * arr[i]) / gcd(sum, arr[i]);
        }
        
        return sum;
        
    }
    
    public int gcd(int a, int b){
        if (b == 0) return a;
        else return gcd(b, a % b);
    }
}