class Solution {
    public int solution(int m, int n, int[][] puddles) {
        int div = 1000000007;
        int[][] route =new int[n][m];
         
        route[0][0] = 1;
      
        for(int[] puddle : puddles) route[puddle[1]-1][puddle[0]-1] = -1; //좌표상이면 x y겠지만 배열은 그반대임

        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j< m; j++)
            {
                if(route[i][j] == -1) //웅덩이 넘겨버리기
                {
                    route[i][j] = 0;
                    continue;
                }
                if( i > 0 ) route[i][j] += route[i-1][j] % div; //위쪽값 가져오기(맨위 행 일경우 해당안됨)
                
                if( j > 0 ) route[i][j] += route[i][j-1] % div; //왼쪽값 가져오기(맨 왼쪽 열일 경우 해당 안 됨)
                
            }
        }
     
        return route[n-1][m-1] % div;
    }
}