public class Solution {
    public int MaxIncreasingSubarrays(IList<int> nums) {
        int n = nums.Count;
        if(n < 2) return 0;

        int[] left = new int[n];
        left[0] = 1;
        for(int i = 1; i < n; i++){
            if(nums[i] > nums[i -1]){
                left[i] = left[i -1] +1;
            }else{
                left[i]=1;
            }
        }

        int[] right = new int[n];
        right[n -1] = 1;
        for(int i = n -2; i >=0; i--){
            if(nums[i] < nums[i +1]){
                right[i] = right[i +1] + 1;
            }else{
                right[i]=1;
            }
        }

        int k = 0;

        for(int i =1; i < n; i++){
            int k1 = left[i - 1];
            int k2 = right[i];

            int current = Math.Min(k1, k2);

            k = Math.Max(k, current);
        }

        return k;
    }
}