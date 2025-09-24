public class Solution {
    public int Rob(int[] nums) {
        int numHouses = nums.Length;

        if (nums == null || numHouses == 0) return 0;
        
        if (numHouses == 1) return nums[0];
 
        int[] dp = new int[numHouses];

        dp[0] = nums[0];
        dp[1] = Math.Max(nums[0], nums[1]);

        for(int i = 2; i < numHouses; i++)
            dp[i] = Math.Max(dp[i -1], nums[i] + dp[i -2]);

        return dp[numHouses-1];
    }
}