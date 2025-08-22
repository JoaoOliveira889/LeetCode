public class Solution {
	public long ZeroFilledSubarray(int[] nums) {	
		long result = 0;	
		long countZero = 0;  
		
		for(int i = 0; i < nums.Length; i++)
		{	
			if(nums[i] == 0)
				countZero +=1;
			
			else
				countZero = 0;
			
			result += countZero;	
		}
		
		return result;
	}

}