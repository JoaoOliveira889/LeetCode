public class Solution {
    public bool CanJump(int[] nums) {
        int maxIndex = 0;
        int n = nums.Length;
        for(int i = 0; i < n; i++)
        {
            if(i > maxIndex) return false;

            maxIndex = Math.Max(maxIndex, i + nums[i]);

            if(maxIndex >= n - 1) return true;
        }

        return true;
    }
}