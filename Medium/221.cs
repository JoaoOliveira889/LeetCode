public class Solution {
    public int MaximalSquare(char[][] matrix) {
        int rows = matrix.Length;
        if(row == 0) return 0;
        int cols = matrix[0].Length;
        if(cols == 0) return 0;

        int[,] dp = new int[rows, cols];

        int maxSize = 0;

        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                if(matrix[i][j] == '1')
                {
                    if(i == 0 || j ==0)
                        dp[i,j] = 1;
                    else
                        dp[i,j] = 1 + Math.Min(dp[i -1, j], Math.Min(dp[i, j-1], dp[i -1, j -1]));
                }

                maxSize = Math.Max(maxSize, dp[i, j]);
            }
        }

        return maxSize * maxSize;
    }
}